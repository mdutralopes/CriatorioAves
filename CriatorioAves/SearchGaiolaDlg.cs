using CriatorioAves.Arguments;
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
    public partial class SearchGaiolaDlg : Form
    {
        public static ArgSearchGaiola argSearchGaiola = new ArgSearchGaiola();
        public SearchGaiolaDlg()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            argSearchGaiola.NumGaiola = Convert.ToInt32(txtNumero.Text);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
