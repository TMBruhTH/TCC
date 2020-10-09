using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class orcamento
    {
        private string strCon = Conexao.getConexao();

        public List<Model.orcamento> Select()
        {
            List<Model.orcamento> ListaOrcamento = new List<Model.orcamento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from orcamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.orcamento orcamento = new Model.orcamento();
                    orcamento.idOrcamento = Convert.ToInt32(reader[0].ToString());
                    orcamento.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    orcamento.idVeiculo = Convert.ToInt32(reader["idVeiculo"].ToString());
                    orcamento.idProduto = Convert.ToInt32(reader["idProduto"].ToString());
                    //orcamento.idTipo_prod = Convert.ToInt32(reader["idTipo_prod"].ToString());
                    //orcamento.idTipo_serv = Convert.ToInt32(reader["idTipo_serv"].ToString());
                    orcamento.idFuncionario = Convert.ToInt32(reader["idFuncionario"].ToString());
                    orcamento.tipo = reader["tipo"].ToString();
                    orcamento.serv_lateral = reader["serv_lateral"].ToString();
                    orcamento.serv_frontal = reader["serv_frontal"].ToString();
                    orcamento.valor = Convert.ToDouble(reader["valor"].ToString());
                    orcamento.status = reader["status"].ToString();
                    ListaOrcamento.Add(orcamento);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de orçamentos ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaOrcamento;
        }

        public void Insert(Model.orcamento orcamento)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into orcamento values(@idCliente, @idVeiculo, @idProduto, @idFuncionario, @tipo, @serv_lateral, @serv_frontal, @valor, @status)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", orcamento.idCliente);
            cmd.Parameters.AddWithValue("@idVeiculo", orcamento.idVeiculo);
            cmd.Parameters.AddWithValue("@idProduto", orcamento.idProduto);
            //cmd.Parameters.AddWithValue("@idTipo_prod", orcamento.idTipo_prod);
            //cmd.Parameters.AddWithValue("@idTipo_serv", orcamento.idTipo_serv);
            cmd.Parameters.AddWithValue("@idFuncionario", orcamento.idFuncionario);
            cmd.Parameters.AddWithValue("@tipo", orcamento.tipo);
            cmd.Parameters.AddWithValue("@serv_lateral", orcamento.serv_lateral);
            cmd.Parameters.AddWithValue("@serv_frontal", orcamento.serv_frontal);
            cmd.Parameters.AddWithValue("@valor", orcamento.valor);
            cmd.Parameters.AddWithValue("@status", orcamento.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na inserção de orçamentos ... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.orcamento orcamento)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update orcamento set idCliente=@idCliente,";
            sql += "idVeiculo=@idVeiculo, idProduto=@idProduto,";
            sql += "idFuncionario=@idFuncionario, tipo=@tipo,";
            sql += "serv_lateral=@serv_lateral, serv_frontal=@serv_frontal,";
            sql += "valor=@valor, status=@status";
            sql += " where idOrcamento=@idOrcamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idOrcamento", orcamento.idOrcamento);
            cmd.Parameters.AddWithValue("@idCliente", orcamento.idCliente);
            cmd.Parameters.AddWithValue("@idVeiculo", orcamento.idVeiculo);
            cmd.Parameters.AddWithValue("@idProduto", orcamento.idProduto);
            //cmd.Parameters.AddWithValue("@idTipo_prod", orcamento.idTipo_prod);
            //cmd.Parameters.AddWithValue("@idTipo_serv", orcamento.idTipo_serv);
            cmd.Parameters.AddWithValue("@idFuncionario", orcamento.idFuncionario);
            cmd.Parameters.AddWithValue("@tipo", orcamento.tipo);
            cmd.Parameters.AddWithValue("@serv_lateral", orcamento.serv_lateral);
            cmd.Parameters.AddWithValue("@serv_frontal", orcamento.serv_frontal);
            cmd.Parameters.AddWithValue("@valor", orcamento.valor);
            cmd.Parameters.AddWithValue("@status", orcamento.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na atualização de orçamentos... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.orcamento orcamento)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from orcamento where idOrcamento=@idOrcamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idOrcamento", orcamento.idOrcamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na remoção de orçamentos ... ");
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
