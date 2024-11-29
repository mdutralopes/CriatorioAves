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
    public partial class ModeloGaiolaForm : Form
    {
        public static Int16 ContadorFormModelos = 0;

        DataTable dtModelo;
        DataRow[] drModelo;
        TipoOperDB tpOper;

        public ModeloGaiolaForm()
        {
            InitializeComponent();
            ObterRegistrosModelosGaiolas();
            this.Text += " - " + Criatorio.criatorio.NomeCriatorio;
        }

        private void ObterRegistrosModelosGaiolas()
        {
            IModeloRepos modRep = new ModeloGaiolaRepos();
            dtModelo = modRep.ListaCompletaModelosGaiolas();
            drModelo = dtModelo.Select("Id > 0");
            bsModeloGaiola.DataSource = dtModelo;
        }

        private void ModeloGaiolaForm_Load(object sender, EventArgs e)
        {
            ContadorFormModelos++;
        }

        private void ModeloGaiolaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContadorFormModelos--;
        }

        private void HabilitarCampos(Boolean enabled)
        {
            cbMaterial.Enabled = enabled;
            cbTipo.Enabled = enabled;
            txtFabricante.Enabled = enabled;
            txtObs.Enabled = enabled;
            nudAltura.Enabled = enabled;
            nudComprimento.Enabled = enabled;
            nudLargura.Enabled = enabled;
            okButton.Enabled = enabled;
            canButton.Enabled = enabled;
            delButton.Enabled = !enabled;
            altButton.Enabled = !enabled;
            incButton.Enabled = !enabled;
            bnModeloGaiola.Enabled = !enabled;
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            ObterRegistrosModelosGaiolas();
            bsModeloGaiola_CurrentItemChanged(sender, e);
            HabilitarCampos(false);
            tpOper = TipoOperDB.Consulta;
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
            txtIdModelo.Text = "0";
            cbMaterial.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            txtFabricante.Text = "";
            txtObs.Text = "";
            nudAltura.Value = 0;
            nudComprimento.Value = 0;
            nudLargura.Value = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IModeloRepos modRep = new ModeloGaiolaRepos();
            ModeloGaiola modelo = new ModeloGaiola();
            VerificacaoPreenchimento verif = new VerificacaoPreenchimento();
            modelo.Material = (MaterialGaiola)cbMaterial.SelectedIndex;
            modelo.Tipo = (TipoGaiola)cbTipo.SelectedIndex;
            modelo.FabricanteGaiola = txtFabricante.Text;
            modelo.AlturaGaiola = Convert.ToInt16(nudAltura.Value);
            modelo.CompGaiola = Convert.ToInt16(nudComprimento.Value);
            modelo.LarguraGaiola = Convert.ToInt16(nudLargura.Value);
            modelo.ObsModelo = txtObs.Text;
            if (!verif.VerificarCamposPreenchidos(modelo))
            {
                MessageBox.Show(verif.ObterCamposVazios());
                return;
            }
            if (tpOper == TipoOperDB.Insert)
            {
                if (!modRep.IncluirRegistroModelo(modelo))
                    return;
            }
            else
            {
                modelo.IdModeloGaiola = Convert.ToInt32(txtIdModelo.Text);
                if (!modRep.AlterarRegistroModelo(modelo))
                    return;
            }
            tpOper = TipoOperDB.Consulta;
            HabilitarCampos(false);
            ObterRegistrosModelosGaiolas();
            bsModeloGaiola_CurrentItemChanged(sender, e);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            IModeloRepos modRep = new ModeloGaiolaRepos();
            DialogResult drExcluir = MessageBox.Show("Confirma exclusão?", "Exclusão", MessageBoxButtons.YesNoCancel);
            if (drExcluir == DialogResult.Yes)
            {
                modRep.ExcluirRegistroModelo(Convert.ToInt32(txtIdModelo.Text));
                ObterRegistrosModelosGaiolas();
            }
        }

        private void bsModeloGaiola_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dtModelo.Rows.Count > 0)
            {
                txtIdModelo.Text = drModelo[bsModeloGaiola.Position].Field<int>(0).ToString("00000");
                cbMaterial.SelectedIndex = Convert.ToInt32(drModelo[bsModeloGaiola.Position].Field<int>(1).ToString());
                cbTipo.SelectedIndex = Convert.ToInt32(drModelo[bsModeloGaiola.Position].Field<int>(2).ToString());
                txtFabricante.Text = drModelo[bsModeloGaiola.Position].Field<string>(3).ToString();
                nudAltura.Value = Convert.ToInt32(drModelo[bsModeloGaiola.Position].Field<int>(4).ToString());
                nudComprimento.Value = Convert.ToInt32(drModelo[bsModeloGaiola.Position].Field<int>(5).ToString());
                nudLargura.Value = Convert.ToInt32(drModelo[bsModeloGaiola.Position].Field<int>(6).ToString());
                txtObs.Text = drModelo[bsModeloGaiola.Position].Field<string>(7).ToString();
            }
            else
                LimparCampos();
        }
    }
}
