using CriatorioAves.Interface;
using CriatorioAves.Repositorio;
using System;

namespace CriatorioAves.Modelo
{
    public class ReservaAves
    {
        public Int32 IdReserva { get; set; }
        public Int32 IdAve { get; set; }
        public Double ValorAve { get; set; }
    }
}
