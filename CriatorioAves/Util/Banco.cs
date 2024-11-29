using MySql.Data.MySqlClient;
using System.Data;

namespace CriatorioAves.Util
{
    //Data Access Layer
    public class Banco
    {
        private static string Server = "localhost";
        private static string Database = "criatorio";
        private static string User = "root";
        private static string Password = "";
        private static string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;Charset=utf8;";
        private static MySqlConnection Connection;
        private MySqlTransaction transaction = null;

        public Banco()
        {
            //Connection = new MySqlConnection(ConnectionString);
            //Connection.Open();
            Connection = Conexao.GetInstance(ConnectionString);
        }

        //Espera um parâmetro do tipo string 
        //contendo um comando SQL do tipo SELECT
        public DataTable RetDataTable(string sql)
        {
            DataTable data = new DataTable();
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(Command);
            da.Fill(data);
            return data;
        }

        //Espera um parâmetro do tipo string 
        //contendo um comando SQL do tipo INSERT, UPDATE, DELETE
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

        public void IniciaTransacao()
        {
            transaction = Connection.BeginTransaction();
        }

        public void CommitaTransacao()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction.Dispose();
                transaction = null;
            }
        }

        public void RollBackTransacao()
        {
            transaction.Rollback();
        }
    }
}
