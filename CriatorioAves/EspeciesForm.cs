using CriatorioAves.Arguments;
using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Repositorio;
using CriatorioAves.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CriatorioAves
{
    public partial class EspeciesForm : Form
    {
        Banco banco; 
        DataTable dtEspecie;
        DataRow[] drEspecie;
        TipoOperDB tpOper;

        public static Int64 ContadorFormEspecies = 0;

        public EspeciesForm()
        {
            InitializeComponent();
            banco = new Banco();
            ObterRegistrosEspecies();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ObterRegistrosEspecies()
        {  
            dtEspecie = banco.RetDataTable("select idEspecie Id, NomeEspecie Nome, NomeCientificoEspecie 'Nome Científico' from especie");
            drEspecie = dtEspecie.Select("Id > 0");
            bsEspecie.DataSource = dtEspecie;
        }

        private void EspeciesForm_Load(object sender, EventArgs e)
        {
            bsEspecie.DataSource = dtEspecie;
            ContadorFormEspecies++;
        }

        private void bsEspecie_CurrentChanged(object sender, EventArgs e)
        {
            if (dtEspecie.Rows.Count > 0)
            {
                txtId.Text = drEspecie[bsEspecie.Position].Field<int>(0).ToString("00000");
                txtNome.Text = drEspecie[bsEspecie.Position].Field<string>(1).ToString();
                txtNomeCientifico.Text = drEspecie[bsEspecie.Position].Field<string>(2).ToString();
            }
            else
                LimparCampos();
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

        private void okButton_Click(object sender, EventArgs e)
        {
            IEspecieRepos espRep = new EspecieRepos();
            VerificacaoPreenchimento verif = new VerificacaoPreenchimento();
            Especie especie = new Especie();
            especie.NomeEspecie = txtNome.Text;
            especie.NomeCientifico = txtNomeCientifico.Text;
            if (!verif.VerificarCamposPreenchidos(especie))
            {
                MessageBox.Show(verif.ObterCamposVazios());
                return;
            }
            if (tpOper == TipoOperDB.Insert)
            {
                if (!espRep.IncluirRegistroEspecie(especie))
                    return;
            }
            else
            {
                especie.IdEspecie = Convert.ToInt32(txtId.Text);
                if (!espRep.AlterarRegistroEspecie(especie))
                    return;
            }
            tpOper = TipoOperDB.Consulta;
            HabilitarCampos(false);
            ObterRegistrosEspecies();
            bsEspecie_CurrentChanged(sender, e);
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            ObterRegistrosEspecies();
            bsEspecie_CurrentChanged(sender, e);
            HabilitarCampos(false);
        }

        private void HabilitarCampos(Boolean enabled)
        {
            txtNome.Enabled = enabled;
            txtNomeCientifico.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            schButton.Enabled = !enabled;
            bnNavegador.Enabled = !enabled;
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtNomeCientifico.Text = "";
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IEspecieRepos espRep = new EspecieRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                espRep.ExcluirRegistroEspecie(Convert.ToInt32(txtId.Text));
                ObterRegistrosEspecies();
            }
        }

        private void EspeciesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormEspecies--;
        }

        private void schButton_Click(object sender, EventArgs e)
        {
            Int32 indice = 0;
            Boolean achou = false;
            DialogResult drSearch;
            SearchEspecieDlg searchDlg = new SearchEspecieDlg();
            drSearch = searchDlg.ShowDialog();
            if (drSearch == DialogResult.OK)
            {
                dtEspecie.PrimaryKey = new DataColumn[] { dtEspecie.Columns["Nome"] };
                DataRow drRow = dtEspecie.Rows.Find(SearchEspecieDlg.argSearchEspecie.NomeEspecie);
                foreach (DataRow row in drEspecie)
                {
                    if (row.Equals(drRow))
                    {
                        bsEspecie.Position = indice;
                        achou = true;
                    }
                    indice++;

                }
                if (!achou)
                    MessageBox.Show("Registro não encontrado!");
            }
        }
    }
}
