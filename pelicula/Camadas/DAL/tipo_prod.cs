using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class tipo_prod
    {
        private string strCon = Conexao.getConexao();

        public List<Model.tipo_prod> Select()
        {
            List<Model.tipo_prod> ListaProduto = new List<Model.tipo_prod>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from tipo_prod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.tipo_prod tipo_prod = new Model.tipo_prod();
                    tipo_prod.idTipo_prod = Convert.ToInt32(reader[0].ToString());
                    //tipo_prod.idProduto = Convert.ToInt32(reader["idProduto"].ToString());
                    tipo_prod.tipo = reader["tipo"].ToString();
                    ListaProduto.Add(tipo_prod);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de tipos de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaProduto;
        }

        public void Insert(Model.tipo_prod tipo_prod)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into tipo_prod values (@tipo)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            //cmd.Parameters.AddWithValue("@idProduto", tipo_prod.idProduto);
            cmd.Parameters.AddWithValue("@tipo", tipo_prod.tipo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na inserção de tipos de produtos ... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.tipo_prod tipo_prod)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update tipo_prod set tipo=@tipo";
            sql += " where idTipo_prod=@idTipo_prod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idTipo_prod", tipo_prod.idTipo_prod);
            //cmd.Parameters.AddWithValue("@idProduto", tipo_prod.idProduto);
            cmd.Parameters.AddWithValue("@tipo", tipo_prod.tipo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de tipos de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.tipo_prod tipo_prod)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from tipo_prod where idTipo_prod=@idTipo_prod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idTipo_prod", tipo_prod.idTipo_prod);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de tipo de produtos ... ");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
