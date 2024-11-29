using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IEspecieRepos
    {
        Boolean AlterarRegistroEspecie(Especie especie);
        Boolean IncluirRegistroEspecie(Especie especie);
        Boolean ExcluirRegistroEspecie(Int64 idEspecie);
        DataTable ListaEspecies();
    }
}
