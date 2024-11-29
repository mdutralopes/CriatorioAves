using CriatorioAves.Interface;
using CriatorioAves.Modelo;
using CriatorioAves.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriatorioAves.Repositorio
{
    public class AcasalamentoRepos : IAcasalamentoRepos
    {
        public Boolean AlterarRegistroAcasalamento(Acasalamento acasalamento)
        {
            Banco bdCasal;
            String dtSepara;

            if (acasalamento.DataSepara.ToString("yyyy-MM-dd") == "0001-01-01")
                dtSepara = "null";
            else
                dtSepara = acasalamento.DataSepara.ToString("yyyy-MM-dd");

            String sqlUpdate = "update criatorio.acasalamento ";
            if (dtSepara == "null")
                sqlUpdate += "DataSepara = null " + ", ";
            else
                sqlUpdate += "DataSepara = '" + dtSepara + "', ";
            sqlUpdate += "IdGaiola = " + acasalamento.IdGaiola +
                         " where IdCasal = " + acasalamento.IdCasal +
                         " and DataJuncao = '" + acasalamento.DataJuncao.ToString("yyyy-MM-dd") + "'";
            try
            {
                bdCasal = new Banco();
                bdCasal.ExecutarComandoSQL(sqlUpdate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean ExcluirRegistrosAcasalamentos(int idCasal)
        {
            Banco bdCasal;
            String sqlDelete = "delete from  criatorio.casal " +
                               "where idcasal = " + idCasal;
            try
            {
                bdCasal = new Banco();
                bdCasal.ExecutarComandoSQL(sqlDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public Boolean IncluirRegistroAcasalamento(Acasalamento acasalamento)
        {
            Banco bdCasal;
            String dtSepara;

            if (acasalamento.DataSepara.ToString("yyyy-MM-dd") == "1753-01-01")
                dtSepara = "null";
            else
                dtSepara = acasalamento.DataSepara.ToString("yyyy-MM-dd");

            String sqlInsert = "insert into criatorio.acasalamento(IdCasal, DataJuncao, DataSepara, IdGaiola) " +
                               "values(" + acasalamento.IdCasal + ", " + acasalamento.DataJuncao.ToString("yyyy-MM-dd") + "', ";
            if (dtSepara == "null")
                sqlInsert += " null, " + acasalamento.IdGaiola + ")";
            else
                sqlInsert += "'" + dtSepara + "', " + acasalamento.IdGaiola + ")";

            try
            {
                bdCasal = new Banco();
                bdCasal.ExecutarComandoSQL(sqlInsert);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public DataTable ListaAcasalamentos(Int32 idCasal)
        {
            DataTable dtRet;
            Banco bdCasal;
            String sqlLista = "select DataJuncao, DataSepara, IdGaiola from criatorio.acasalamento " +
                              " where idcasal = " + idCasal + " order by IdCasal, DataJuncao";
            try
            {
                bdCasal = new Banco();
                dtRet = bdCasal.RetDataTable(sqlLista);
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
