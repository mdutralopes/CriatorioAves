using CriatorioAves.Arguments;
using System;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class SearchEspecieDlg : Form
    {
        public static ArgSearchEspecie argSearchEspecie = new ArgSearchEspecie();

        public SearchEspecieDlg()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            argSearchEspecie.NomeEspecie = txtNome.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
