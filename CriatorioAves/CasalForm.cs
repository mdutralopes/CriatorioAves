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
    public partial class CasalForm : Form
    {
        public static Int16 ContadorFormCasal = 0;

        DataTable dtCasal;
        DataRow[] drCasal;
        DataTable dtPai;
        DataTable dtMae;
        DataTable dtFilhos;
        DataTable dtPoturas;
        DataTable dtEspecie;
        DataTable dtGaiola;
        TipoOperDB tpOper;

        public CasalForm()
        {
            InitializeComponent();
            PreencherCombos();
            ObterRegistrosCasais();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ObterRegistrosCasais()
        {
            ICasalRepos casRep = new CasalRepos();
            dtCasal = casRep.ListaCasais();
            drCasal = dtCasal.Select("IdCasal > 0");
            bsCasais.DataSource = dtCasal;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            cbEspecie.Enabled = enabled;
            dtpJuncao.Enabled = enabled;
            dtpSeparacao.Enabled = enabled;
            cbGaiola.Enabled = enabled;
            cbPai.Enabled = enabled;
            cbMae.Enabled = enabled;
            dtpSeparacao.Enabled = enabled;
            if (!dtpSeparacao.Visible)
                if (tpOper != TipoOperDB.Consulta)
                {
                    dtpSeparacao.Value = DateTime.Today;
                    dtpSeparacao.Visible = true;
                    dtpSeparacao.ShowCheckBox = true;
                    dtpSeparacao.Checked = false;
                }
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            schButton.Enabled = !enabled;
            bnCasais.Enabled = !enabled;
        }

        private void PreencherCombos()
        {
            //Espécie
            IEspecieRepos espRep = new EspecieRepos();
            dtEspecie = espRep.ListaEspecies();
            cbEspecie.DataSource = dtEspecie;
            cbEspecie.DisplayMember = "Nome";
            cbEspecie.ValueMember = "Id";

            //Gaiola
            IGaiolaRepos gaiRep = new GaiolaRepos();
            dtGaiola = gaiRep.ListaGaiolas();
            cbGaiola.DataSource = dtGaiola;
            cbGaiola.DisplayMember = "Descr";
            cbGaiola.ValueMember = "Id";
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            tpOper = TipoOperDB.Consulta;
            ObterRegistrosCasais();
            bsCasais_CurrentItemChanged(sender, e);
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
            txtIdCasal.Text = "0";
            cbEspecie.SelectedIndex = -1;
            dtpJuncao.Value = DateTime.Today;
            dtpSeparacao.Value = new DateTime(1753, 1, 1); 
            cbGaiola.SelectedIndex = -1;
            cbPai.SelectedIndex = -1;
            cbMae.SelectedIndex = -1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ICasalRepos casRep = new CasalRepos();
            Casal casal = new Casal();
            VerificacaoPreenchimento verif = new VerificacaoPreenchimento();
            if (cbEspecie.SelectedIndex >= 0)
                casal.IdEspecie = (int)cbEspecie.SelectedValue;
            else
                casal.IdEspecie = -1; 
            if (cbPai.SelectedIndex >= 0)
                casal.IdAveMacho = (int)cbPai.SelectedValue; 
            else
                casal.IdAveMacho = -1;
            if (cbMae.SelectedIndex >= 0)
                casal.IdAveFemea = (int)cbMae.SelectedValue;
            else
                casal.IdAveFemea = -1;
            if (cbGaiola.SelectedIndex >= 0)
                casal.IdGaiola = (int)cbGaiola.SelectedValue;
            else
                casal.IdGaiola = -1;
            casal.DataJuncao = dtpJuncao.Value;
            if (dtpSeparacao.ShowCheckBox)
                if (dtpSeparacao.Checked)
                    casal.DataSeparacao = dtpSeparacao.Value;
            if (!verif.VerificarCamposPreenchidos(casal))
            {
                MessageBox.Show(verif.ObterCamposVazios());
                return;
            }
            if (tpOper == TipoOperDB.Insert)
            {
                if (!casRep.IncluirRegistroCasal(casal))
                    return;
            }
            else
            {
                casal.IdCasal = Convert.ToInt32(txtIdCasal.Text);
                if (!casRep.AlterarRegistroCasal(casal))
                    return;
            }
            AjustarNumeroGaiolasAves();
            HabilitarCampos(false);
            tpOper = TipoOperDB.Consulta;
            ObterRegistrosCasais();
            bsCasais_CurrentItemChanged(sender, e);
        }

        private void AjustarNumeroGaiolasAves()
        {
            IAveRepos aveRep = new AveRepos();
            aveRep.AlterarGaiolaAve((int)cbPai.SelectedValue, (int)cbGaiola.SelectedValue);
            aveRep.AlterarGaiolaAve((int)cbMae.SelectedValue, (int)cbGaiola.SelectedValue);
        }

        private void bsCasais_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtCasal.Rows.Count > 0)
            {
                txtIdCasal.Text = drCasal[bsCasais.Position].Field<int>(0).ToString("00000");
                //cbEspecie.SelectedIndex = ObterIndiceEspecie(drCasal[bsCasais.Position].Field<int>(1).ToString());
                cbEspecie.SelectedValue = Convert.ToInt32(drCasal[bsCasais.Position].Field<int>(1).ToString());
                PreencherCombosMachoFemea();
                //cbPai.SelectedIndex = ObterIndicePaiMae(drCasal[bsCasais.Position].Field<int>(2).ToString(), 'P');
                cbPai.SelectedValue = Convert.ToInt32(drCasal[bsCasais.Position].Field<int>(2).ToString());
                //cbMae.SelectedIndex = ObterIndicePaiMae(drCasal[bsCasais.Position].Field<int>(3).ToString(), 'M');
                cbMae.SelectedValue = Convert.ToInt32(drCasal[bsCasais.Position].Field<int>(3).ToString());
                dtpJuncao.Value = Convert.ToDateTime(drCasal[bsCasais.Position].Field<DateTime>(4).ToString());
                if (drCasal[bsCasais.Position].Field<DateTime?>(5) != null)
                {
                    dtpSeparacao.Visible = true;
                    dtpSeparacao.Value = Convert.ToDateTime(drCasal[bsCasais.Position].Field<DateTime>(5).ToString());
                    dtpSeparacao.ShowCheckBox = false;
                }
                else
                {
                    dtpSeparacao.Visible = false;
                    dtpSeparacao.ShowCheckBox = true;
                    dtpSeparacao.Checked = false;
                }
                cbGaiola.SelectedValue = Convert.ToInt32(drCasal[bsCasais.Position].Field<int>(6).ToString());
                //grid com os filhos
                IAveRepos aveRep = new AveRepos();
                dtFilhos = aveRep.ListaFilhosCasal(Convert.ToInt32(txtIdCasal.Text));
                dgvFilhotes.DataSource = dtFilhos;
                filhosPage.Text = "Filhotes(" + dgvFilhotes.RowCount.ToString("00") + ")";
                ConfigurarGridFilhos();
                //grid com as posturas
                IPosturaRepos posRep = new PosturaRepos();
                dtPoturas = posRep.ListaPosturasCasal(Convert.ToInt32(txtIdCasal.Text));
                dgvPosturas.DataSource = dtPoturas;
                posturasPage.Text = "Posturas(" + dgvPosturas.RowCount.ToString("00") + ")";
                ConfigurarGridPosturas();
                PreencherTotaisPosturas();
            }
            else
                LimparCampos();
        }

        private void PreencherTotaisPosturas()
        {
            Int16 TotalOvos = 0;
            Int16 OvosGalados = 0;
            Int16 OvosBrancos = 0;
            Int16 FilhotesNascidos = 0;
            Int16 FilhotesCriados = 0;

            if (dgvPosturas.RowCount > 0)
            {
                // loop para totalizações
                foreach (DataGridViewRow row in dgvPosturas.Rows)
                {
                    TotalOvos += Convert.ToInt16(row.Cells["NumeroOvos"].Value);
                    OvosGalados += Convert.ToInt16(row.Cells["OvosGalados"].Value);
                    OvosBrancos += Convert.ToInt16(row.Cells["OvosBrancos"].Value);
                    FilhotesNascidos += Convert.ToInt16(row.Cells["FilhotesNascidos"].Value);
                    FilhotesCriados += Convert.ToInt16(row.Cells["FilhotesCriados"].Value);
                }
            }
            lblPosturas.Text = dgvPosturas.RowCount.ToString("000");
            lblOvos.Text = TotalOvos.ToString("000");
            lblGalados.Text = OvosGalados.ToString("000");
            lblBrancos.Text = OvosBrancos.ToString("000");
            lblNascidos.Text = FilhotesNascidos.ToString("000");
            lblCriados.Text = FilhotesCriados.ToString("000");
        }

        private Int32 ObterIdGaiola(Int32 numero)
        {
            Int32 codRet = -1;
            for (int i = 0; i < cbGaiola.Items.Count; i++)
            {
                var drGaiola = cbGaiola.Items[i] as DataRowView;
                if (Convert.ToInt32(drGaiola.Row["numgaiola"].ToString()) == numero)
                    codRet = Convert.ToInt32(drGaiola.Row["Id"].ToString());
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

        private void delButton_Click(object sender, EventArgs e)
        {
            ICasalRepos casRep = new CasalRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                casRep.ExcluirRegistroCasal(Convert.ToInt32(txtIdCasal.Text));
                ObterRegistrosCasais();
            }
        }

        private void PreencherCombosMachoFemea()
        {
            //Macho
            IAveRepos aveRep = new AveRepos();
            dtPai = aveRep.ListaAvesCombo((int)cbEspecie.SelectedValue, 'M');
            cbPai.DataSource = dtPai;
            cbPai.DisplayMember = "Descr";
            cbPai.ValueMember = "Id";
            cbPai.SelectedIndex = -1;

            //Fêmea
            dtMae = aveRep.ListaAvesCombo((int)cbEspecie.SelectedValue, 'F');
            cbMae.DataSource = dtMae;
            cbMae.DisplayMember = "Descr";
            cbMae.ValueMember = "Id";
            cbMae.SelectedIndex = -1;
        }

        private void cbEspecie_Leave(object sender, EventArgs e)
        {
            PreencherCombosMachoFemea();
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
            dgvFilhotes.Columns["NumGaiola"].Width = 60;
            dgvFilhotes.Columns["NumGaiola"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilhotes.Columns["NumGaiola"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFilhotes.Columns["NumGaiola"].DefaultCellStyle.Format = "000";
        }

        private void ConfigurarGridPosturas()
        {
            dgvPosturas.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvPosturas.RowHeadersWidth = 25;

            dgvPosturas.Columns["InicioPostura"].HeaderText = "Início Postura";
            dgvPosturas.Columns["InicioPostura"].Width = 80;
            dgvPosturas.Columns["InicioPostura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["InicioPostura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPosturas.Columns["FinalPostura"].HeaderText = "Final Postura";
            dgvPosturas.Columns["FinalPostura"].Width = 80;
            dgvPosturas.Columns["FinalPostura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["FinalPostura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPosturas.Columns["InicioNascimento"].HeaderText = "Início Nascimento";
            dgvPosturas.Columns["InicioNascimento"].Width = 80;
            dgvPosturas.Columns["InicioNascimento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["InicioNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPosturas.Columns["NumeroOvos"].HeaderText = "Total Ovos";
            dgvPosturas.Columns["NumeroOvos"].Width = 50;
            dgvPosturas.Columns["NumeroOvos"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["NumeroOvos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPosturas.Columns["OvosGalados"].HeaderText = "Ovos Galados";
            dgvPosturas.Columns["OvosGalados"].Width = 50;
            dgvPosturas.Columns["OvosGalados"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["OvosGalados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPosturas.Columns["OvosBrancos"].HeaderText = "Ovos Brancos";
            dgvPosturas.Columns["OvosBrancos"].Width = 50;
            dgvPosturas.Columns["OvosBrancos"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["OvosBrancos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPosturas.Columns["FilhotesNascidos"].HeaderText = "Filhotes Nascidos";
            dgvPosturas.Columns["FilhotesNascidos"].Width = 50;
            dgvPosturas.Columns["FilhotesNascidos"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["FilhotesNascidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPosturas.Columns["FilhotesCriados"].HeaderText = "Filhotes Criados";
            dgvPosturas.Columns["FilhotesCriados"].Width = 50;
            dgvPosturas.Columns["FilhotesCriados"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["FilhotesCriados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPosturas.Columns["IndicAtivo"].HeaderText = "Ativa";
            dgvPosturas.Columns["IndicAtivo"].Width = 50;
            dgvPosturas.Columns["IndicAtivo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPosturas.Columns["IndicAtivo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CasalForm_Load(object sender, EventArgs e)
        {
            ContadorFormCasal++;
        }

        private void CasalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormCasal--;
        }

        private void schButton_Click(object sender, EventArgs e)
        {
            Int32 indice = 0;
            Boolean achou = false;
            DialogResult drSearch;
            SearchGaiolaDlg searchDlg = new SearchGaiolaDlg();
            drSearch = searchDlg.ShowDialog();
            if (drSearch == DialogResult.OK)
            {
                dtCasal.PrimaryKey = new DataColumn[] { dtCasal.Columns["idgaiola"] };
                DataRow drRow = dtCasal.Rows.Find(ObterIdGaiola(SearchGaiolaDlg.argSearchGaiola.NumGaiola));
                foreach (DataRow row in drCasal)
                {
                    if (row.Equals(drRow))
                    {
                        bsCasais.Position = indice;
                        achou = true;
                    }
                    indice++;
                }
                if (!achou)
                    MessageBox.Show("Registro não encontrado!");
            }
        }
    }
}
