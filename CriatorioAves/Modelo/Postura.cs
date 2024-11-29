using System;
using System.Collections.Generic;

namespace CriatorioAves.Modelo
{
    public class Postura
    {
        public Int32 IdPostura { get; set; }
        public Int32 IdCasal { get; set; }
        public DateTime InicioPostura { get; set; }
        public DateTime FinalPostura { get; set; }
        public DateTime InicioNascimento { get; set; }
        public Int16 NumeroOvos { get; set; }
        public Int16 OvosGalados { get; set; }
        public Int16 OvosBrancos { get; set; }
        public Int16 FilhotesNascidos { get; set; }
        public Int16 FilhotesCriados { get; set; }
        public Char IndicAtivo { get; set; }
        public List<PosturaFilhote> FilhotesPostura { get; set; }

        public Postura(): base()
        {
            FilhotesPostura = new List<PosturaFilhote>();
        }
    }
}
