using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class PosturaRepos : IPosturaRepos
    {
        public Boolean AlterarRegistroPostura(Postura postura)
        {
            Banco bdPostura;
            String dtFinalPostura;
            String dtInicioNascimento;

            if (postura.FinalPostura.ToString("yyyy-MM-dd") == "0001-01-01")
                dtFinalPostura = "null";
            else
                dtFinalPostura = postura.FinalPostura.ToString("yyyy-MM-dd");
            if (postura.InicioNascimento.ToString("yyyy-MM-dd") == "0001-01-01")
                dtInicioNascimento = "null";
            else
                dtInicioNascimento = postura.InicioNascimento.ToString("yyyy-MM-dd");

            String sqlUpdate = "update criatorio.postura " +
                               "set IdCasal = " + postura.IdCasal + ", " +
                               "InicioPostura = '" + postura.InicioPostura.ToString("yyyy-MM-dd") + "', ";
            if (dtFinalPostura == "null")
                sqlUpdate += "FinalPostura = null " + ", ";
            else
                sqlUpdate += "FinalPostura = '" + dtFinalPostura + "', ";
            if (dtInicioNascimento == "null")
                sqlUpdate += "InicioNascimento = null " + ", ";
            else
                sqlUpdate += "InicioNascimento = '" + dtInicioNascimento + "', ";
            sqlUpdate += "NumeroOvos = " + postura.NumeroOvos + ", " +
                         "OvosGalados = " + postura.OvosGalados + ", " +
                         "OvosBrancos = " + postura.OvosBrancos + ", " +
                         "FilhotesNascidos = " + postura.FilhotesNascidos + ", " +
                         "FilhotesCriados = " + postura.FilhotesCriados + ", " +
                         "IndicAtivo = '" + postura.IndicAtivo + "' " +
                         " where IdPostura = " + postura.IdPostura;
            try
            {
                bdPostura = new Banco();
                bdPostura.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistroPostura(int idPostura)
        {
            Banco bdPostura;
            String sqlDelete = "delete from  criatorio.postura " +
                               "where idpostura = " + idPostura;
            try
            {
                bdPostura = new Banco();
                bdPostura.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroPostura(Postura postura)
        {
            Banco bdPostura;
            String dtFinalPostura;
            String dtInicioNascimento;

            if (postura.FinalPostura.ToString("yyyy-MM-dd") == "1753-01-01")
                dtFinalPostura = "null";
            else
                dtFinalPostura = postura.FinalPostura.ToString("yyyy-MM-dd");
            if (postura.InicioNascimento.ToString("yyyy-MM-dd") == "1753-01-01")
                dtInicioNascimento = "null";
            else
                dtInicioNascimento = postura.InicioNascimento.ToString("yyyy-MM-dd");

            String sqlInsert = "insert into criatorio.postura(IdCasal, InicioPostura, FinalPostura, InicioNascimento, " +
                               "NumeroOvos, OvosGalados, OvosBrancos, FilhotesNascidos, FilhotesCriados, IndicAtivo)" +
                               "values(" + postura.IdCasal + ", '" + postura.InicioPostura.ToString("yyyy-MM-dd") + "', ";
            if (dtFinalPostura == "null")
                sqlInsert += "null, ";
            else
                sqlInsert += "'" + dtFinalPostura + "', ";

            if (dtInicioNascimento == "null")
                sqlInsert += "null, ";
            else
                sqlInsert += "'" + dtInicioNascimento + "', ";
            sqlInsert += postura.NumeroOvos + ", " + postura.OvosGalados + ", " + postura.OvosBrancos + ", " +
                         postura.FilhotesNascidos + ", " + postura.FilhotesCriados + ", '" + postura.IndicAtivo + "')";
            try
            {
                bdPostura = new Banco();
                bdPostura.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaPosturas(Int64 idCasal = 0, Char indicAtivo = '0')
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select pos.idpostura id, pos.Idcasal, " +
                              "InicioPostura, FinalPostura, InicioNascimento, " +
                              "NumeroOvos, OvosGalados, OvosBrancos, FilhotesNascidos, FilhotesCriados, IndicAtivo" +
                              " from criatorio.ave avp, criatorio.ave avm, criatorio.casal cas, criatorio.postura pos " +
                              " where pos.idcasal = cas.idcasal " +
                              " and cas.idmacho = avp.idave " +
                              " and cas.idfemea = avm.idave " ;

            // filtro de casal
            if (idCasal > 0)
                sqlLista += " and pos.idcasal = " + idCasal;
            // filtro de ativo/inativo
            if (indicAtivo != '0')
                sqlLista += " and pos.indicativo = '" + indicAtivo + "'";
            // finaliza o SQL
            sqlLista += " order by id";

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

        public DataTable ListaPosturasCasal(Int32 idCasal)
        {
            DataTable dtRet;
            Banco bdAve;
            String sqlLista = "select InicioPostura, FinalPostura, InicioNascimento, " +
                              "NumeroOvos, OvosGalados, OvosBrancos, FilhotesNascidos, FilhotesCriados, IndicAtivo" +
                              " from criatorio.postura pos " +
                              " where pos.idcasal =  " + idCasal + 
                              " order by idpostura";
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

        public ResumoPostura ResumoPosturas(DateTime dtIni, DateTime dtFim, Char statusPostura, Int32 idEspecie)
        {
            ResumoPostura posRet = new ResumoPostura();
            DataTable dtResumo;
            DataRow[] drResumo;
            Banco bdAve;
            String sqlLista = "select count(*) Contador, " +
                              "cast(sum(NumeroOvos) as int) TotOvos, " + 
                              "cast(sum(OvosGalados) as int) TotGalados, " + 
                              "cast(sum(OvosBrancos) as int) TotBrancos, " +
                              "cast(sum(FilhotesNascidos) as int) TotNascidos, " + 
                              "cast(sum(FilhotesCriados) as int) TotCriados" +
                              " from criatorio.postura pos, criatorio.casal cas " +
                              " where pos.IdCasal = cas.IdCasal " +
                              " and pos.InicioPostura between  '" + dtIni.ToString("yyyy-MM-dd") + "' and '" +
                              dtFim.ToString("yyyy-MM-dd") + "'";
            if (statusPostura == 'A')
                sqlLista += " and pos.IndicAtivo = 'S'";
            if (statusPostura == 'I')
                sqlLista += " and pos.IndicAtivo = 'N'";
            if (idEspecie > 0)
                sqlLista += " and cas.IdEspecie = " + idEspecie;

            try
            {
                bdAve = new Banco();
                dtResumo = bdAve.RetDataTable(sqlLista);
                drResumo = dtResumo.Select("Contador > 0");
                if (drResumo.Length > 0)
                {
                    posRet.TotalPosturas = Convert.ToInt16(drResumo[0].Field<long>(0).ToString());
                    posRet.PosturaResumo.NumeroOvos = Convert.ToInt16(drResumo[0].Field<long>(1).ToString());
                    posRet.PosturaResumo.OvosGalados = Convert.ToInt16(drResumo[0].Field<long>(2).ToString());
                    posRet.PosturaResumo.OvosBrancos = Convert.ToInt16(drResumo[0].Field<long>(3).ToString());
                    posRet.PosturaResumo.FilhotesNascidos = Convert.ToInt16(drResumo[0].Field<long>(4).ToString());
                    posRet.PosturaResumo.FilhotesCriados = Convert.ToInt16(drResumo[0].Field<long>(5).ToString());
                }
                else 
                {
                    posRet.TotalPosturas = 0;
                    posRet.PosturaResumo.NumeroOvos = 0;
                    posRet.PosturaResumo.OvosGalados = 0;
                    posRet.PosturaResumo.OvosBrancos = 0;
                    posRet.PosturaResumo.FilhotesNascidos = 0;
                    posRet.PosturaResumo.FilhotesCriados = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return posRet;
        }
    }
}
