using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IModeloRepos
    {
        DataTable ListaModelosGaiolas();
        Boolean IncluirRegistroModelo(ModeloGaiola modelo);
        Boolean AlterarRegistroModelo(ModeloGaiola modelo);
        Boolean ExcluirRegistroModelo(Int32 idModelo);
        DataTable ListaCompletaModelosGaiolas();
        DataTable ObterRegistroModelo(Int32 IdModelo);
    }
}
