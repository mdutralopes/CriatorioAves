using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Repositorio;
using CriatorioAves.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class ClientesForm : Form
    {
        public static Int16 ContadorFormClientes = 0;

        Banco banco;
        DataTable dtCliente;
        DataRow[] drCliente;
        TipoOperDB tpOper;

        public ClientesForm()
        {
            InitializeComponent();
            banco = new Banco();
            ObterRegistrosClientes();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ObterRegistrosClientes()
        {
            dtCliente = banco.RetDataTable("select IdCliente, NomeCliente, EmailCliente, TelefoneCliente from cliente");
            drCliente = dtCliente.Select("IdCliente > 0");
            bsClientes.DataSource = dtCliente;
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            bsClientes.DataSource = dtCliente;
            ContadorFormClientes++;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            txtNome.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtTelefone.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            bnClientes.Enabled = !enabled;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            ObterRegistrosClientes();
            bsClientes_CurrentItemChanged(sender, e);
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
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IClienteRepos cliRep = new ClienteRepos();
            Cliente cliente = new Cliente();
            cliente.NomeCliente = txtNome.Text;
            cliente.EmailCliente = txtEmail.Text;
            cliente.TelefoneCliente = txtTelefone.Text;
            if (tpOper == TipoOperDB.Insert)
            {
                if (!cliRep.IncluirRegistroCliente(cliente))
                    return;
            }
            else
            {
                cliente.IdCliente = Convert.ToInt32(txtId.Text);
                if (!cliRep.AlterarRegistroCliente(cliente))
                    return;
            }
            HabilitarCampos(false);
            ObterRegistrosClientes();
            bsClientes_CurrentItemChanged(sender, e);
        }

        private void bsClientes_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtCliente.Rows.Count > 0)
            {
                txtId.Text = drCliente[bsClientes.Position].Field<int>(0).ToString("00000");
                txtNome.Text = drCliente[bsClientes.Position].Field<string>(1).ToString();
                txtEmail.Text = drCliente[bsClientes.Position].Field<string>(2).ToString();
                txtTelefone.Text = drCliente[bsClientes.Position].Field<string>(3).ToString();
            }
            else
                LimparCampos();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IClienteRepos cliRep = new ClienteRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                cliRep.ExcluirRegistroCliente(Convert.ToInt32(txtId.Text));
                ObterRegistrosClientes();
            }
        }

        private void ClientesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormClientes--;
        }
    }
}
