using CriatorioAves.Arguments;
using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class ModeloGaiolaRepos : IModeloRepos
    {
        public Boolean AlterarRegistroModelo(ModeloGaiola modelo)
        {
            Banco bdModeloGaiola;
            String sqlUpdate = "update criatorio.modelogaiola " +
                               "set materialgaiola = " + (int)modelo.Material + ", " +
                               " tipogaiola = " + (int)modelo.Tipo + ", " +
                               " fabricantegaiola = '" + modelo.FabricanteGaiola + "', " +
                               " alturagaiola = " + modelo.AlturaGaiola + ", " +
                               " compgaiola = " + modelo.CompGaiola + ", " + 
                               " larguragaiola = " + modelo.LarguraGaiola + ", " +
                               " obsmodelo = '" + modelo.ObsModelo + "'" + 
                               " where idmodelogaiola = " + modelo.IdModeloGaiola;
            try
            {
                bdModeloGaiola = new Banco();
                bdModeloGaiola.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool ExcluirRegistroModelo(Int32 idModelo)
        {
            Banco bdModeloGaiola;
            String sqlDelete = "delete from  criatorio.modelogaiola " +
                               "where idmodelogaiola = " + idModelo;
            try
            {
                bdModeloGaiola = new Banco();
                bdModeloGaiola.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroModelo(ModeloGaiola modelo)
        {
            Banco bdModeloGaiola;
            String sqlInsert = "insert into criatorio.modelogaiola(materialgaiola, tipogaiola, fabricantegaiola, " +
                                "alturagaiola, compgaiola, larguragaiola, obsmodelo) " +
                               "values(" + (int)modelo.Material + ", " + (int)modelo.Tipo + ", '" + modelo.FabricanteGaiola + "', " +  
                               modelo.AlturaGaiola + ", " + modelo.CompGaiola + ", " + modelo.LarguraGaiola + ", '" + modelo.ObsModelo + "')";
            try
            {
                bdModeloGaiola = new Banco();
                bdModeloGaiola.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaModelosGaiolas()
        {
            DataTable dtRet;
            Banco bdModeloGaiola;
            String sqlLista = "select concat(fabricantegaiola, ' - '," +
                              "case tipogaiola " +
                              " when 0 then 'Voadeira' " +
                              " when 1 then  'Criação' " + " end,  ' - ', " + "case materialgaiola " +
                              " when 0 then 'Madeira' " +
                              " when 1 then 'Galvanizado' " +
                              " when 2 then  'Epoxi' " + " end) Descr, " +
                              "idmodelogaiola id " +
                              " from criatorio.modelogaiola " +
                              " order by descr";
            try
            {
                bdModeloGaiola = new Banco();
                dtRet = bdModeloGaiola.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }

        public DataTable ListaCompletaModelosGaiolas()
        {
            DataTable dtRet;
            Banco bdModeloGaiola;
            String sqlLista = "select idmodelogaiola id, materialgaiola, tipogaiola, fabricantegaiola, " +
                              "alturagaiola, compgaiola, larguragaiola, obsmodelo" +
                              " from criatorio.modelogaiola " +
                              " order by id";
            try
            {
                bdModeloGaiola = new Banco();
                dtRet = bdModeloGaiola.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }

        public DataTable ObterRegistroModelo(Int32 IdModelo)
        {
            DataTable modRet;
            Banco bdModeloGaiola;
            String sqlLista = "select idmodelogaiola id, materialgaiola, tipogaiola, fabricantegaiola, " +
                              "alturagaiola, compgaiola, larguragaiola, obsmodelo" +
                              " from criatorio.modelogaiola " +
                              " where idmodelogaiola = " + IdModelo;
            try
            {
                bdModeloGaiola = new Banco();
                modRet = bdModeloGaiola.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            return modRet;
        }
    }
}
