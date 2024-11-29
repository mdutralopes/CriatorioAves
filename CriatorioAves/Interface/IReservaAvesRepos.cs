using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IReservaAvesRepos
    {
        Boolean AlterarRegistroReservaAves(ReservaAves reservaAves);
        Boolean IncluirRegistroReservaAves(ReservaAves reservaAves);
        Boolean ExcluirRegistrosReservaAves(Int32 idReservaAves);
        DataTable ListaReservasAves(Int32 idReserva);
    }
}
