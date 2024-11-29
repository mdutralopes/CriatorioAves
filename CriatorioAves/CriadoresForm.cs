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
    public partial class CriadoresForm : Form
    {
        Banco banco;
        DataTable dtCriador;
        DataRow[] drCriador;
        DataTable dtAves;
        TipoOperDB tpOper;

        public static Int16 ContadorFormCriadores = 0;

        public CriadoresForm()
        {
            InitializeComponent();
            banco = new Banco();
            ObterRegistrosCriadores();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void CriadoresForm_Load(object sender, EventArgs e)
        {
            bsCriador.DataSource = dtCriador;
            ContadorFormCriadores++;
        }

        private void ObterRegistrosCriadores()
        {
            dtCriador = banco.RetDataTable("select IdCriador, NomeCriador, RegistroCriador, EmailCriador, TelefoneCriador from criador");
            drCriador = dtCriador.Select("IdCriador > 0");
            bsCriador.DataSource = dtCriador;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            txtNome.Enabled = enabled;
            txtRegistro.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtTelefone.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            bnCriador.Enabled = !enabled;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            ObterRegistrosCriadores();
            bsCriador_CurrentItemChanged(sender, e);
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
            txtId.Text = "";
            txtNome.Text = "";
            txtRegistro.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ICriadorRepos cliRep = new CriadorRepos();
            Criador criador = new Criador();
            VerificacaoPreenchimento verif = new VerificacaoPreenchimento();
            criador.NomeCriador = txtNome.Text;
            criador.RegistroCriador = txtRegistro.Text;
            criador.EmailCriador = txtEmail.Text;
            criador.TelefoneCriador = txtTelefone.Text;
            if (!verif.VerificarCamposPreenchidos(criador))
            {
                MessageBox.Show(verif.ObterCamposVazios());
                return;
            }
            if (tpOper == TipoOperDB.Insert)
            {
                if (!cliRep.IncluirRegistroCriador(criador))
                    return;
            }
            else
            {
                criador.IdCriador = Convert.ToInt32(txtId.Text);
                if (!cliRep.AlterarRegistroCriador(criador))
                    return;
            }
            HabilitarCampos(false);
            ObterRegistrosCriadores();
            bsCriador_CurrentItemChanged(sender, e);
        }

        private void bsCriador_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtCriador.Rows.Count > 0)
            {
                txtId.Text = drCriador[bsCriador.Position].Field<int>(0).ToString("00000");
                txtNome.Text = drCriador[bsCriador.Position].Field<string>(1).ToString();
                txtRegistro.Text = drCriador[bsCriador.Position].Field<string>(2).ToString();
                txtEmail.Text = drCriador[bsCriador.Position].Field<string>(3).ToString();
                txtTelefone.Text = drCriador[bsCriador.Position].Field<string>(4).ToString();
                //grid com as aves
                IAveRepos aveRep = new AveRepos();
                dtAves = aveRep.ListaAvesCriador(Convert.ToInt32(txtId.Text));
                dgvAvesCriador.DataSource = dtAves;
                avesPage.Text = "Aves(" + dgvAvesCriador.RowCount.ToString("000") + ")";
                ConfigurarGridAves();
            }
            else
                LimparCampos();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            ICriadorRepos criRep = new CriadorRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                criRep.ExcluirRegistroCriador(Convert.ToInt32(txtId.Text));
                ObterRegistrosCriadores();
            }
        }

        private void CriadoresForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormCriadores--;
        }

        private void ConfigurarGridAves()
        {
            dgvAvesCriador.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvAvesCriador.RowHeadersWidth = 25;

            dgvAvesCriador.Columns["NomeEspecie"].HeaderText = "Espécie";
            dgvAvesCriador.Columns["NomeEspecie"].Width = 130;

            dgvAvesCriador.Columns["IdentAve"].HeaderText = "Identificação";
            dgvAvesCriador.Columns["IdentAve"].Width = 100;

            dgvAvesCriador.Columns["SexoAve"].HeaderText = "Sexo";
            dgvAvesCriador.Columns["SexoAve"].Width = 40;
            dgvAvesCriador.Columns["SexoAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvesCriador.Columns["SexoAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAvesCriador.Columns["MutacaoAve"].HeaderText = "Cor/Mutação";
            dgvAvesCriador.Columns["MutacaoAve"].Width = 130;

            dgvAvesCriador.Columns["DtNascAve"].HeaderText = "Nascimento";
            dgvAvesCriador.Columns["DtNascAve"].Width = 80;
            dgvAvesCriador.Columns["DtNascAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvesCriador.Columns["DtNascAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAvesCriador.Columns["NumGaiola"].HeaderText = "Gaiola";
            dgvAvesCriador.Columns["NumGaiola"].Width = 50;
            dgvAvesCriador.Columns["NumGaiola"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvesCriador.Columns["NumGaiola"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAvesCriador.Columns["NumGaiola"].DefaultCellStyle.Format = "000";


            dgvAvesCriador.Columns["ValorCompraAve"].HeaderText = "Valor";
            dgvAvesCriador.Columns["ValorCompraAve"].Width = 80;
            dgvAvesCriador.Columns["ValorCompraAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvesCriador.Columns["ValorCompraAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAvesCriador.Columns["ValorCompraAve"].DefaultCellStyle.Format = "N2";
        }


    }
}
