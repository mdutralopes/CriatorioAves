using CriatorioAves.Modelo;
using System;
using System.Data;

namespace CriatorioAves.Interface
{
    public interface ICriadorRepos
    {
        Boolean AlterarRegistroCriador(Criador criador);
        Boolean IncluirRegistroCriador(Criador criador);
        Boolean ExcluirRegistroCriador(Int64 idCriador);
        DataTable ListaCriadores();
    }
}
