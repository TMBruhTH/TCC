using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class produto
    {
        private string strCon = Conexao.getConexao();

        public List<Model.produto> Select()
        {
            List<Model.produto> ListaProduto = new List<Model.produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.produto produto = new Model.produto();
                    produto.idProduto = Convert.ToInt32(reader[0].ToString());
                    produto.idFornecedor = Convert.ToInt32(reader["idFornecedor"].ToString());
                    produto.idTipo_prod = Convert.ToInt32(reader["idTipo_prod"].ToString());
                    produto.tonalidade = reader["tonalidade"].ToString();
                    produto.valor = Convert.ToDouble(reader["valor"].ToString());
                    ListaProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaProduto;
        }

        public void Insert(Model.produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into produto values (@idFornecedor, @idTipo_prod, @tonalidade, @valor)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", produto.idFornecedor);
            cmd.Parameters.AddWithValue("@idTipo_prod", produto.idTipo_prod);
            cmd.Parameters.AddWithValue("@tonalidade", produto.tonalidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update produto set idFornecedor=@idFornecedor,";
            sql += "idTipo_prod=@idTipo_prod, tonalidade=@tonalidade,";
            sql += "valor=@valor";
            sql += " where idProduto=@idProduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
            cmd.Parameters.AddWithValue("@idFornecedor", produto.idFornecedor);
            cmd.Parameters.AddWithValue("@idTipo_prod", produto.idTipo_prod);
            cmd.Parameters.AddWithValue("@tonalidade", produto.tonalidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from produto where idProduto=@idProduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
