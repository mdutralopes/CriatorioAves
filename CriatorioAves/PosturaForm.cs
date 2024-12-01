using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Repositorio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class PosturaForm : Form
    {
        DataTable dtPostura;
        DataRow[] drPostura;
        DataTable dtCasal;
        DataTable dtEspecie;
        DataTable dtFilhos;

        Char statusPostura = 'T';
        TipoOperDB tpOper;

        public static Int16 ContadorFormPosturas = 0;

        public PosturaForm()
        {
            InitializeComponent();
            PreencherCombos();
            ObterRegistrosPosturas();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ObterRegistrosPosturas(Int64 idCasal = 0, Char indicAtivo = '0')
        {
            IPosturaRepos posRep = new PosturaRepos();
            dtPostura = posRep.ListaPosturas(idCasal, indicAtivo);
            drPostura = dtPostura.Select("Id > 0");
            bsPostura.DataSource = dtPostura;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            chkAtivo.Enabled = enabled;
            cbCasal.Enabled = enabled;
            dtpFinalPostura.Enabled = enabled;
            dtpInicioNascimento.Enabled = enabled;
            if (!dtpInicioNascimento.Visible)
                if (tpOper != TipoOperDB.Consulta)
                {
                    dtpInicioNascimento.Value = DateTime.Today;
                    dtpInicioNascimento.Visible = true;
                    dtpInicioNascimento.ShowCheckBox = true;
                    dtpInicioNascimento.Checked = false;
                }
            if (!dtpFinalPostura.Visible)
                if (tpOper != TipoOperDB.Consulta)
                {
                    dtpFinalPostura.Value = DateTime.Today;
                    dtpFinalPostura.Visible = true;
                    dtpFinalPostura.ShowCheckBox = true;
                    dtpFinalPostura.Checked = false;
                }
            dtpInicioPostura.Enabled = enabled;
            nudFilhotesCriados.Enabled = enabled;
            nudFilhotesNascidos.Enabled = enabled;
            nudOvosBrancos.Enabled = enabled;
            nudOvosGalados.Enabled = enabled;
            nudTotalOvos.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            btnFiltro.Enabled = !enabled;
            assBtn.Enabled = !enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            bnPostura.Enabled = !enabled;
        }

        private void PreencherCombos()
        {
            ICasalRepos casRep = new CasalRepos();
            dtCasal = casRep.ListaCasaisCombo();
            cbCasal.DataSource = dtCasal;
            cbCasal.DisplayMember = "Descr";
            cbCasal.ValueMember = "Id";

            //Espécie
            IEspecieRepos espRep = new EspecieRepos();
            dtEspecie = espRep.ListaEspecies();
            cbEspecie.DataSource = dtEspecie;
            cbEspecie.DisplayMember = "Nome";
            cbEspecie.ValueMember = "Id";
            cbEspecie.SelectedIndex = -1;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            tpOper = TipoOperDB.Consulta;
            ObterRegistrosPosturas();
            if (FiltroPosturaDlg.blnFiltroAtivo)
                AplicarFiltros();
            bsPostura_CurrentItemChanged(sender, e);
            HabilitarCampos(false);
        }

        private void altButton_Click(object sender, EventArgs e)
        {
            tpOper = TipoOperDB.Update;
            HabilitarCampos(true);
        }

        private void incButton_Click(object sender, EventArgs e)
        {
            tpOper = TipoOperDB.Insert;
            HabilitarCampos(true);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtIdPostura.Text = "0";
            chkAtivo.Checked = true;
            cbCasal.SelectedIndex = -1;
            dtpInicioPostura.Value = DateTime.Today;
            dtpFinalPostura.Value = new DateTime(1753, 1, 1);
            dtpInicioNascimento.Value = new DateTime(1753, 1, 1);
            nudFilhotesCriados.Value = 0;
            nudFilhotesNascidos.Value = 0;
            nudOvosBrancos.Value = 0;
            nudOvosGalados.Value = 0;
            nudTotalOvos.Value = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IPosturaRepos posRep = new PosturaRepos();
            Postura postura = new Postura();
            postura.IdCasal = (int)cbCasal.SelectedValue;
            postura.FilhotesCriados = Convert.ToInt16(nudFilhotesCriados.Value);
            postura.FilhotesNascidos = Convert.ToInt16(nudFilhotesNascidos.Value);
            if (dtpFinalPostura.ShowCheckBox)
            {
                if (dtpFinalPostura.Checked)
                    postura.FinalPostura = dtpFinalPostura.Value;
            }
            else
                postura.FinalPostura = dtpFinalPostura.Value;
            if (dtpInicioNascimento.ShowCheckBox)
            {
                if (dtpInicioNascimento.Checked)
                    postura.InicioNascimento = dtpInicioNascimento.Value;
            }
            else
                postura.InicioNascimento = dtpInicioNascimento.Value;
            postura.InicioPostura = dtpInicioPostura.Value;
            postura.NumeroOvos = Convert.ToInt16(nudTotalOvos.Value);
            postura.OvosBrancos = Convert.ToInt16(nudOvosBrancos.Value);
            postura.OvosGalados = Convert.ToInt16(nudOvosGalados.Value);
            if (chkAtivo.Checked)
                postura.IndicAtivo = 'S';
            else
                postura.IndicAtivo = 'N';
            if (tpOper == TipoOperDB.Insert)
            {
                if (!posRep.IncluirRegistroPostura(postura))
                    return;
            }
            else
            {
                postura.IdPostura = Convert.ToInt32(txtIdPostura.Text);
                if (!posRep.AlterarRegistroPostura(postura))
                    return;
            }
            tpOper = TipoOperDB.Consulta;
            ObterRegistrosPosturas();
            if (FiltroPosturaDlg.blnFiltroAtivo)
                AplicarFiltros();
            bsPostura_CurrentItemChanged(sender, e);
            HabilitarCampos(false);
        }

        private void bsPostura_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtPostura.Rows.Count > 0)
            {
                txtIdPostura.Text = drPostura[bsPostura.Position].Field<int>(0).ToString("00000");
                cbCasal.SelectedIndex = ObterIndiceCasal(drPostura[bsPostura.Position].Field<int>(1).ToString());
                dtpInicioPostura.Value = Convert.ToDateTime(drPostura[bsPostura.Position].Field<DateTime>(2).ToString());
                if (drPostura[bsPostura.Position].Field<DateTime?>(3) != null)
                {
                    dtpFinalPostura.Visible = true;
                    dtpFinalPostura.Value = Convert.ToDateTime(drPostura[bsPostura.Position].Field<DateTime>(3).ToString());
                    dtpFinalPostura.ShowCheckBox = false;
                }
                else
                {
                    dtpFinalPostura.Visible = false;
                    dtpFinalPostura.ShowCheckBox = true;
                    dtpFinalPostura.Checked = false;
                }
                if (drPostura[bsPostura.Position].Field<DateTime?>(4) != null)
                {
                    dtpInicioNascimento.Visible = true;
                    dtpInicioNascimento.Value = Convert.ToDateTime(drPostura[bsPostura.Position].Field<DateTime>(4).ToString());
                }
                else
                {
                    dtpInicioNascimento.Visible = false;
                }
                nudTotalOvos.Value = Convert.ToDecimal(drPostura[bsPostura.Position].Field<int>(5).ToString());
                nudOvosGalados.Value = Convert.ToDecimal(drPostura[bsPostura.Position].Field<int>(6).ToString());
                nudOvosBrancos.Value = Convert.ToDecimal(drPostura[bsPostura.Position].Field<int>(7).ToString());
                nudFilhotesNascidos.Value = Convert.ToDecimal(drPostura[bsPostura.Position].Field<int>(8).ToString());
                nudFilhotesCriados.Value = Convert.ToDecimal(drPostura[bsPostura.Position].Field<int>(9).ToString());
                if (Convert.ToChar(drPostura[bsPostura.Position].Field<string>(10).ToString()) == 'S')
                    chkAtivo.Checked = true;
                else
                    chkAtivo.Checked = false;
                //grid com os filhos
                IAveRepos aveRep = new AveRepos();
                dtFilhos = aveRep.ListaFilhotesPostura(Convert.ToInt32(txtIdPostura.Text));
                dgvFilhotesPostura.DataSource = dtFilhos;
                filhotesPage.Text = "Filhotes(" + dgvFilhotesPostura.RowCount.ToString("00") + ")";
                ConfigurarGridFilhotes();
            }
            else
                LimparCampos();
        }

        private void ConfigurarGridFilhotes()
        {
            dgvFilhotesPostura.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvFilhotesPostura.RowHeadersWidth = 25;

            dgvFilhotesPostura.Columns["IdentAve"].HeaderText = "Identificação";
            dgvFilhotesPostura.Columns["IdentAve"].Width = 120;

            dgvFilhotesPostura.Columns["SexoAve"].HeaderText = "Sexo";
            dgvFilhotesPostura.Columns["SexoAve"].Width = 90;
            dgvFilhotesPostura.Columns["SexoAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotesPostura.Columns["SexoAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFilhotesPostura.Columns["MutacaoAve"].HeaderText = "Cor/Mutação";
            dgvFilhotesPostura.Columns["MutacaoAve"].Width = 180;

            dgvFilhotesPostura.Columns["DtNascAve"].HeaderText = "Nascimento";
            dgvFilhotesPostura.Columns["DtNascAve"].Width = 100;
            dgvFilhotesPostura.Columns["DtNascAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotesPostura.Columns["DtNascAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFilhotesPostura.Columns["NumGaiola"].HeaderText = "Gaiola";
            dgvFilhotesPostura.Columns["NumGaiola"].Width = 60;
            dgvFilhotesPostura.Columns["NumGaiola"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotesPostura.Columns["NumGaiola"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFilhotesPostura.Columns["NumGaiola"].DefaultCellStyle.Format = "000";
        }

        private Int32 ObterIndiceCasal(String codigo)
        {
            Int32 codRet = -1;
            for (int i = 0; i < cbCasal.Items.Count; i++)
            {
                var drPostura = cbCasal.Items[i] as DataRowView;
                if (drPostura.Row["Id"].ToString() == codigo)
                    codRet = i;
            }
            return codRet;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IPosturaRepos posRep = new PosturaRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                posRep.ExcluirRegistroPostura(Convert.ToInt32(txtIdPostura.Text));
                ObterRegistrosPosturas();
                if (FiltroPosturaDlg.blnFiltroAtivo)
                    AplicarFiltros();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            DialogResult drFiltro;
            FiltroPosturaDlg filtroDlg = new FiltroPosturaDlg();
            drFiltro = filtroDlg.ShowDialog();
            if (drFiltro == DialogResult.OK)
                AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            Char chrFiltroAtivo = '0';
            if (FiltroPosturaDlg.filtroPostura.FiltrarAtivo)
            {
                if (FiltroPosturaDlg.filtroPostura.ValorFiltroAtivo)
                    chrFiltroAtivo = 'S';
                else
                    chrFiltroAtivo = 'N';
            }
            Int64 idCasal = 0;
            if (FiltroPosturaDlg.filtroPostura.FiltrarCasal)
            {
                idCasal = FiltroPosturaDlg.filtroPostura.IdCasalFiltro;
            }
            ObterRegistrosPosturas(idCasal, chrFiltroAtivo);
        }

        private void PosturaForm_Load(object sender, EventArgs e)
        {
            ContadorFormPosturas++;
        }

        private void PosturaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormPosturas--;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            IPosturaRepos posRep = new PosturaRepos();
            Int32 idEspecie = 0;
            if ((int)cbEspecie.SelectedIndex > 0)
                idEspecie = (int)cbEspecie.SelectedValue;
            ResumoPostura postura = posRep.ResumoPosturas(dtpIniPosturas.Value, dtpFimPosturas.Value, statusPostura, idEspecie);
            nudResTotPost.Value = postura.TotalPosturas;
            nudResOvosPostos.Value = postura.PosturaResumo.NumeroOvos;
            nudResOvosGalados.Value = postura.PosturaResumo.OvosGalados;
            nudResOvosBrancos.Value = postura.PosturaResumo.OvosBrancos;
            nudResNascidos.Value = postura.PosturaResumo.FilhotesNascidos;
            nudResCriados.Value = postura.PosturaResumo.FilhotesCriados;
        }

        private void rbnTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnTodas.Checked)
                statusPostura = 'T';
        }

        private void rbnAtivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnAtivas.Checked)
                statusPostura = 'A';
        }

        private void rbnInativas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnInativas.Checked)
                statusPostura = 'I';
        }

        private void chkFiltrarEspecie_CheckedChanged(object sender, EventArgs e)
        {
            cbEspecie.Enabled = chkFiltrarEspecie.Checked;
        }

        private void assBtn_Click(object sender, EventArgs e)
        {
            DialogResult drAssocia;
            PosturaAvesDlg assocoDlg = new PosturaAvesDlg();
            drAssocia = assocoDlg.ShowDialog();
            if (drAssocia == DialogResult.OK)
                CriaAssociacaoPosturaFilhote();
        }

        private void CriaAssociacaoPosturaFilhote()
        {
            IAveRepos aveRep = new AveRepos();
            Ave ave = new Ave();
            aveRep.IncluirRegistroAve(ave, Convert.ToInt64(txtIdPostura.Text));   
        }
    }
}
