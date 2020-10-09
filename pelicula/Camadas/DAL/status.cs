using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class status
    {
        private string strCon = Conexao.getConexao();

        public List<Model.status> Select()
        {
            List<Model.status> ListaStatus = new List<Model.status>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from status;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.status status = new Model.status();
                    status.idStatus = Convert.ToInt32(reader[0].ToString());
                    status.desc_status = reader["desc_status"].ToString();
                    ListaStatus.Add(status);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução de status ...");
            }
            finally
            {
                conexao.Close();
            }
            return ListaStatus;
        }

        public void Insert(Model.status status)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into status values (@desc_status)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc_status", status.desc_status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de status ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.status status)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update status set desc_status=@desc_status";
            sql += " where idStatus=@idStatus;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idStatus", status.idStatus);
            cmd.Parameters.AddWithValue("@desc_status", status.desc_status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de status ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.status status)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from status where idStatus=@idStatus;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idStatus", status.idStatus);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de status ...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

