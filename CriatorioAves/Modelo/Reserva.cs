using System;
using System.Collections.Generic;

namespace CriatorioAves.Modelo
{
    public class Reserva
    {
        public Int32 IdReserva { get; set; }
        public Int32 IdCliente { get; set; }
        public DateTime DataReserva { get; set; }
        public Double ValorReserva { get; set; }
        public List<ReservaAves> AvesReservas { get; set; }

        public Reserva(): base()
        {
            AvesReservas = new List<ReservaAves>();
        }
    }
}
