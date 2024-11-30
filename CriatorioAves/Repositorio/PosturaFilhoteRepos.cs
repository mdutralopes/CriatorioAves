using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class PosturaFilhoteRepos : IPosturaFilhotesRepos
    {
        public Boolean ExcluirRegistrosPosturaFilhote(Int32 idPostura)
        {
            Banco bdPostura;
            String sqlDelete = "delete from  criatorio.posturafilhote " +
                               "where idpostura = " + idPostura;
            try
            {
                bdPostura = new Banco();
                // exclui a capa da reserva
                bdPostura.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroPosturaFilhote(PosturaFilhote posturaFilhote)
        {
            Banco bdPostura;
            String sqlInsert = "insert into criatorio.posturafilhote(idpostura, idave) " +
                               "values(" + posturaFilhote.IdPostura + ", " + posturaFilhote.IdAve + ")";
            try
            {
                bdPostura = new Banco();
                // inclui o registro de capa
                bdPostura.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
    }
}
