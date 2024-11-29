using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IGaiolaRepos
    {
        Boolean AlterarRegistroGaiola(Gaiola gaiola);
        Boolean IncluirRegistroGaiola(Gaiola gaiola);
        Boolean ExcluirRegistroGaiola(Int64 idGaiola);
        DataTable ListaGaiolas();
        DataTable ListaGaiolasForm();
    }
}
