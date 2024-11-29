using CriatorioAves.Modelo.Enum;
using System;

namespace CriatorioAves.Modelo
{
    public class Ave
    {
        public Int32 IdAve { get; set; }
        public String Identificacao { get; set; }
        public Char Sexo { get; set; }
        public Int32 IdEspecie { get; set; }
        public String CorMutacao { get; set; }
        public String NomeAve { get; set; }
        public DateTime DataNascimento { get; set; }
        public StatusAve Status { get; set; }
        public Int32 IdCriador { get; set; }
        public DateTime DataCompra { get; set; }
        public Double Valor { get; set; }
        public Int32 IdGaiola { get; set; }
        public Int32 IdPaiAve { get; set; }
        public Int32 IdMaeAve { get; set; }
        public String Observacao { get; set; }
    }
}
