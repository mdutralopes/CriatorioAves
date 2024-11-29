using CriatorioAves.Modelo;
using System;

namespace CriatorioAves.Interface
{
    public interface IPosturaFilhotesRepos
    {
         Boolean IncluirRegistroPosturaFilhote(PosturaFilhote posturaFilhote);
         Boolean ExcluirRegistrosPosturaFilhote(Int32 idPostura);
    }
}
