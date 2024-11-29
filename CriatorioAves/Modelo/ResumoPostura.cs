using System;

namespace CriatorioAves.Modelo
{
    public class ResumoPostura
    {
        public Int64 TotalPosturas { get; set; }
        public Postura PosturaResumo { get; set; }

        public ResumoPostura()
        {
            TotalPosturas = 0;
            PosturaResumo = new Postura();
        }
    }
}
