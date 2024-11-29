using CriatorioAves.Arguments;
using CriatorioAves.Interface;
using CriatorioAves.Repositorio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class FiltroPosturaDlg : Form
    {
        public static ArgFiltroPostura filtroPostura = new ArgFiltroPostura();
        public static Boolean blnFiltroAtivo = false;
        DataTable dtCasal;

        public FiltroPosturaDlg()
        {
            InitializeComponent();
            PreencherComboCasais();
        }

        private void CarregarFiltros()
        {
            if (filtroPostura.FiltrarAtivo)
                chkFiltrarAtivos.Checked = true;
            else
                chkFiltrarAtivos.Checked = false;

            if (filtroPostura.ValorFiltroAtivo)
                chkAtivo.Checked = true;
            else
                chkAtivo.Checked = false;

            if (filtroPostura.FiltrarCasal)
                chkFiltrarCasal.Checked = true;
            else
                chkFiltrarCasal.Checked = false;

            cbCasal.SelectedIndex = filtroPostura.IndiceComboCasal;
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            filtroPostura.FiltrarAtivo = chkFiltrarAtivos.Checked;
            filtroPostura.FiltrarCasal = chkFiltrarCasal.Checked;
            filtroPostura.ValorFiltroAtivo = chkAtivo.Checked;
            if (filtroPostura.FiltrarCasal)
            {
                filtroPostura.IdCasalFiltro = (int)cbCasal.SelectedValue;
                filtroPostura.IndiceComboCasal = cbCasal.SelectedIndex;
            }
            blnFiltroAtivo = true;
            Close();
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            filtroPostura.FiltrarAtivo = false;
            filtroPostura.FiltrarCasal = false;
            filtroPostura.ValorFiltroAtivo = false;
            filtroPostura.IdCasalFiltro = 0;
            filtroPostura.IndiceComboCasal = -1;
            cbCasal.SelectedIndex = -1;
            blnFiltroAtivo = false;
            Close();
        }

        private void PreencherComboCasais()
        {
            ICasalRepos casRep = new CasalRepos();
            dtCasal = casRep.ListaCasaisComboFiltro();
            cbCasal.DataSource = dtCasal;
            cbCasal.DisplayMember = "Descr";
            cbCasal.ValueMember = "Id";
            cbCasal.SelectedIndex = -1;
        }

        private void FiltroPosturaDlg_Load(object sender, EventArgs e)
        {
            CarregarFiltros();
        }

        private void chkFiltrarAtivos_CheckedChanged(object sender, EventArgs e)
        {
            chkAtivo.Enabled = chkFiltrarAtivos.Checked;
        }

        private void chkFiltrarCasal_CheckedChanged(object sender, EventArgs e)
        {
            cbCasal.Enabled = chkFiltrarCasal.Checked;
        }
    }
}
