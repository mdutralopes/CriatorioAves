using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IAcasalamentoRepos
    {
        Boolean AlterarRegistroAcasalamento(Acasalamento acasalamento);
        Boolean IncluirRegistroAcasalamento(Acasalamento acasalamento);
        Boolean ExcluirRegistrosAcasalamentos(Int32 idCasal);
        DataTable ListaAcasalamentos(Int32 idCasal);
    }
}
