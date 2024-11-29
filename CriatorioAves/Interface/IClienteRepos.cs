using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IClienteRepos
    {
        Boolean AlterarRegistroCliente(Cliente cliente);
        Boolean IncluirRegistroCliente(Cliente cliente);
        Boolean ExcluirRegistroCliente(Int64 idCliente);
        DataTable ListaClientes();
    }
}
