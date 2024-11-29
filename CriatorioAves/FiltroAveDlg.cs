using CriatorioAves.Arguments;
using CriatorioAves.Interface;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Repositorio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class FiltroAveDlg : Form
    {
        public static ArgFiltroAve filtroAve = new ArgFiltroAve();
        public static Boolean blnFiltroAtivo = false;
        DataTable dtEspecie;
        DataTable dtCriador;
        DataTable dtGaiola;

        public FiltroAveDlg()
        {
            InitializeComponent();
            PreencherCombos();
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

        private void confBtn_Click(object sender, EventArgs e)
        {
            filtroAve.FiltrarSexo = chkSexo.Checked;
            if (!filtroAve.FiltrarSexo)
                filtroAve.Sexo = 'T';

            filtroAve.FiltrarCriador = chkCriador.Checked;
            if (filtroAve.FiltrarCriador)
            {
                filtroAve.IdCriador = (int)cbCriador.SelectedValue;
                filtroAve.IndiceComboCriador = cbCriador.SelectedIndex;
            }
            else
            {
                filtroAve.IdCriador = 0;
                filtroAve.IndiceComboCriador = -1;
            }

            filtroAve.FiltrarEspecie = chkEspecie.Checked;
            if (filtroAve.FiltrarEspecie)
            {
                filtroAve.IdEspecie = (int)cbEspecie.SelectedValue;
                filtroAve.IndiceComboEspecie = cbEspecie.SelectedIndex;
            }
            else
            {
                filtroAve.IdEspecie = 0;
                filtroAve.IndiceComboEspecie = -1;
            }

            filtroAve.FiltrarGaiola = chkGaiola.Checked;
            if (filtroAve.FiltrarGaiola)
            {
                filtroAve.IdGaiola = (int)cbGaiola.SelectedValue;
                filtroAve.IndiceComboGaiola = cbGaiola.SelectedIndex;
            }
            else
            {
                filtroAve.IdGaiola = 0;
                filtroAve.IndiceComboGaiola = -1;
            }

            filtroAve.FiltrarStatus = chkStatus.Checked;
            if (filtroAve.FiltrarStatus)
            {
                filtroAve.StatusAve = (StatusAve)cbStatus.SelectedIndex;
                filtroAve.IndiceComboStatus = cbStatus.SelectedIndex;
            }
            else
            {
                filtroAve.StatusAve = 0;
                filtroAve.IndiceComboStatus = -1;
            }

            filtroAve.FiltrarAnoNasc = chkAnoNasc.Checked;
            if (filtroAve.FiltrarAnoNasc)
                filtroAve.AnoNasc = (int)nudAnoNasc.Value;
            else
                filtroAve.AnoNasc = 0;

            blnFiltroAtivo = true;
            Close();
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            filtroAve.FiltrarCriador = false;
            filtroAve.FiltrarEspecie = false;
            filtroAve.FiltrarGaiola = false;
            filtroAve.FiltrarSexo = false;
            filtroAve.FiltrarStatus = false;
            filtroAve.FiltrarAnoNasc = false;
            filtroAve.IndiceComboCriador = -1;
            filtroAve.IndiceComboEspecie = -1;
            filtroAve.IndiceComboGaiola = -1;
            filtroAve.IndiceComboStatus = -1;
            blnFiltroAtivo = false;
            Close();
        }

        private void chkEspecie_CheckedChanged(object sender, EventArgs e)
        {
            cbEspecie.Enabled = chkEspecie.Checked;
        }

        private void chkSexo_CheckedChanged(object sender, EventArgs e)
        {
            rbnDesconhecido.Enabled = chkSexo.Checked;
            rbnFemea.Enabled = chkSexo.Checked;
            rbnMacho.Enabled = chkSexo.Checked;
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.Enabled = chkStatus.Checked;
        }

        private void chkGaiola_CheckedChanged(object sender, EventArgs e)
        {
            cbGaiola.Enabled = chkGaiola.Checked;
        }

        private void chkCriador_CheckedChanged(object sender, EventArgs e)
        {
            cbCriador.Enabled = chkCriador.Checked;
        }

        private void CarregarFiltros()
        {
            chkEspecie.Checked = filtroAve.FiltrarEspecie;
            cbEspecie.SelectedIndex = filtroAve.IndiceComboEspecie;
            chkSexo.Checked = filtroAve.FiltrarSexo;
            if (filtroAve.Sexo == 'D')
                rbnDesconhecido.Checked = true;
            else if (filtroAve.Sexo == 'F')
                rbnFemea.Checked = true;
            else if (filtroAve.Sexo == 'M')
                rbnMacho.Checked = true;
            chkGaiola.Checked = filtroAve.FiltrarGaiola;
            cbGaiola.SelectedIndex = filtroAve.IndiceComboGaiola;
            chkStatus.Checked = filtroAve.FiltrarStatus;
            cbStatus.SelectedIndex = filtroAve.IndiceComboStatus;
            chkCriador.Checked = filtroAve.FiltrarCriador;
            cbCriador.SelectedIndex = filtroAve.IndiceComboCriador;
            chkAnoNasc.Checked = filtroAve.FiltrarAnoNasc;
            nudAnoNasc.Value = filtroAve.AnoNasc;
        }

        private void FiltroAveDlg_Load(object sender, EventArgs e)
        {
            CarregarFiltros();
        }

        private void rbnMacho_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMacho.Checked)
                filtroAve.Sexo = 'M';
        }

        private void rbnFemea_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFemea.Checked)
                filtroAve.Sexo = 'F';
        }

        private void rbnDesconhecido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnDesconhecido.Checked)
                filtroAve.Sexo = 'D';
        }

        private void chkAnoNasc_CheckedChanged(object sender, EventArgs e)
        {
            nudAnoNasc.Enabled = chkAnoNasc.Checked;
        }
    }
}
