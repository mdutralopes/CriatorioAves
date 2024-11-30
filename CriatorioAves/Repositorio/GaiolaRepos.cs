using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class GaiolaRepos : IGaiolaRepos
    {
        public Boolean AlterarRegistroGaiola(Gaiola gaiola)
        {
            Banco bdGaiola;
            String sqlUpdate = "update criatorio.gaiola " +
                               "set numgaiola = " + gaiola.NumGaiola + ", " +
                               "idmodelogaiola = " + (int)gaiola.IdModeloGaiola + 
                               " where idgaiola = " + gaiola.IdGaiola;
            try
            {
                bdGaiola = new Banco();
                bdGaiola.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistroGaiola(Int64 idGaiola)
        {
            Banco bdGaiola;
            String sqlDelete = "delete from  criatorio.gaiola " +
                               "where idgaiola = " + idGaiola;
            try
            {
                bdGaiola = new Banco();
                bdGaiola.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroGaiola(Gaiola gaiola)
        {
            Banco bdGaiola;
            String sqlInsert = "insert into criatorio.gaiola(NumGaiola, IdModeloGaiola) " +
                               "values(" + gaiola.NumGaiola + ", " + gaiola.IdModeloGaiola + ")";
            try
            {
                bdGaiola = new Banco();
                bdGaiola.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaGaiolas()
        {
            DataTable dtRet;
            Banco bdGaiola;
            String sqlLista = "select concat(lpad(cast(gai.numgaiola as char), 3, '0'), ' - '," +
                              "case modelo.tipogaiola " +
                              " when 0 then 'Voadeira' " +
                              " when 1 then  'Criação' " + " end) Descr," +
                              "idgaiola id, numgaiola " +
                              " from criatorio.gaiola gai, criatorio.modelogaiola modelo " +
                              " where gai.IdModeloGaiola = modelo.IdModeloGaiola " +
                              " order by descr";
            try
            {
                bdGaiola = new Banco();
                dtRet = bdGaiola.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }

        public DataTable ListaGaiolasForm()
        {
            DataTable dtRet;
            Banco bdGaiola;
            String sqlLista = "select idgaiola id, numgaiola, idmodelogaiola " +
                              " from criatorio.gaiola gai " +
                              " order by id";
            try
            {
                bdGaiola = new Banco();
                dtRet = bdGaiola.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }
    }
}
