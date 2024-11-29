using CriatorioAves.Arguments;
using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class AveRepos : IAveRepos
    {
        public Boolean AlterarGaiolaAve(int idAve, int idGaiola)
        {
            Banco bdAve;
            
            String sqlUpdate = "update criatorio.ave " +
                               "set IdGaiola = " + idGaiola + 
                               " where idave = " + idAve;
            try
            {
                bdAve = new Banco();
                bdAve.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean AlterarRegistroAve(Ave ave)
        {
            Banco bdAve;
            String paiAve = ave.IdPaiAve.ToString();
            if (paiAve == "-1")
                paiAve = "null";
            String maeAve = ave.IdMaeAve.ToString();
            if (maeAve == "-1")
                maeAve = "null";
            String sqlUpdate = "update criatorio.ave " +
                               "set IdentAve = '" + ave.Identificacao + "', " +
                               "SexoAve = '" + ave.Sexo + "', " +
                               "IdEspecie = " + ave.IdEspecie + ", " +
                               "MutacaoAve = '" + ave.CorMutacao + "', " +
                               "NomeAve = '" + ave.NomeAve + "', " +
                               "DtNascAve = '" + ave.DataNascimento.ToString("yyyy-MM-dd") + "', " +
                               "StatusAve = " + (int)ave.Status + ", " +
                               "IdCriador = " + ave.IdCriador + ", " +
                               "DtCompraAve = '" + ave.DataCompra.ToString("yyyy-MM-dd") + "', " +
                               "ValorCompraAve = " + ave.Valor + ", " +
                               "IdGaiola = " + ave.IdGaiola + ", ";
           if (paiAve == "null")
                sqlUpdate += "IdPai = null, ";
            else
                sqlUpdate += "IdPai = " + paiAve + ", ";
            if (maeAve == "null")
                sqlUpdate += "IdMae = null, ";
            else
                sqlUpdate += "IdMae = " + maeAve + ", ";
            sqlUpdate += "ObsAve = '" + ave.Observacao + "' " +
                         "where idave = " + ave.IdAve;
            try
            {
                bdAve = new Banco();
                bdAve.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistroAve(Int32 idAve)
        {
            Banco bdAve;
            String sqlDelete = "delete from  criatorio.ave " +
                               "where idave = " + idAve;
            try
            {
                bdAve = new Banco();
                bdAve.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroAve(Ave ave)
        {
            Banco bdAve;
            String paiAve = ave.IdPaiAve.ToString();
            if (paiAve == "-1")
                paiAve = "null";
            String maeAve = ave.IdMaeAve.ToString();
            if (maeAve == "-1")
                maeAve = "null";
            String sqlInsert = "insert into criatorio.ave(IdentAve, SexoAve, IdEspecie, MutacaoAve, " +
                               "NomeAve, DtNascAve, StatusAve, IdCriador, DtCompraAve, ValorCompraAve, " +
                               "IdGaiola, IdPai, IdMae, ObsAve) " +
                               "values('" + ave.Identificacao + "', '" + ave.Sexo + "', " + ave.IdEspecie + ", '" +
                               ave.CorMutacao + "', '" + ave.NomeAve + "', '" + ave.DataNascimento.ToString("yyyy-MM-dd") + "', " + (int)ave.Status + ", " +
                               ave.IdCriador + ", '" + ave.DataCompra.ToString("yyyy-MM-dd") + "', " + ave.Valor + ", " + ave.IdGaiola + ", ";
            if (paiAve == "null")
                sqlInsert += " null, ";
            else
                sqlInsert +=  paiAve + ", ";
            if (maeAve == "null")
                sqlInsert += " null, '";
            else
                sqlInsert += maeAve + ", '";
            sqlInsert +=  ave.Observacao + "')";
            try
            {
                bdAve = new Banco();
                bdAve.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaAves(Char sexo = 'T', Int32 idEspecie = 0, StatusAve? statusAve = null, 
                                   Int32 idGaiola = 0, Int32 idCriador = 0, Int32 anoNasc = 0)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select IdAve, IdentAve, SexoAve, IdEspecie, MutacaoAve, " +
                               "NomeAve, DtNascAve, StatusAve, IdCriador, DtCompraAve, ValorCompraAve, " +
                               "IdGaiola, IdPai, IdMae, ObsAve " +
                               " from criatorio.ave where 1 = 1 ";
            // filtrando sexo das aves
            if (sexo != 'T')
                sqlLista += " and SexoAve = '" + sexo + "'";
            // filtrando espécie
            if (idEspecie > 0)
                sqlLista += " and IdEspecie = " + idEspecie;
            // filtrando status
            if (statusAve != null)
                sqlLista += " and StatusAve = " + (int)statusAve;
            // filtrando gaiola
            if (idGaiola > 0)
                sqlLista += " and IdGaiola = " + idGaiola;
            // filtrando criador
            if (idCriador > 0)
                sqlLista += " and IdCriador = " + idCriador;
            // filtrando ano de nascimento
            if (anoNasc > 0)
                sqlLista += " and year(DtNascAve) = " + anoNasc;
            // ordenação
            sqlLista += " order by IdentAve ";
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

        public DataTable ListaAvesCombo(Int32 idAve, Int32 idEspecie, Char sexo)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select concat(IdentAve, ' - ', MutacaoAve) Descr, " +                
                              "idave id from criatorio.ave " +
                              " where sexoave = '" + sexo + "' " +
                              " and idespecie = " + idEspecie + 
                              " and idave <> " + idAve +
                              " order by descr";
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

        public DataTable ListaAvesCombo(Int32 idEspecie, Char sexo)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select concat(IdentAve, ' - ', MutacaoAve) Descr, " +
                              "idave id from criatorio.ave " +
                              " where sexoave = '" + sexo + "' " +
                              " and idespecie = " + idEspecie +
                              " order by descr";
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

        public DataTable ListaAvesCombo(Int32 idEspecie)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select concat(IdentAve, ' - ', MutacaoAve, ' - (', SexoAve, ')' ) Descr, " +
                              "idave id from criatorio.ave " +
                              " where idespecie = " + idEspecie +
                              " order by descr";
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

        public DataTable ListaAvesCriador(int idCriador)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select esp.NomeEspecie, ave.IdentAve, ave.SexoAve, ave.MutacaoAve, " +
                              " ave.DtNascAve, gai.NumGaiola, ave.ValorCompraAve " +
                              " from criatorio.ave, criatorio.gaiola gai, criatorio.especie esp " +
                              " where ave.idgaiola = gai.idgaiola " +
                              " and ave.IdEspecie = esp.IdEspecie " + 
                              " and ave.idCriador = " + idCriador +
                              " order by esp.NomeEspecie, ave.IdentAve";
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

        public DataTable ListaAvesPorGaiola(Int32 idGaiola)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select IdentAve, SexoAve, MutacaoAve, DtNascAve " +
                               " from criatorio.ave " +
                               " where ave.idgaiola = " + idGaiola  +
                               " order by IdentAve";
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

        public DataTable ListaFilhos(Int32 idAve)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select IdentAve, SexoAve, MutacaoAve, DtNascAve, NumGaiola " +
                               " from criatorio.ave, criatorio.gaiola " +
                               " where ave.idgaiola = gaiola.idgaiola " +
                               " and (idPai = " + idAve +
                               " or idMae = " + idAve + ")" +
                               " order by IdentAve";
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

        public DataTable ListaFilhosCasal(Int32 idCasal)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select ave.IdentAve, ave.SexoAve, ave.MutacaoAve, ave.DtNascAve, gai.NumGaiola " +
                               " from criatorio.ave, criatorio.gaiola gai, criatorio.casal cas " +
                               " where ave.idgaiola = gai.idgaiola " +
                               " and (cas.idmacho = ave.idpai " +
                               " or cas.idfemea = ave.idmae) " +
                               " and cas.idcasal = " + idCasal +
                               " order by ave.IdentAve";
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

        public DataTable ListaFilhotesPostura(Int32 idPostura)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select ave.IdentAve, " +
                              "case ave.SexoAve when 'M' then 'Macho' when 'F' then 'Fêmea' when 'D' then 'Desconhecido' end SexoAve, " +
                              " ave.MutacaoAve, ave.DtNascAve, gai.NumGaiola " +
                              " from criatorio.ave, criatorio.gaiola gai, criatorio.posturafilhote pos " +
                              " where ave.idgaiola = gai.idgaiola " +
                              " and pos.idave = ave.idave " +
                              " and pos.idpostura = " + idPostura +
                              " order by ave.IdentAve";
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

        public String ObterDescrAve(Int32 idAve)
        {
            String retAve = "";
            DataTable dtAve;
            DataRow[] drAve;
            Banco bdAve;
            String sqlLista = "select concat(IdentAve, ' - ', MutacaoAve, ' - (', SexoAve, ')' ) Descr, idave id " +
                               " from criatorio.ave " +
                               " where ave.idave = " + idAve;
            try
            {
                bdAve = new Banco();
                dtAve = bdAve.RetDataTable(sqlLista);
                drAve = dtAve.Select("Id > 0");
                retAve = drAve[0].Field<string>(0).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return retAve;
        }

        public ArgDescrAve ObterDescrAveReserva(Int32 idAve)
        {
            ArgDescrAve retAve = new ArgDescrAve();
            DataTable dtAve;
            DataRow[] drAve;
            Banco bdAve;
            String sqlLista = "select concat(IdentAve, ' - ', MutacaoAve) DescrAve, idave id, " +
                              " case ave.sexoave " + 
                              " when 'M' then 'Macho' " +
                              " when 'F' then 'Fêmea' " +
                              " when 'D' then 'Desconhecido' end SexoAve, " + 
                              " esp.nomeespecie " +
                              " from criatorio.ave, criatorio.especie esp" +
                              " where ave.idespecie = esp.idespecie " +
                              " and ave.idave = " + idAve;
            try
            {
                bdAve = new Banco();
                dtAve = bdAve.RetDataTable(sqlLista);
                drAve = dtAve.Select("Id > 0");
                retAve.DescrEspecie = drAve[0].Field<string>(3).ToString();
                retAve.DescrAve = drAve[0].Field<string>(0).ToString();
                retAve.SexoAve = drAve[0].Field<string>(2).ToString();
                retAve.ValorAve = "0";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return retAve;
        }

        public Boolean MudarStatusAve(Int32 idAve, StatusAve status)
        {
            Banco bdAve;
            String sqlUpdate = "update criatorio.ave " +
                               "set StatusAve = " + (int)status +
                               " where idave = " + idAve;
            try
            {
                bdAve = new Banco();
                bdAve.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Parents ObterCelulaPedigree(int idAve)
        {
            Parents parRet = new Parents();
            AveRepos aveRep = new AveRepos();
            Int32 idPai = 0;
            Int32 idMae = 0;

            // dados da ave
            parRet.IdAve = idAve;
            parRet.DescrAve = aveRep.ObterDescrAve(idAve);

            // obter Ids do pai e mae
            ObterIdsPaisAve(idAve, ref idPai, ref idMae);
            parRet.IdPai = idPai;
            parRet.IdMae = idMae;

            // descrição pai e mãe
            if (idPai > 0)
                parRet.DescrPai = aveRep.ObterDescrAve(idPai);
            if (idMae > 0)
                parRet.DescrMae = aveRep.ObterDescrAve(idMae);

            return parRet;
        }

        public void ObterIdsPaisAve(Int32 idAve, ref Int32 idPai, ref Int32 idMae)
        {
            DataTable dtAve;
            DataRow[] drAve;
            Banco bdAve;
            String sqlLista = "select coalesce(idpai, 0) pai, coalesce(idmae, 0) mae, idave Id " +
                              " from criatorio.ave " +
                              " where ave.idave = " + idAve;
            try
            {
                bdAve = new Banco();
                dtAve = bdAve.RetDataTable(sqlLista);
                drAve = dtAve.Select("Id > 0");
                idPai = Convert.ToInt32(drAve[0].Field<int>(0).ToString());
                idMae = Convert.ToInt32(drAve[0].Field<int>(1).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public String DescrParAve(Int32 idAve, Char sexo)
        {
            CasalRepos repCasal = new CasalRepos();
            String descrAve = "";
            DataTable dtAve;
            DataRow[] drAve;
            Banco bdAve;
            Int32 idPar = repCasal.ObterIdPar(idAve, sexo);
            if (idPar <= 0)
                return "";
            String sqlLista = "select concat(IdentAve, ' - ', MutacaoAve) DescrAve, idave id, " +
                              " case ave.sexoave " +
                              " when 'M' then 'Macho' " +
                              " when 'F' then 'Fêmea' " +
                              " when 'D' then 'Desconhecido' end SexoAve " +
                              " from criatorio.ave where ave.idave = " + idPar;
            try
            {
                bdAve = new Banco();
                dtAve = bdAve.RetDataTable(sqlLista);
                drAve = dtAve.Select("Id > 0");
                descrAve = "Par: " + drAve[0].Field<string>(0).ToString() + " - " + drAve[0].Field<string>(2).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return descrAve;
            }
            return descrAve;
        }
    }
}
