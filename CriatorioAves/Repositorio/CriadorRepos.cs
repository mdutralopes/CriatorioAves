using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class CriadorRepos : ICriadorRepos
    {
        public bool AlterarRegistroCriador(Criador criador)
        {
            Banco bdCriador;
            String sqlUpdate = "update criatorio.criador " +
                               "set nomecriador = '" + criador.NomeCriador + "', " +
                               "registrocriador = '" + criador.RegistroCriador + "', " +
                               "emailcriador = '" + criador.EmailCriador + "', " +
                               "telefonecriador = '" + criador.TelefoneCriador + "' " +
                               "where idcriador = " + criador.IdCriador;
            try
            {
                bdCriador = new Banco();
                bdCriador.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool ExcluirRegistroCriador(Int64 idCriador)
        {
            Banco bdCriador;
            String sqlDelete = "delete from  criatorio.criador " +
                               "where idcriador = " + idCriador;
            try
            {
                bdCriador = new Banco();
                bdCriador.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool IncluirRegistroCriador(Criador criador)
        {
            Banco bdCriador;
            String sqlInsert = "insert into criatorio.criador(NomeCriador, RegistroCriador, EmailCriador, TelefoneCriador) " +
                               "values('" + criador.NomeCriador + "', '" + criador.RegistroCriador + "', '" + criador.EmailCriador +
                               "', '" + criador.TelefoneCriador + "')";
            try
            {
                bdCriador = new Banco();
                bdCriador.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaCriadores()
        {
            DataTable dtRet;
            Banco bdCriador;
            String sqlLista = "select IdCriador Id, NomeCriador Nome from criatorio.criador order by NomeCriador";
            try
            {
                bdCriador = new Banco();
                dtRet = bdCriador.RetDataTable(sqlLista);
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
