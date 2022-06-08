using System.Data.SqlClient;

namespace Mercearia.Model.DAO
{
    internal class ProdutoDAO
    {
        Conexao conexao = new Conexao();

        SqlCommand comandoSql = new SqlCommand();

        public void Inserir(Produto produto)
        {
            comandoSql.CommandText = "INSERT INTO produto(nome, quantidade, unidade_medida, valor) VALUES (@nome, @quantidade, @unidade_medida, @valor) ";
            comandoSql.Parameters.AddWithValue("@nome", produto.Nome);
            comandoSql.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            comandoSql.Parameters.AddWithValue("@unidade_medida", produto.UnidadeMedida);
            comandoSql.Parameters.AddWithValue("@valor", produto.Valor);

            try
            {
                comandoSql.Connection = conexao.Conectar();
                comandoSql.ExecuteNonQuery();
            }
            catch(SqlException e)
            {

            }
            finally
            {
                conexao.Desconectar();
            }
        }

    }
}
