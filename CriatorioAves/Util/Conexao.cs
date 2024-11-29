using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CriatorioAves.Util
{
    public sealed class Conexao
    {
        private static MySqlConnection Instancia;
        
        private Conexao(String connectionString)
        {
            Instancia = new MySqlConnection(connectionString);
            Instancia.Open();
        }

        public static MySqlConnection GetInstance(String connectionString)
        {
            Conexao conexao;
            try
            {
                if (Instancia == null)
                {
                    conexao = new Conexao(connectionString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro Conexão!");
                return null;
            }
            return Instancia;
        }
    }
}
