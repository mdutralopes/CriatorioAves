using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class ReservaAvesRepos : IReservaAvesRepos
    {
        public Boolean AlterarRegistroReservaAves(ReservaAves reservaAves)
        {
            throw new NotImplementedException();
        }

        public Boolean ExcluirRegistrosReservaAves(Int32 idReserva)
        {
            Banco bdReserva;
            String sqlDelete = "delete from  criatorio.reservaaves " +
                               "where idreserva = " + idReserva;
            try
            {
                bdReserva = new Banco();
                // exclui a capa da reserva
                bdReserva.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroReservaAves(ReservaAves reservaAves)
        {
            Banco bdReserva;
            String sqlInsert = "insert into criatorio.reservaaves(idreserva, idave, valorave) " +
                               "values(" + reservaAves.IdReserva + ", " + reservaAves.IdAve +
                               ", " + reservaAves.ValorAve + ")";
            try
            {
                bdReserva = new Banco();
                // inclui o registro de capa
                bdReserva.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaReservasAves(Int32 idReserva)
        {
            throw new NotImplementedException();
        }
    }
}
