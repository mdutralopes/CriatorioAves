using CriatorioAves.Arguments;
using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class ReservasForm : Form
    {
        public static Int16 ContadorFormReservas = 0;
        private List<ReservaAves> listaAves = new List<ReservaAves>();
        private List<ArgDescrAve> listaDescr = new List<ArgDescrAve>();

        DataTable dtReserva;
        DataRow[] drReserva;
        DataTable dtCliente;

        TipoOperDB tpOper;

        public ReservasForm()
        {
            InitializeComponent();
            PreencherComboClientes();
            ObterRegistrosReservas();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ObterRegistrosReservas()
        {
            IReservaRepos resRep = new ReservaRepos();
            dtReserva = resRep.ListaReservas();
            drReserva = dtReserva.Select("Id > 0");
            bsReservas.DataSource = dtReserva;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            mskValor.Enabled = enabled;
            cbCliente.Enabled = enabled;
            dtpDataReserva.Enabled = enabled;
            editAvesBtn.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
        }

        private void PreencherComboClientes()
        {
            IClienteRepos cliRep = new ClienteRepos();
            dtCliente = cliRep.ListaClientes();
            cbCliente.DataSource = dtCliente;
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1;
        }

        private void ReservasForm_Load(object sender, EventArgs e)
        {
            ContadorFormReservas++;
        }

        private void ReservasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormReservas--;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            tpOper = TipoOperDB.Consulta;
            ObterRegistrosReservas();
            bsReservas_CurrentItemChanged(sender, e);
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
            txtIdReserva.Text = "0";
            cbCliente.SelectedIndex = -1;
            dtpDataReserva.Value = DateTime.Today;
            mskValor.Text = "0";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IReservaRepos resRep = new ReservaRepos();
            Reserva reserva = new Reserva();
            reserva.IdCliente = (int)cbCliente.SelectedValue;
            reserva.DataReserva = dtpDataReserva.Value;
            reserva.ValorReserva = Convert.ToDouble(mskValor.Text);
            reserva.AvesReservas = listaAves;
            if (tpOper == TipoOperDB.Insert)
            {
                if (!resRep.IncluirRegistroReserva(reserva))
                    return;
            }
            else
            {
                reserva.IdReserva = Convert.ToInt32(txtIdReserva.Text);
                if (!resRep.AlterarRegistroReserva(reserva))
                    return;
            }
            tpOper = TipoOperDB.Consulta;
            HabilitarCampos(false);
            ObterRegistrosReservas();
            bsReservas_CurrentItemChanged(sender, e);
        }

        private void bsReservas_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtReserva.Rows.Count > 0)
            {
                txtIdReserva.Text = drReserva[bsReservas.Position].Field<int>(0).ToString("00000");
                cbCliente.SelectedValue = Convert.ToInt32(drReserva[bsReservas.Position].Field<int>(1).ToString());
                dtpDataReserva.Value = Convert.ToDateTime(drReserva[bsReservas.Position].Field<DateTime>(2).ToString());
                mskValor.Text = drReserva[bsReservas.Position].Field<double>(3).ToString("N2");
            }
            else
                LimparCampos();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IReservaRepos resRep = new ReservaRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                resRep.ExcluirRegistroReserva(Convert.ToInt32(txtIdReserva.Text));
                ObterRegistrosReservas();
            }
        }

        private void editAvesBtn_Click(object sender, EventArgs e)
        {
            ReservasAvesDlg reservaDlg = new ReservasAvesDlg();
            DialogResult drAves;
            reservaDlg.listaAves = listaAves;
            drAves = reservaDlg.ShowDialog();
            if (drAves == DialogResult.OK)
            {
                listaAves = reservaDlg.listaAves;
                PreencherGridAvesReserva();
                VerficarTotalReserva();
            }              
        }

        private void VerficarTotalReserva()
        {
            double valTotal = 0;

            foreach(ReservaAves res in listaAves)
            {
                valTotal += res.ValorAve;
            }
            mskValor.Text = valTotal.ToString("N2");
        }

        private void PreencherGridAvesReserva()
        {
            listaDescr.Clear();
            foreach (ReservaAves res in listaAves)
            {
                ArgDescrAve arg;
                IAveRepos aveRep = new AveRepos();
                arg = aveRep.ObterDescrAveReserva(res.IdAve);
                arg.ValorAve = res.ValorAve.ToString("N2");
                listaDescr.Add(arg);
            }
            dgvAvesReserva.DataSource = null;
            dgvAvesReserva.DataSource = listaDescr;
            ConfigurarGridAves();
        }

        private void ConfigurarGridAves()
        {
            dgvAvesReserva.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvAvesReserva.RowHeadersWidth = 25;

            dgvAvesReserva.Columns["DescrEspecie"].HeaderText = "Espécie";
            dgvAvesReserva.Columns["DescrEspecie"].Width = 130;

            dgvAvesReserva.Columns["DescrAve"].HeaderText = "Descrição";
            dgvAvesReserva.Columns["DescrAve"].Width = 200;

            dgvAvesReserva.Columns["SexoAve"].HeaderText = "Sexo";
            dgvAvesReserva.Columns["SexoAve"].Width = 90;
            dgvAvesReserva.Columns["SexoAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvesReserva.Columns["SexoAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAvesReserva.Columns["ValorAve"].HeaderText = "Valor";
            dgvAvesReserva.Columns["ValorAve"].Width = 80;
            dgvAvesReserva.Columns["ValorAve"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAvesReserva.Columns["ValorAve"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
