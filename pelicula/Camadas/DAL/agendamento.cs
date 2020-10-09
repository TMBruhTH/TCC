using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class agendamento
    {
        private string strCon = Conexao.getConexao();

        public List<Model.agendamento> Select()
        {
            List<Model.agendamento> ListaAgenda = new List<Model.agendamento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from agendamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.agendamento agenda = new Model.agendamento();
                    agenda.idAgendamento = Convert.ToInt32(reader[0].ToString());
                    agenda.cliente = reader["cliente"].ToString();
                    agenda.data = reader["data"].ToString();
                    ListaAgenda.Add(agenda);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução de agendamentos ...");
            }
            finally
            {
                conexao.Close();
            }
            return ListaAgenda;
        }

        public void Insert(Model.agendamento agenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into agendamento values (@cliente, @data)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", agenda.cliente);
            cmd.Parameters.AddWithValue("@data", agenda.data);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de agendamentos ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.agendamento agenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update agendamento set cliente=@cliente,";
            sql += "data=@data";
            sql += " where idAgendamento=@idAgendamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idAgendamento", agenda.idAgendamento);
            cmd.Parameters.AddWithValue("@cliente", agenda.cliente);
            cmd.Parameters.AddWithValue("@data", agenda.data);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de agendamentos ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.agendamento agenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from agendamento where idAgendamento=@idAgendamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idAgendamento", agenda.idAgendamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de agendamentos ...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
