using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class EspecieRepos : IEspecieRepos
    {
        public Boolean AlterarRegistroEspecie(Especie especie)
        {
            Banco bdEspecie;
            String sqlUpdate = "update criatorio.especie " +
                               "set nomeespecie = '" + especie.NomeEspecie + "', " +
                               "nomecientificoespecie = '" + especie.NomeCientifico + "' " +
                               "where idespecie = " + especie.IdEspecie;
            try
            {
                bdEspecie = new Banco();
                bdEspecie.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroEspecie(Especie especie)
        {
            Banco bdEspecie;
            String sqlInsert = "insert into criatorio.especie(nomeespecie, nomecientificoespecie) " +
                               "values('" + especie.NomeEspecie + "', '"  + especie.NomeCientifico + "')";
            try
            {
                bdEspecie = new Banco();
                bdEspecie.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistroEspecie(Int64 idEspecie)
        {
            Banco bdEspecie;
            String sqlDelete = "delete from  criatorio.especie " +
                               "where idespecie = " + idEspecie;
            try
            {
                bdEspecie = new Banco();
                bdEspecie.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaEspecies()
        {
            DataTable dtRet;
            Banco bdEspecie;
            String sqlLista = "select IdEspecie Id, NomeEspecie Nome from criatorio.especie order by NomeEspecie";
            try
            {
                bdEspecie = new Banco();
                dtRet = bdEspecie.RetDataTable(sqlLista);
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
