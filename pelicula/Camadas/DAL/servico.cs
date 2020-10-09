using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelicula.Camadas.DAL
{
    public class servico
    {
        private string strCon = Conexao.getConexao();

        public List<Model.servico> Select()
        {
            List<Model.servico> ListaServico = new List<Model.servico>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from servico;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.servico servico = new Model.servico();
                    servico.idServico = Convert.ToInt32(reader[0].ToString());
                    servico.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    servico.idVeiculo = Convert.ToInt32(reader["idVeiculo"].ToString());
                    servico.idProduto = Convert.ToInt32(reader["idProduto"].ToString());
                    servico.idFuncionario = Convert.ToInt32(reader["idFuncionario"].ToString());
                    servico.tipo = reader["tipo"].ToString();
                    servico.serv_lateral = reader["serv_lateral"].ToString();
                    servico.serv_frontal = reader["serv_frontal"].ToString();
                    servico.valor = Convert.ToDouble(reader["valor"].ToString());
                    servico.status = reader["status"].ToString();
                    ListaServico.Add(servico);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de serviços ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaServico;
        }

        public void Insert(Model.servico servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into servico values (@idCliente, @idVeiculo, @idProduto, @idFuncionario, @tipo, @serv_lateral, @serv_frontal, @valor, @status)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", servico.idCliente);
            cmd.Parameters.AddWithValue("@idVeiculo", servico.idVeiculo);
            cmd.Parameters.AddWithValue("@idProduto", servico.idProduto);
            cmd.Parameters.AddWithValue("@idFuncionario", servico.idFuncionario);
            //cmd.Parameters.AddWithValue("@idTipo_prod", servico.idTipo_prod);
            //cmd.Parameters.AddWithValue("@idTipo_serv", servico.idTipo_serv);
            cmd.Parameters.AddWithValue("@tipo", servico.tipo);
            cmd.Parameters.AddWithValue("@serv_lateral", servico.serv_lateral);
            cmd.Parameters.AddWithValue("@serv_frontal", servico.serv_frontal);
            cmd.Parameters.AddWithValue("@valor", servico.valor);
            cmd.Parameters.AddWithValue("@status", servico.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                MessageBox.Show("Erro em aprovar orçamentos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine("Deu erro na inserção de serviços ... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.servico servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update servico set idCliente=@idCliente,";
            sql += "idVeiculo=@idVeiculo, idProduto=@idProduto,";
            sql += "idFuncionario=@idFuncionario, tipo=@tipo,";
            sql += "serv_lateral=@serv_lateral, serv_frontal=@serv_frontal,";
            sql += "valor=@valor, status=@status";
            sql += " where idServico=@idServico;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idServico", servico.idServico);
            cmd.Parameters.AddWithValue("@idCliente", servico.idCliente);
            cmd.Parameters.AddWithValue("@idVeiculo", servico.idVeiculo);
            cmd.Parameters.AddWithValue("@idProduto", servico.idProduto);
            cmd.Parameters.AddWithValue("@idFuncionario", servico.idFuncionario);
            //cmd.Parameters.AddWithValue("@idTipo_prod", servico.idTipo_prod);
            //cmd.Parameters.AddWithValue("@idTipo_serv", servico.idTipo_serv);
            cmd.Parameters.AddWithValue("@tipo", servico.tipo);
            cmd.Parameters.AddWithValue("@serv_lateral", servico.serv_lateral);
            cmd.Parameters.AddWithValue("@serv_frontal", servico.serv_frontal);
            cmd.Parameters.AddWithValue("@valor", servico.valor);
            cmd.Parameters.AddWithValue("@status", servico.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de serviços ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Pre(Model.servico servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update servico set idCliente=@idCliente,";
            sql += "valor=@valor, status=@status";
            sql += " where idServico=@idServico;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idServico", servico.idServico);
            cmd.Parameters.AddWithValue("@idCliente", servico.idCliente);
            cmd.Parameters.AddWithValue("@valor", servico.valor);
            cmd.Parameters.AddWithValue("@status", servico.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de serviços ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.servico servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from servico where idServico=@idServico;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idServico", servico.idServico);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na remoção de serviços ... ");
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
