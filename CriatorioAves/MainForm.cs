using CriatorioAves.Modelo;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MontarCabecalhoCriatorio();
        }

        private void MontarCabecalhoCriatorio()
        {
            Banco banco = new Banco();
            DataTable dtCriatorio = banco.RetDataTable("select NomeCriatorio Nome, RespCriatorio Resp, RegistroCriatorio Registro, TelCriatorio Telefone from criatorio"); ;
            DataRow[] drCriatorio = dtCriatorio.Select("Nome > ''");
            this.Text += " - " + drCriatorio[0].Field<string>(0).ToString() +
                         " - " + drCriatorio[0].Field<string>(1).ToString() +
                         " - " + drCriatorio[0].Field<string>(2).ToString();
            Criatorio.criatorio = new Criatorio();
            Criatorio.criatorio.NomeCriatorio = drCriatorio[0].Field<string>(0).ToString();
            Criatorio.criatorio.RegistroCriatorio = drCriatorio[0].Field<string>(2).ToString();
            Criatorio.criatorio.RespCriatorio = drCriatorio[0].Field<string>(1).ToString();
            Criatorio.criatorio.TelCriatorio = drCriatorio[0].Field<string>(3).ToString();
        }

        private void especiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EspeciesForm.ContadorFormEspecies == 0)
            {
                EspeciesForm especiesForm = new EspeciesForm();
                especiesForm.MdiParent = this;
                especiesForm.Show();
            }
        }

        private void gaiolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GaiolasForm.ContadorFormGaiolas == 0)
            {
                GaiolasForm gaiolasForm = new GaiolasForm();
                gaiolasForm.MdiParent = this;
                gaiolasForm.Show();
            }
        }

        private void avesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AvesForm.ContadorFormAves == 0)
            {
                AvesForm avesForm;  avesForm = new AvesForm();
                avesForm.MdiParent = this;
                avesForm.Show();
            }
        }

        private void criadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CriadoresForm.ContadorFormCriadores == 0)
            {
                CriadoresForm criadoresForm = new CriadoresForm();
                criadoresForm.MdiParent = this;
                criadoresForm.Show();
            }
        }

        private void casaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CasalForm.ContadorFormCasal == 0)
            {
                CasalForm casalForm = new CasalForm();
                casalForm.MdiParent = this;
                casalForm.Show();
            }
        }

        private void posturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PosturaForm.ContadorFormPosturas == 0)
            {
                PosturaForm posturaForm = new PosturaForm();
                posturaForm.MdiParent = this;
                posturaForm.Show();
            }
        }

        private void modelosDeGaiolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ModeloGaiolaForm.ContadorFormModelos == 0)
            {
                ModeloGaiolaForm modeloForm = new ModeloGaiolaForm();
                modeloForm.MdiParent = this;
                modeloForm.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientesForm.ContadorFormClientes == 0)
            {
                ClientesForm clienteForm = new ClientesForm();
                clienteForm.MdiParent = this;
                clienteForm.Show();
            }
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReservasForm.ContadorFormReservas == 0)
            {
                ReservasForm reservaForm = new ReservasForm();
                reservaForm.MdiParent = this;
                reservaForm.Show();
            }
        }
    }
}
