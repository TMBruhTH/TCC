using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class tipo_serv
    {
        private string strCon = Conexao.getConexao();

        public List<Model.tipo_serv> Select()
        {
            List<Model.tipo_serv> ListaServico = new List<Model.tipo_serv>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from tipo_serv;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.tipo_serv tipo_serv = new Model.tipo_serv();
                    tipo_serv.idTipo_serv = Convert.ToInt32(reader[0].ToString());
                    tipo_serv.idTipo_prod = Convert.ToInt32(reader["idTipo_prod"].ToString());
                    tipo_serv.serv_lateral = reader["serv_lateral"].ToString();
                    tipo_serv.serv_frontal = reader["serv_frontal"].ToString();
                    ListaServico.Add(tipo_serv);
                }
            }

            catch
            {
                Console.WriteLine("Deu erro na seleção de tipo de serviços ... ");
            }

            finally
            {
                conexao.Close();
            }
            return ListaServico;
        }

        public void Insert(Model.tipo_serv tipo_serv)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into tipo_serv values(@idTipo_prod, @serv_lateral, @serv_frontal)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idTipo_prod", tipo_serv.idTipo_prod);
            cmd.Parameters.AddWithValue("@serv_lateral", tipo_serv.serv_lateral);
            cmd.Parameters.AddWithValue("@serv_frontal", tipo_serv.serv_frontal);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na inserção de tipo de serviços ... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.tipo_serv tipo_serv)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update tipo_serv set idTipo_prod=@idTipo_prod,";
            sql += "serv_lateral=@serv_lateral, serv_frontal=@serv_frontal";
            sql += " where idTipo_serv=@idTipo_serv;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idTipo_serv", tipo_serv.idTipo_serv);
            cmd.Parameters.AddWithValue("@idTipo_prod", tipo_serv.idTipo_prod);
            cmd.Parameters.AddWithValue("@serv_lateral", tipo_serv.serv_lateral);
            cmd.Parameters.AddWithValue("@serv_frontal", tipo_serv.serv_frontal);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na atualização de tipo de serviços... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.tipo_serv tipo_serv)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from tipo_serv where idTipo_serv=@idTipo_serv;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idTipo_serv", tipo_serv.idTipo_serv);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na remoção de tipo de serviços ... ");
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
