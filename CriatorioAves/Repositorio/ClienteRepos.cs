using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    class ClienteRepos : IClienteRepos
    {
        public Boolean AlterarRegistroCliente(Cliente cliente)
        {
            Banco bdCliente;
            String sqlUpdate = "update criatorio.cliente " +
                               "set nomecliente = '" + cliente.NomeCliente + "', " +
                               "emailcliente = '" + cliente.EmailCliente + "', " +
                               "telefonecliente = '" + cliente.TelefoneCliente + "' " +
                               "where idcliente = " + cliente.IdCliente;
            try
            {
                bdCliente = new Banco();
                bdCliente.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistroCliente(Int64 idCliente)
        {
            Banco bdCliente;
            String sqlDelete = "delete from  criatorio.cliente " +
                               "where idcliente = " + idCliente;
            try
            {
                bdCliente = new Banco();
                bdCliente.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;

        }

        public Boolean IncluirRegistroCliente(Cliente cliente)
        {
            Banco bdCliente;
            String sqlInsert = "insert into criatorio.cliente(NomeCliente, EmailCliente, TelefoneCliente) " +
                               "values('" + cliente.NomeCliente + "', '"  + cliente.EmailCliente +
                               "', '" + cliente.TelefoneCliente + "')";
            try
            {
                bdCliente = new Banco();
                bdCliente.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaClientes()
        {
            DataTable dtRet;
            Banco bdCliente;
            String sqlLista = "select IdCliente Id, NomeCliente Nome from criatorio.cliente order by NomeCliente";
            try
            {
                bdCliente = new Banco();
                dtRet = bdCliente.RetDataTable(sqlLista);
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
