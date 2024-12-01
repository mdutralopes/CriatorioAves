using CriatorioAves.Arguments;
using CriatorioAves.Modelo;
using CriatorioAves.Modelo.Enum;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface IAveRepos
    {
        Boolean AlterarRegistroAve(Ave ave);
        Boolean IncluirRegistroAve(Ave ave);
        Boolean ExcluirRegistroAve(Int32 idAve);
        Boolean IncluirRegistroAve(Ave ave, Int64 idPostura);

        DataTable ListaAves(Char sexo = 'T', Int32 idEspecie = 0, StatusAve? statusAve = null, 
                            Int32 idGaiola = 0, Int32 idCriador = 0, Int32 anoNasc = 0);
        DataTable ListaAvesCombo(Int32 idAve, Int32 idEspecie, Char sexo);
        DataTable ListaAvesCombo(Int32 idEspecie);
        DataTable ListaAvesCombo(Int32 idEspecie, Char sexo);
        DataTable ListaFilhos(Int32 idAve);
        DataTable ListaFilhosCasal(Int32 idCasal);
        DataTable ListaFilhotesPostura(Int32 idPostura);
        DataTable ListaAvesPorGaiola(Int32 idGaiola);
        DataTable ListaAvesCriador(Int32 idCriador);
        Boolean AlterarGaiolaAve(Int32 idAve, Int32 idGaiola);
        String ObterDescrAve(Int32 idAve);
        ArgDescrAve ObterDescrAveReserva(Int32 idAve);
        Boolean MudarStatusAve(Int32 idAve, StatusAve status);
        Parents ObterCelulaPedigree(Int32 idAve);
        void ObterIdsPaisAve(Int32 idAve, ref Int32 idPai, ref Int32 idMae);
        String DescrParAve(Int32 idAve, Char sexo);
    }
}