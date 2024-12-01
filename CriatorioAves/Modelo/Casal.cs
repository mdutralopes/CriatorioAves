using System;

namespace CriatorioAves.Modelo
{
    public class Casal
    {
        public Int32 IdCasal { get; set; }
        public Int32 IdEspecie { get; set; }
        public Int32 IdAveMacho { get; set; }
        public Int32 IdAveFemea { get; set; }
        public DateTime DataJuncao { get; set; }
        public DateTime DataSeparacao { get; set; }
        public Int32 IdGaiola { get; set; }

        public Casal()
        {
            DataSeparacao = new DateTime(1753, 1, 1);
        }
    }
}
