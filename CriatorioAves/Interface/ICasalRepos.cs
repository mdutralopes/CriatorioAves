using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface ICasalRepos
    {
        Boolean AlterarRegistroCasal(Casal casal);
        Boolean IncluirRegistroCasal(Casal casal);
        Boolean ExcluirRegistroCasal(Int32 idCasal);
        DataTable ListaCasais();
        DataTable ListaCasaisCombo();
        DataTable ListaCasaisComboFiltro();
        Int32 CasalExiste(Int32 idAvePai, Int32 idAveMae);
        Int32 ObterIdPar(Int32 idAve, Char sexo);
    }
}
