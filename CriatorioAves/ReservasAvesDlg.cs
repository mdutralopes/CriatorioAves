using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class ReservasAvesDlg : Form
    {
        DataTable dtEspecie;
        DataTable dtAve;
        public List<ReservaAves> listaAves = new List<ReservaAves>();
        public ReservaAves resAves;
        public Int32 idReserva;

        public ReservasAvesDlg()
        {
            InitializeComponent();
            PreencherComboEspecie();
        }

        private void PreencherComboEspecie()
        {
            //Espécie
            IEspecieRepos espRep = new EspecieRepos();
            dtEspecie = espRep.ListaEspecies();
            cbEspecie.DataSource = dtEspecie;
            cbEspecie.DisplayMember = "Nome";
            cbEspecie.ValueMember = "Id";
            cbEspecie.SelectedIndex = -1;
        }

        public void PreencherComboAves(Int32 idEspecie)
        {
            IAveRepos aveRep = new AveRepos();
            dtAve = aveRep.ListaAvesCombo(Convert.ToInt32((int)cbEspecie.SelectedValue));
            cbAve.DataSource = dtAve;
            cbAve.DisplayMember = "Descr";
            cbAve.ValueMember = "Id";
            cbAve.SelectedIndex = -1;
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbEspecie_Leave(object sender, EventArgs e)
        {
            cbAve.Enabled = (cbEspecie.SelectedIndex > -1);
            if (cbAve.Enabled)
                PreencherComboAves((int)cbEspecie.SelectedValue);
        }

        private void incListaBtn_Click(object sender, EventArgs e)
        {
            IAveRepos aveRep = new AveRepos();
            resAves = new ReservaAves();
            resAves.IdReserva = idReserva;
            resAves.IdAve = (int)cbAve.SelectedValue;
            resAves.ValorAve = Convert.ToDouble(mskValor.Text);
            listaAves.Add(resAves);
            lbAves.Items.Add(aveRep.ObterDescrAve(resAves.IdAve) + " - " + mskValor.Text);
        }

        private void excListaBtn_Click(object sender, EventArgs e)
        {
            Int32 indexLista = lbAves.SelectedIndex;
            lbAves.Items.RemoveAt(indexLista);
            listaAves.RemoveAt(indexLista);
        }

        private void ReservasAvesDlg_Load(object sender, EventArgs e)
        {
            IAveRepos aveRep = new AveRepos();
            lbAves.Items.Clear();
            foreach (ReservaAves res in listaAves)
            {
                lbAves.Items.Add(aveRep.ObterDescrAve(res.IdAve) + " - " + res.ValorAve);
            }
        }
    }
}
