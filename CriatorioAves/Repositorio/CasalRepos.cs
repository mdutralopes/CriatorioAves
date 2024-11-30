using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class CasalRepos : ICasalRepos
    {
        public Boolean AlterarRegistroCasal(Casal casal)
        {
            Banco bdCasal = new Banco();
            String dtSepara;
            Acasalamento acasalamento = new Acasalamento();
            IAcasalamentoRepos repAcasala = new AcasalamentoRepos();

            if (casal.DataSeparacao.ToString("yyyy-MM-dd") == "0001-01-01")
                dtSepara = "null";
            else
                dtSepara = casal.DataSeparacao.ToString("yyyy-MM-dd");

            String sqlUpdate = "update criatorio.casal " +
                               "set IdEspecie = " + casal.IdEspecie + ", " +
                               "IdMacho = " + casal.IdAveMacho + ", " +
                               "IdFemea = " + casal.IdAveFemea + ", " +
                               "DtJuncao = '" + casal.DataJuncao.ToString("yyyy-MM-dd") + "', ";
            if (dtSepara == "null")
                sqlUpdate += "DtSepara = null " + ", ";
            else
                sqlUpdate += "DtSepara = '" + dtSepara + "', ";
            sqlUpdate += "IdGaiola = " + casal.IdGaiola +
                         " where IdCasal = " + casal.IdCasal;
            try
            {
                
                bdCasal.IniciaTransacao();
                bdCasal.ExecutarComandoSQL(sqlUpdate);
                // registro de acasalamento
                acasalamento.IdCasal = casal.IdCasal;
                acasalamento.DataJuncao = casal.DataJuncao;
                acasalamento.DataSepara = casal.DataSeparacao;
                acasalamento.IdGaiola = casal.IdGaiola;
                if (repAcasala.AlterarRegistroAcasalamento(acasalamento))
                    bdCasal.CommitaTransacao();
                else
                    bdCasal.RollBackTransacao();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                bdCasal.RollBackTransacao();
                return false;
            }
            return true;
        }

        public Int32 CasalExiste(int idAvePai, int idAveMae)
        {
            Int32 idCasal = 0;
            DataRow[] drCasal;
            DataTable dtCasal;
            Banco bdCasal;
            String sqlLista = "select coalesce(idcasal, 0) id from criatorio.casal " + 
                              " where idmacho = " + idAvePai + 
                              " and idfemea = " + idAveMae;
            try
            {
                bdCasal = new Banco();
                dtCasal = bdCasal.RetDataTable(sqlLista);
                drCasal = dtCasal.Select("Id > 0");
                if (drCasal.Length > 0)
                    idCasal = Convert.ToInt32(drCasal[0].Field<int>(0).ToString());
                else
                    return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            return idCasal;
        }

        public Boolean ExcluirRegistroCasal(int idCasal)
        {
            Banco bdCasal = new Banco();
            IAcasalamentoRepos repAcasala = new AcasalamentoRepos(); 
            String sqlDelete = "delete from  criatorio.casal " +
                               "where idcasal = " + idCasal;

            try
            {
                bdCasal.IniciaTransacao();
                // exclui registros de acasalamentos
                if (!repAcasala.ExcluirRegistrosAcasalamentos(idCasal))
                {
                    bdCasal.RollBackTransacao();
                    return false;
                }
                bdCasal.ExecutarComandoSQL(sqlDelete);
                bdCasal.CommitaTransacao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                bdCasal.RollBackTransacao();
                return false;
            }
            return true;
        }

        public bool IncluirRegistroCasal(Casal casal)
        {
            Banco bdCasal = new Banco();
            String dtSepara;
            Int32 idCasal;
            Acasalamento acasalamento = new Acasalamento();
            IAcasalamentoRepos repAcasala = new AcasalamentoRepos();

            if (casal.DataSeparacao.ToString("yyyy-MM-dd") == "1753-01-01")
                dtSepara = "null";
            else
                dtSepara = casal.DataSeparacao.ToString("yyyy-MM-dd");

            String sqlInsert = "insert into criatorio.casal(IdEspecie, IdMacho, IdFemea, DtJuncao, DtSepara, IdGaiola) " +
                               "values(" + casal.IdEspecie + ", " + casal.IdAveMacho + ", " +
                               casal.IdAveFemea + ", '" + casal.DataJuncao.ToString("yyyy-MM-dd") + "', ";
            if (dtSepara == "null")
                sqlInsert += " null " + ", ";
            else
                sqlInsert+= "'" + dtSepara + "', ";
            sqlInsert  += casal.IdGaiola + ")";
            try
            {
                bdCasal.IniciaTransacao();
                idCasal = CasalExiste(casal.IdAveMacho, casal.IdAveFemea);
                if (idCasal == 0)
                {
                    bdCasal.ExecutarComandoSQL(sqlInsert);
                    idCasal = ObterIdCasal();
                }
                // registro de acasalamento
                acasalamento.IdCasal = idCasal;
                acasalamento.DataJuncao = casal.DataJuncao;
                acasalamento.DataSepara = casal.DataSeparacao;
                acasalamento.IdGaiola = casal.IdGaiola;
                if (repAcasala.IncluirRegistroAcasalamento(acasalamento))
                    bdCasal.CommitaTransacao();
                else
                {
                    bdCasal.RollBackTransacao();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                bdCasal.RollBackTransacao();
                return false;
            }
            return true;
        }

        private Int32 ObterIdCasal()
        {
            Int32 idCasal = 0;
            DataRow[] drCasal;
            DataTable dtCasal;
            Banco bdCasal;
            String sqlLista = "select max(idcasal) id from criatorio.casal ";
            try
            {
                bdCasal = new Banco();
                dtCasal = bdCasal.RetDataTable(sqlLista);
                drCasal = dtCasal.Select("Id > 0");
                idCasal = Convert.ToInt32(drCasal[0].Field<int>(0).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            return idCasal;
        }

        public DataTable ListaCasais()
        {
            DataTable dtRet;
            Banco bdCasal;
            String sqlLista = "select IdCasal, IdEspecie, IdMacho, IdFemea, DtJuncao, DtSepara, IdGaiola from criatorio.casal order by IdCasal";
            try
            {
                bdCasal = new Banco();
                dtRet = bdCasal.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }

        public DataTable ListaCasaisCombo()
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select concat('(M)', avp.MutacaoAve, ' - ', '(F)',  avm.MutacaoAve, ' || Gaiola ' , gai.NumGaiola) Descr, " +
                              " cas.idcasal id, gai.NumGaiola " +
                              " from criatorio.ave avp, criatorio.ave avm, criatorio.casal cas, criatorio.gaiola gai" +
                              " where cas.idmacho = avp.idave " +
                              " and cas.idfemea = avm.idave " +
                              " and cas.idgaiola = gai.idgaiola " +
                              " order by gai.numgaiola";
            try
            {
                bdAve = new Banco();
                dtRet = bdAve.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }

        public DataTable ListaCasaisComboFiltro()
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select distinct concat('(M)', avp.MutacaoAve, ' - ', '(F)',  avm.MutacaoAve, ' || Gaiola ' , gai.NumGaiola) Descr, " +
                              " cas.idcasal id, gai.NumGaiola " +
                              " from criatorio.ave avp, criatorio.ave avm, criatorio.casal cas, " + 
                              " criatorio.gaiola gai, criatorio.postura pos" +
                              " where cas.idmacho = avp.idave " +
                              " and cas.idfemea = avm.idave " +
                              " and cas.idgaiola = gai.idgaiola " +
                              " and cas.idcasal = pos.idcasal " +
                              " order by gai.numgaiola";
            try
            {
                bdAve = new Banco();
                dtRet = bdAve.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }

        public Int32 ObterIdPar(Int32 idAve, Char sexo)
        {
            Int32 idPar = 0;
            DataRow[] drCasal;
            DataTable dtCasal;
            Banco bdCasal;
            String sqlLista = "";

            if (sexo == 'D')
                return 0;

            if (sexo == 'M')
            {
                sqlLista = "select idfemea id from criatorio.casal where idmacho =  " + idAve +
                           " and dtsepara is null";
            }
            else
            {
                sqlLista = "select idmacho id from criatorio.casal where idfemea =  " + idAve +
                           " and dtsepara is null";
            }

            try
            {
                bdCasal = new Banco();
                dtCasal = bdCasal.RetDataTable(sqlLista);
                drCasal = dtCasal.Select("Id > 0");
                if (drCasal.Length > 0)
                    idPar = Convert.ToInt32(drCasal[0].Field<int>(0).ToString());
                else
                    idPar = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            return idPar;
        }
    }
}
