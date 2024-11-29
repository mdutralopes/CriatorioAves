using CriatorioAves.Modelo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriatorioAves.Modelo
{
    public class ModeloGaiola
    {
        public Int32 IdModeloGaiola { get; set; }
        public MaterialGaiola Material { get; set; }
        public TipoGaiola Tipo { get; set; }
        public String FabricanteGaiola { get; set; }
        public Int16 LarguraGaiola { get; set; }
        public Int16 AlturaGaiola { get; set; }
        public Int16 CompGaiola { get; set; }
        public String ObsModelo { get; set; }
    }
}
