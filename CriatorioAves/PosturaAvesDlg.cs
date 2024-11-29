using CriatorioAves.Interface;
using CriatorioAves.Repositorio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class PosturaAvesDlg : Form
    {
        DataTable dtCriador;

        public PosturaAvesDlg()
        {
            InitializeComponent();
            PreencherCombos();
        }
        private void PreencherCombos()
        {
            //Criador
            ICriadorRepos criRep = new CriadorRepos();
            dtCriador = criRep.ListaCriadores();
            cbCriador.DataSource = dtCriador;
            cbCriador.DisplayMember = "Nome";
            cbCriador.ValueMember = "Id";
            cbCriador.SelectedIndex = -1;
        }
        private void confBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
