using System.Data.SqlClient;

namespace Mercearia.Model.DAO
{
    internal class Conexao
    {
        private SqlConnection conexao = new SqlConnection();

        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mercearia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlConnection Conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
