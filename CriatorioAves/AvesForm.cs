using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Repositorio;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class AvesForm : Form
    {
        public static Int16 ContadorFormAves = 0;
        DataTable dtAve;
        DataRow[] drAve;
        DataTable dtEspecie;
        DataTable dtCriador;
        DataTable dtGaiola;
        DataTable dtPai;
        DataTable dtMae;
        DataTable dtFilhos;
        TipoOperDB tpOper;

        public AvesForm()
        {
            InitializeComponent();
            PreencherCombos();
            ObterRegistrosAves();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ConfigurarGridFilhos()
        {
            dgvFilhotes.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvFilhotes.RowHeadersWidth = 25;

            dgvFilhotes.Columns["IdentAve"].HeaderText = "Identificação";
            dgvFilhotes.Columns["IdentAve"].Width = 160;

            dgvFilhotes.Columns["SexoAve"].HeaderText = "Sexo";
            dgvFilhotes.Columns["SexoAve"].Width = 50;
            dgvFilhotes.Columns["SexoAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotes.Columns["SexoAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFilhotes.Columns["MutacaoAve"].HeaderText = "Cor/Mutação";
            dgvFilhotes.Columns["MutacaoAve"].Width = 180;

            dgvFilhotes.Columns["DtNascAve"].HeaderText = "Nascimento";
            dgvFilhotes.Columns["DtNascAve"].Width = 100;
            dgvFilhotes.Columns["DtNascAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotes.Columns["DtNascAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFilhotes.Columns["NumGaiola"].HeaderText = "Gaiola";
            dgvFilhotes.Columns["NumGaiola"].Width = 100;
            dgvFilhotes.Columns["NumGaiola"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotes.Columns["NumGaiola"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PreencherCombos()
        {
            //Espécie
            IEspecieRepos espRep = new EspecieRepos();
            dtEspecie = espRep.ListaEspecies();
            cbEspecie.DataSource = dtEspecie;
            cbEspecie.DisplayMember = "Nome";
            cbEspecie.ValueMember = "Id";

            //Criador
            ICriadorRepos criRep = new CriadorRepos();
            dtCriador = criRep.ListaCriadores();
            cbCriador.DataSource = dtCriador;
            cbCriador.DisplayMember = "Nome";
            cbCriador.ValueMember = "Id";

            //Gaiola
            IGaiolaRepos gaiRep = new GaiolaRepos();
            dtGaiola = gaiRep.ListaGaiolas();
            cbGaiola.DataSource = dtGaiola;
            cbGaiola.DisplayMember = "Descr";
            cbGaiola.ValueMember = "Id";
        }

        private void PreencherComboPaiMae()
        {
            //Pai
            IAveRepos aveRep = new AveRepos();
            dtPai = aveRep.ListaAvesCombo(Convert.ToInt32(txtIdAve.Text), (int)cbEspecie.SelectedValue, 'M');
            cbPai.DataSource = dtPai;
            cbPai.DisplayMember = "Descr";
            cbPai.ValueMember = "Id";
            cbPai.SelectedIndex = -1;

            //Mãe
            dtMae = aveRep.ListaAvesCombo(Convert.ToInt32(txtIdAve.Text), (int)cbEspecie.SelectedValue, 'F');
            cbMae.DataSource = dtMae;
            cbMae.DisplayMember = "Descr";
            cbMae.ValueMember = "Id";
            cbMae.SelectedIndex = -1;
        }

        private void ObterRegistrosAves(Char sexo = 'T', Int32 idEspecie = 0, 
                                        StatusAve? statusAve = null, Int32 idGaiola = 0, Int32 idCriador = 0, Int32 anoNasc = 0)
        {
            IAveRepos aveRep = new AveRepos();
            dtAve = aveRep.ListaAves(sexo, idEspecie, statusAve, idGaiola, idCriador, anoNasc);
            drAve = dtAve.Select("IdAve > 0");
            bsAve.DataSource = dtAve;
        }
        
        private void HabilitarCampos(Boolean enabled)
        {
            txtIdentAve.Enabled = enabled;
            rbnFemea.Enabled = enabled;
            rbnMacho.Enabled = enabled;
            rbnDesconhecido.Enabled = enabled;
            cbEspecie.Enabled = enabled;
            txtCorMutacao.Enabled = enabled;
            txtNome.Enabled = enabled;
            dtpNascimento.Enabled = enabled;
            cbStatus.Enabled = enabled;
            cbCriador.Enabled = enabled;
            dtpDataCompra.Enabled = enabled;
            mskValor.Enabled = enabled;
            cbGaiola.Enabled = enabled;
            cbPai.Enabled = enabled;
            cbMae.Enabled = enabled;
            txtObs.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            bnAve.Enabled = !enabled;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            ObterRegistrosAves();
            if (FiltroAveDlg.blnFiltroAtivo)
                AplicarFiltros();
            bsAve_CurrentItemChanged(sender, e);
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
            txtIdAve.Text = "0";
            txtIdentAve.Text = "";
            rbnFemea.Checked = false;
            rbnMacho.Checked = false;
            rbnDesconhecido.Checked = false;
            cbEspecie.SelectedIndex = -1;
            txtCorMutacao.Text = "";
            txtNome.Text = "";
            dtpNascimento.Value = DateTime.Today;
            cbStatus.SelectedIndex = -1;
            cbCriador.SelectedIndex = -1;
            dtpDataCompra.Value = DateTime.Today;
            mskValor.Text = "0,00";
            cbGaiola.SelectedIndex = -1;
            cbPai.SelectedIndex = -1;
            cbMae.SelectedIndex = -1;
            txtObs.Text = "";
            lblAcasalado.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IAveRepos aveRep = new AveRepos();
            Ave ave = new Ave();
            VerificacaoPreenchimento verif = new VerificacaoPreenchimento();
            ave.Identificacao = txtIdentAve.Text;
            ave.Sexo = VerificaSexoAve();
            if (cbEspecie.SelectedIndex >= 0)
                ave.IdEspecie = (int)cbEspecie.SelectedValue;
            else
                ave.IdEspecie = -1;
            ave.CorMutacao = txtCorMutacao.Text;
            ave.NomeAve = txtNome.Text;
            ave.DataNascimento = dtpNascimento.Value;
            if (cbStatus.SelectedIndex >= 0)
                ave.Status = (StatusAve)cbStatus.SelectedIndex;
            else
                ave.Status = (StatusAve)(-1);
            if (cbCriador.SelectedIndex >= 0)
                ave.IdCriador = (int)cbCriador.SelectedValue;
            else
                ave.IdCriador = -1;
            ave.DataCompra = dtpDataCompra.Value;
            ave.Valor = Convert.ToDouble(mskValor.Text);
            if (cbGaiola.SelectedIndex >= 0)
                ave.IdGaiola = (int)cbGaiola.SelectedValue;
            else
                ave.IdGaiola = -1;
            if (cbPai.SelectedValue == null)
                ave.IdPaiAve = -1;
            else
                ave.IdPaiAve = (int)cbPai.SelectedValue;
            if (cbMae.SelectedValue == null)
                ave.IdMaeAve = -1;
            else
                ave.IdMaeAve = (int)cbMae.SelectedValue;
            ave.Observacao = txtObs.Text;
            if (!verif.VerificarCamposPreenchidos(ave))
            {
                MessageBox.Show(verif.ObterCamposVazios());
                return;
            }
            if (tpOper == TipoOperDB.Insert)
            {
                if (!aveRep.IncluirRegistroAve(ave))
                    return;
            }
            else
            {
                ave.IdAve = Convert.ToInt32(txtIdAve.Text);
                if (!aveRep.AlterarRegistroAve(ave))
                    return;
            }
            HabilitarCampos(false);
            ObterRegistrosAves();
            if (FiltroAveDlg.blnFiltroAtivo)
                AplicarFiltros();
            tpOper = TipoOperDB.Consulta;
            bsAve_CurrentItemChanged(sender, e);
        }

        private Char VerificaSexoAve()
        {
            if (rbnMacho.Checked)
                return 'M';
            else if (rbnFemea.Checked)
                return 'F';
            else
                return 'D';
        }

        private void bsAve_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtAve.Rows.Count > 0)
            {
                txtIdAve.Text = drAve[bsAve.Position].Field<int>(0).ToString("00000");
                txtIdentAve.Text = drAve[bsAve.Position].Field<string>(1).ToString();
                AjustaSexoAve();
                cbEspecie.SelectedIndex = ObterIndiceEspecie(drAve[bsAve.Position].Field<int>(3).ToString());
                txtCorMutacao.Text = drAve[bsAve.Position].Field<string>(4).ToString();
                txtNome.Text = drAve[bsAve.Position].Field<string>(5).ToString();
                dtpNascimento.Value = Convert.ToDateTime(drAve[bsAve.Position].Field<DateTime>(6).ToString());
                cbStatus.SelectedIndex = Convert.ToInt32(drAve[bsAve.Position].Field<int>(7).ToString());
                cbCriador.SelectedIndex = ObterIndiceCriador(drAve[bsAve.Position].Field<int>(8).ToString());
                dtpDataCompra.Value = Convert.ToDateTime(drAve[bsAve.Position].Field<DateTime>(9).ToString());
                mskValor.Text = drAve[bsAve.Position].Field<double>(10).ToString("N2");
                cbGaiola.SelectedIndex = ObterIndiceGaiola(drAve[bsAve.Position].Field<int>(11).ToString());
                PreencherComboPaiMae();
                if (drAve[bsAve.Position].Field<int?>(12) == null)
                    cbPai.SelectedIndex = -1;
                else
                    cbPai.SelectedIndex = ObterIndicePaiMae(drAve[bsAve.Position].Field<int>(12).ToString(), 'P');
                if (drAve[bsAve.Position].Field<int?>(13) == null)
                    cbMae.SelectedIndex = -1;
                else
                    cbMae.SelectedIndex = ObterIndicePaiMae(drAve[bsAve.Position].Field<int>(13).ToString(), 'M');
                txtObs.Text = drAve[bsAve.Position].Field<string>(14).ToString();
                // grid com os filhos
                IAveRepos aveRep = new AveRepos();
                dtFilhos = aveRep.ListaFilhos(Convert.ToInt32(txtIdAve.Text));
                dgvFilhotes.DataSource = dtFilhos;
                filhotesPage.Text = "Filhotes(" + dgvFilhotes.RowCount.ToString("00") + ")";
                ConfigurarGridFilhos();
                // pedigree
                PreenchimentoPedigree.MontarPedigree(Convert.ToInt32(txtIdAve.Text));
                PreencherPedigree();
                lblAcasalado.Text = aveRep.DescrParAve(Convert.ToInt32(txtIdAve.Text), Convert.ToChar(drAve[bsAve.Position].Field<string>(2).ToString()));
            }
            else
                LimparCampos();
        }

        private void PreencherPedigree()
        {
            txtAve.Text   = PreenchimentoPedigree.listaPedigree[0].DescrAve;
            txtPai_1.Text = PreenchimentoPedigree.listaPedigree[0].DescrPai;
            txtPai_1.Visible = txtPai_1.Text != "";
            txtMae_1.Text = PreenchimentoPedigree.listaPedigree[0].DescrMae;
            txtMae_1.Visible = txtMae_1.Text != "";
            txtPai_2.Text = PreenchimentoPedigree.listaPedigree[1].DescrPai;
            txtPai_2.Visible = txtPai_2.Text != "";
            txtMae_2.Text = PreenchimentoPedigree.listaPedigree[1].DescrMae;
            txtMae_2.Visible = txtMae_2.Text != "";
            txtPai_3.Text = PreenchimentoPedigree.listaPedigree[2].DescrPai;
            txtPai_3.Visible = txtPai_3.Text != "";
            txtMae_3.Text = PreenchimentoPedigree.listaPedigree[2].DescrMae;
            txtMae_3.Visible = txtMae_3.Text != "";
            txtPai_4.Text = PreenchimentoPedigree.listaPedigree[3].DescrPai;
            txtPai_4.Visible = txtPai_4.Text != "";
            txtMae_4.Text = PreenchimentoPedigree.listaPedigree[3].DescrMae;
            txtMae_4.Visible = txtMae_4.Text != "";
            txtPai_5.Text = PreenchimentoPedigree.listaPedigree[4].DescrPai;
            txtPai_5.Visible = txtPai_5.Text != "";
            txtMae_5.Text = PreenchimentoPedigree.listaPedigree[4].DescrMae;
            txtMae_5.Visible = txtMae_5.Text != "";
            txtPai_6.Text = PreenchimentoPedigree.listaPedigree[5].DescrPai;
            txtPai_6.Visible = txtPai_6.Text != "";
            txtMae_6.Text = PreenchimentoPedigree.listaPedigree[5].DescrMae;
            txtMae_6.Visible = txtMae_6.Text != "";
            txtPai_7.Text = PreenchimentoPedigree.listaPedigree[6].DescrPai;
            txtPai_7.Visible = txtPai_7.Text != "";
            txtMae_7.Text = PreenchimentoPedigree.listaPedigree[6].DescrMae;
            txtMae_7.Visible = txtMae_7.Text != "";
        }

        private int ObterIndicePaiMae(String codigo, Char pm)
        {
            Int32 codRet = -1;
            Int32 countCombo;
            if (pm == 'P')
                countCombo = cbPai.Items.Count;
            else
                countCombo = cbMae.Items.Count;
            for (int i = 0; i < countCombo; i++)
            {
                if (pm == 'P')
                {
                    var drPai = cbPai.Items[i] as DataRowView;
                    if (drPai.Row["Id"].ToString() == codigo)
                        codRet = i;
                }
                else
                {
                    var drMae = cbMae.Items[i] as DataRowView;
                    if (drMae.Row["Id"].ToString() == codigo)
                        codRet = i;
                }
            }
            return codRet;
        }

        private Int32 ObterIndiceGaiola(String codigo)
        {
            Int32 codRet = -1;
            for (int i = 0; i < cbGaiola.Items.Count; i++)
            {
                var drGaiola = cbGaiola.Items[i] as DataRowView;
                if (drGaiola.Row["Id"].ToString() == codigo)
                    codRet = i;
            }
            return codRet;
        }

        private Int32 ObterIndiceCriador(String codigo)
        {
            Int32 codRet = -1;
            for (int i = 0; i < cbCriador.Items.Count; i++)
            {
                var drCriador = cbCriador.Items[i] as DataRowView;
                if (drCriador.Row["Id"].ToString() == codigo)
                    codRet = i;
            }
            return codRet;
        }

        private Int32 ObterIndiceEspecie(String codigo)
        {
            Int32 codRet = -1;
            for (int i = 0; i < cbEspecie.Items.Count; i++)
            {
                var drEspecie = cbEspecie.Items[i] as DataRowView;
                if (drEspecie.Row["Id"].ToString() == codigo)
                    codRet = i;
            }
            return codRet;
        }

        private void AjustaSexoAve()
        {
            if (drAve[bsAve.Position].Field<string>(2).ToString() == "M")
                rbnMacho.Checked = true;
            else if (drAve[bsAve.Position].Field<string>(2).ToString() == "F")
                rbnFemea.Checked = true;
            else
                rbnDesconhecido.Checked = true;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IAveRepos aveRep = new AveRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                aveRep.ExcluirRegistroAve(Convert.ToInt32(txtIdAve.Text));
                ObterRegistrosAves();
                if (FiltroAveDlg.blnFiltroAtivo)
                    AplicarFiltros();
            }
        }

        private void cbEspecie_Leave(object sender, EventArgs e)
        {
            PreencherComboPaiMae();
        }

        private void AvesForm_Load(object sender, EventArgs e)
        {
            ContadorFormAves++;
        }

        private void AvesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormAves--;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            DialogResult drFiltro;
            FiltroAveDlg filtroDlg = new FiltroAveDlg();
            drFiltro = filtroDlg.ShowDialog();
            if (drFiltro == DialogResult.OK)
                AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            Char sexoAve = 'T';
            Int32 idEspecie = 0;
            StatusAve? statusAve = null;
            Int32 idGaiola = 0; 
            Int32 idCriador = 0;
            Int32 anoNasc = 0;

            if (FiltroAveDlg.filtroAve.FiltrarSexo)
                sexoAve = FiltroAveDlg.filtroAve.Sexo;

            if (FiltroAveDlg.filtroAve.FiltrarEspecie)
                idEspecie = FiltroAveDlg.filtroAve.IdEspecie;

            if (FiltroAveDlg.filtroAve.FiltrarStatus)
                statusAve = FiltroAveDlg.filtroAve.StatusAve;

            if (FiltroAveDlg.filtroAve.FiltrarGaiola)
                idGaiola = FiltroAveDlg.filtroAve.IdGaiola;

            if (FiltroAveDlg.filtroAve.FiltrarCriador)
                idCriador = FiltroAveDlg.filtroAve.IdCriador;

            if (FiltroAveDlg.filtroAve.FiltrarAnoNasc)
                anoNasc = FiltroAveDlg.filtroAve.AnoNasc;

            ObterRegistrosAves(sexoAve, idEspecie, statusAve, idGaiola, idCriador, anoNasc);
        }
    }
}
