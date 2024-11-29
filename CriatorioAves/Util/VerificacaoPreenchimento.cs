using CriatorioAves.Arguments;
using CriatorioAves.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CriatorioAves.Util
{
    public class VerificacaoPreenchimento
    {
        private List<ArgCampoVazio> listaVazios = new List<ArgCampoVazio>();

        public String ObterCamposVazios()
        {
            StringBuilder sbMensagem = new StringBuilder();
            sbMensagem.AppendLine("Lista de campos não preenchidos");
            sbMensagem.AppendLine("===============================");

            foreach (ArgCampoVazio cmp in listaVazios)
            {
                sbMensagem.AppendLine(cmp.NumCampo.ToString("00") + " - " + cmp.NomeCampo);
            }

            sbMensagem.AppendLine();
            sbMensagem.AppendLine("Preencha os campos citados acima.");

            return sbMensagem.ToString();
        }

        public Boolean VerificarCamposPreenchidos(Especie especie)
        {
            Int16 contaCampo = 0;
            Boolean blnRet = true;
            listaVazios.Clear();

            if (especie.NomeEspecie == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Nome Espécie*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (especie.NomeCientifico == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Nome Científico*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }
            return blnRet;
        }

        public Boolean VerificarCamposPreenchidos(ModeloGaiola modelo)
        {
            Int16 contaCampo = 0;
            Boolean blnRet = true;
            listaVazios.Clear();

            if ((int)modelo.Material == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Material*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if ((int)modelo.Tipo == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Tipo*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (modelo.FabricanteGaiola == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Fabricante*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (modelo.AlturaGaiola == 0)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Altura*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (modelo.LarguraGaiola == 0)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Largura*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (modelo.CompGaiola == 0)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Comprimento*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }
            return blnRet;
        }

        public Boolean VerificarCamposPreenchidos(Gaiola gaiola)
        {
            Int16 contaCampo = 0;
            Boolean blnRet = true;
            listaVazios.Clear();

            if (gaiola.NumGaiola == 0)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Número Gaiola*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (gaiola.IdModeloGaiola == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Modelo Gaiola*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }
            return blnRet;
        }

        public Boolean VerificarCamposPreenchidos(Criador criador)
        {
            Int16 contaCampo = 0;
            Boolean blnRet = true;
            listaVazios.Clear();

            if (criador.NomeCriador == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Nome*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (criador.EmailCriador == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "E-mail*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (criador.TelefoneCriador == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Telefone*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            return blnRet;
        }

        public Boolean VerificarCamposPreenchidos(Casal casal)
        {
            Int16 contaCampo = 0;
            Boolean blnRet = true;
            listaVazios.Clear();

            if (casal.IdEspecie == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Espécie*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (casal.IdAveMacho == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Macho*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (casal.IdAveFemea == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Fêmea*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (casal.IdGaiola == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Gaiola*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }
            return blnRet;
        }

        public Boolean VerificarCamposPreenchidos(Ave ave)
        {
            Int16 contaCampo = 0;
            Boolean blnRet = true;
            listaVazios.Clear();

            if (ave.Identificacao == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Identificação*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (ave.IdEspecie == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Espécie*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (ave.CorMutacao == "")
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Cor/Mutação*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if ((int)ave.Status == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Status*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (ave.IdCriador == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Criador*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }

            if (ave.IdGaiola == -1)
            {
                ArgCampoVazio campoVazio = new ArgCampoVazio();
                contaCampo++;
                campoVazio.NumCampo = contaCampo;
                campoVazio.NomeCampo = "Gaiola*";
                listaVazios.Add(campoVazio);
                blnRet = false;
            }
            return blnRet;
        }

    }
}
