using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class ReservaRepos : IReservaRepos
    {
        public Boolean AlterarRegistroReserva(Reserva reserva)
        {
            Banco bdReserva;
            IReservaAvesRepos repAvesReserva = new ReservaAvesRepos();
            String sqlUpdate = "update criatorio.reserva " +
                               "set idcliente = " + reserva.IdCliente + ", " +
                               "datareserva = '" + reserva.DataReserva.ToString("yyyy-MM-dd") + "', " +
                               "valorreserva = " + reserva.ValorReserva + " " +
                               "where idreserva = " + reserva.IdReserva;
            try
            {
                bdReserva = new Banco();
                // alterar o registro de capa
                bdReserva.ExecutarComandoSQL(sqlUpdate);
                // exclui as reservas de aves
                repAvesReserva.ExcluirRegistrosReservaAves(reserva.IdReserva);
                // altera os regisros de aves
                foreach (ReservaAves aveRes in reserva.AvesReservas)
                {
                    IAveRepos aveRep = new AveRepos();
                    repAvesReserva.IncluirRegistroReservaAves(aveRes);
                    aveRep.MudarStatusAve(aveRes.IdAve, Modelo.Enum.StatusAve.Reservado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistroReserva(Int32 idReserva)
        {
            Banco bdReserva;
            IReservaAvesRepos repAvesReserva = new ReservaAvesRepos();
            String sqlDelete = "delete from  criatorio.reserva " +
                               "where idreserva = " + idReserva;
            try
            {
                bdReserva = new Banco();
                // exclui os itens da reservas(aves)
                repAvesReserva.ExcluirRegistrosReservaAves(idReserva);
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

        public Boolean IncluirRegistroReserva(Reserva reserva)
        {
            Banco bdReserva;
            String sqlInsert = "insert into criatorio.reserva(idcliente, datareserva, valorreserva) " +
                               "values(" + reserva.IdCliente + ", '" + reserva.DataReserva.ToString("yyyy-MM-dd") +
                               "', " + reserva.ValorReserva + ")";
            try
            {
                bdReserva = new Banco();
                // inclui o registro de capa
                bdReserva.ExecutarComandoSQL(sqlInsert);
                // inclui os registros de aves/reservas
                foreach (ReservaAves aveRes in reserva.AvesReservas)
                {
                    IAveRepos aveRep = new AveRepos();
                    IReservaAvesRepos repAvesReserva = new ReservaAvesRepos();
                    aveRes.IdReserva = ObterIdReserva();
                    repAvesReserva.IncluirRegistroReservaAves(aveRes);
                    aveRep.MudarStatusAve(aveRes.IdAve, Modelo.Enum.StatusAve.Reservado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        private Int32 ObterIdReserva()
        {
            Int32 idRet = 0;
            DataTable dtReserva;
            DataRow[] drReserva;
            Banco bdReserva;
            String sqlLista = "select max(IdReserva) Id from criatorio.reserva";
            try
            {
                bdReserva = new Banco();
                dtReserva = bdReserva.RetDataTable(sqlLista);
                drReserva = dtReserva.Select("Id > 0");
                idRet = Convert.ToInt32(drReserva[0].Field<int>(0).ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return idRet;
        }

        public DataTable ListaReservas()
        {
            DataTable dtRet;
            Banco bdReserva;
            String sqlLista = "select IdReserva Id, IdCliente, DataReserva, ValorReserva from criatorio.reserva order by idreserva";
            try
            {
                bdReserva = new Banco();
                dtRet = bdReserva.RetDataTable(sqlLista);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return dtRet;
        }
    }
}
