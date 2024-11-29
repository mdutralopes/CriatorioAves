using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IReservaRepos
    {
        Boolean AlterarRegistroReserva(Reserva reserva);
        Boolean IncluirRegistroReserva(Reserva reserva);
        Boolean ExcluirRegistroReserva(Int32 idReserva);
        DataTable ListaReservas();
    }
}
