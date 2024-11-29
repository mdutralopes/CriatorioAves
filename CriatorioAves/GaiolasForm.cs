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
    public partial class GaiolasForm : Form
    {
        DataTable dtGaiola;
        DataRow[] drGaiola;
        DataTable dtModelo;
        DataRow[] drModelo;
        TipoOperDB tpOper;
        DataTable dtAves;

        public static Int16 ContadorFormGaiolas = 0;

        public GaiolasForm()
        {
            InitializeComponent();
            PreencherComboModelos();
            ObterRegistrosGaiolas();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void PreencherComboModelos()
        {
            IModeloRepos modRep = new ModeloGaiolaRepos();
            dtModelo = modRep.ListaModelosGaiolas();
            cbModeloGaiola.DataSource = dtModelo;
            cbModeloGaiola.DisplayMember = "Descr";
            cbModeloGaiola.ValueMember = "Id";
        }

        private void ObterRegistrosGaiolas()
        {
            IGaiolaRepos gaiRep = new GaiolaRepos();
            dtGaiola = gaiRep.ListaGaiolasForm();
            drGaiola = dtGaiola.Select("Id > 0");
            bsGaiola.DataSource = dtGaiola;
        }

        private void GaiolasForm_Load(object sender, EventArgs e)
        {
            bsGaiola.DataSource = dtGaiola;
            ContadorFormGaiolas++;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            txtNumGaiola.Enabled = enabled;
            cbModeloGaiola.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            schButton.Enabled = !enabled;
            bnGaiola.Enabled = !enabled;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            ObterRegistrosGaiolas();
            bsGaiola_CurrentItemChanged(sender, e);
            HabilitarCampos(false);
            tpOper = TipoOperDB.Consulta;
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
            txtIdGaiola.Text = "";
            txtNumGaiola.Text = "0";
            cbModeloGaiola.SelectedIndex = -1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IGaiolaRepos gaiRep = new GaiolaRepos();
            Gaiola gaiola = new Gaiola();
            VerificacaoPreenchimento verif = new VerificacaoPreenchimento();
            gaiola.NumGaiola = Convert.ToInt32(txtNumGaiola.Text);
            if (cbModeloGaiola.SelectedIndex >= 0)
                gaiola.IdModeloGaiola = (int)cbModeloGaiola.SelectedValue;
            else
                gaiola.IdModeloGaiola = -1;
            if (!verif.VerificarCamposPreenchidos(gaiola))
            {
                MessageBox.Show(verif.ObterCamposVazios());
                return;
            }
            if (tpOper == TipoOperDB.Insert)
            {
                if (!gaiRep.IncluirRegistroGaiola(gaiola))
                    return;
            }
            else
            {
                gaiola.IdGaiola = Convert.ToInt32(txtIdGaiola.Text);
                if (!gaiRep.AlterarRegistroGaiola(gaiola))
                    return;
            }
            tpOper = TipoOperDB.Consulta;
            ObterRegistrosGaiolas();
            HabilitarCampos(false);
            bsGaiola_CurrentItemChanged(sender, e);
        }

        private void bsGaiola_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtGaiola.Rows.Count > 0)
            {
                txtIdGaiola.Text = drGaiola[bsGaiola.Position].Field<int>(0).ToString("00000");
                txtNumGaiola.Text = drGaiola[bsGaiola.Position].Field<int>(1).ToString();
                cbModeloGaiola.SelectedValue = Convert.ToInt32(drGaiola[bsGaiola.Position].Field<int>(2).ToString());
                // grid com as aves;
                IAveRepos aveRep = new AveRepos();
                dtAves = aveRep.ListaAvesPorGaiola(Convert.ToInt32(txtIdGaiola.Text));
                dgvAves.DataSource = dtAves;
                avesPage.Text = "Aves(" + dgvAves.RowCount.ToString("00") + ")";
                ConfigurarGridAves();
                // especificações da gaiola
                ObterRegistroModelo();
            }
            else
                LimparCampos();
        }

        private void ObterRegistroModelo()
        {
            IModeloRepos modeloRepos = new ModeloGaiolaRepos();
            ModeloGaiola modelo = new ModeloGaiola();
            dtModelo = modeloRepos.ObterRegistroModelo(Convert.ToInt32(cbModeloGaiola.SelectedValue));
            drModelo = dtModelo.Select("Id > 0");
            lblAltura.Text = drModelo[0].Field<int>(4).ToString();
            lblComp.Text = drModelo[0].Field<int>(5).ToString();
            lblLargura.Text = drModelo[0].Field<int>(6).ToString();
        }

        private void ConfigurarGridAves()
        {
            dgvAves.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvAves.RowHeadersWidth = 25;

            dgvAves.Columns["IdentAve"].HeaderText = "Identificação";
            dgvAves.Columns["IdentAve"].Width = 100;

            dgvAves.Columns["SexoAve"].HeaderText = "Sexo";
            dgvAves.Columns["SexoAve"].Width = 50;
            dgvAves.Columns["SexoAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAves.Columns["SexoAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAves.Columns["MutacaoAve"].HeaderText = "Cor/Mutação";
            dgvAves.Columns["MutacaoAve"].Width = 150;

            dgvAves.Columns["DtNascAve"].HeaderText = "Nascimento";
            dgvAves.Columns["DtNascAve"].Width = 100;
            dgvAves.Columns["DtNascAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAves.Columns["DtNascAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IGaiolaRepos gaiRep = new GaiolaRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                gaiRep.ExcluirRegistroGaiola(Convert.ToInt32(txtIdGaiola.Text));
                ObterRegistrosGaiolas();
            }
        }

        private void GaiolasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormGaiolas--;
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
                dtGaiola.PrimaryKey = new DataColumn[] { dtGaiola.Columns["numgaiola"] };
                DataRow drRow = dtGaiola.Rows.Find(SearchGaiolaDlg.argSearchGaiola.NumGaiola);
                foreach (DataRow row in drGaiola)
                {
                    if (row.Equals(drRow))
                    {
                        bsGaiola.Position = indice;
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
