using CriatorioAves.Modelo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriatorioAves.Arguments
{
    public class ArgFiltroAve
    {
        public Boolean FiltrarEspecie { get; set; }
        public Int32 IdEspecie { get; set; }
        public Int32 IndiceComboEspecie { get; set; }
        public Boolean FiltrarSexo { get; set; }
        public Char Sexo { get; set; }
        public Boolean FiltrarStatus { get; set; }
        public StatusAve StatusAve { get; set; }
        public Int32 IndiceComboStatus { get; set; }
        public Boolean FiltrarGaiola { get; set; }
        public Int32 IdGaiola { get; set; }
        public Int32 IndiceComboGaiola { get; set; }
        public Boolean FiltrarCriador { get; set; }
        public Int32 IdCriador { get; set; }
        public Int32 IndiceComboCriador { get; set; }
        public Boolean FiltrarAnoNasc { get; set; }
        public Int32 AnoNasc { get; set; }

        public ArgFiltroAve()
        {
            FiltrarEspecie = false;
            IdEspecie = -1;
            IndiceComboEspecie = -1;
            FiltrarSexo = false;
            Sexo = '0';
            FiltrarStatus = false;
            StatusAve = StatusAve.ComOsPais;
            IndiceComboStatus = -1;
            FiltrarGaiola = false;
            IdGaiola = -1;
            IndiceComboGaiola = -1;
            FiltrarCriador = false;
            IdCriador = -1;
            IndiceComboCriador = -1;
            FiltrarAnoNasc = false;
            AnoNasc = DateTime.Today.Year;
        }
    }
}
