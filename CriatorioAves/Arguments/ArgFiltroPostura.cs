using System;

namespace CriatorioAves.Arguments
{
    public class ArgFiltroPostura
    {
        public Boolean FiltrarAtivo { get; set; }
        public Boolean ValorFiltroAtivo { get; set; }
        public Boolean FiltrarCasal { get; set; }
        public Int64 IdCasalFiltro { get; set; }
        public Int32 IndiceComboCasal { get; set; }

        public ArgFiltroPostura()
        {
            FiltrarAtivo = false;
            ValorFiltroAtivo = false;
            FiltrarCasal = false;
            IdCasalFiltro = -1;
            IndiceComboCasal = -1;
        }
    }
}
