using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IPosturaRepos
    {
        Boolean AlterarRegistroPostura(Postura postura);
        Boolean IncluirRegistroPostura(Postura postura);
        Boolean ExcluirRegistroPostura(Int32 idPostura);
        DataTable ListaPosturas(Int64 idCasal = 0, Char indicAtivo = '0');
        DataTable ListaPosturasCasal(Int32 idCasal);
        ResumoPostura ResumoPosturas(DateTime dtIni, DateTime dtFim, Char statusPostura, Int32 idEspecie);
    }
}
