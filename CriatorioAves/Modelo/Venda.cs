using System;

namespace CriatorioAves.Modelo
{
    public class Venda
    {
        public Int64 IdAve { get; set; }
        public Int64 IdCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public Double Valor { get; set; }
    }
}
