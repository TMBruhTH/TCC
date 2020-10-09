using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pelicula.Camadas.DAL
{
    public class caixa
    {
        private string strCon = Conexao.getConexao();

        public List<Model.caixa> Select()
        {
            List<Model.caixa> ListaCaixa = new List<Model.caixa>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from caixa;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.caixa caixa = new Model.caixa();
                    caixa.idCaixa = Convert.ToInt32(reader[0].ToString());
                    caixa.idServico = Convert.ToInt32(reader["idServico"].ToString());
                    caixa.cliente = Convert.ToInt32(reader["cliente"].ToString());
                    caixa.valor = Convert.ToDouble(reader["valor"].ToString());
                    caixa.parcela = reader["parcela"].ToString();
                    //caixa.tipoParcela = reader["tipoParcela"].ToString();
                    caixa.dataPagamento = reader["dataPagamento"].ToString();
                    caixa.status = reader["status"].ToString();
                    ListaCaixa.Add(caixa);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção do Caixa ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaCaixa;
        }

        public void Insert(Model.caixa caixa)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into caixa values (@idServico, @cliente, @valor, @parcela, @dataPagamento, @status)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idServico", caixa.idServico);
            cmd.Parameters.AddWithValue("@cliente", caixa.cliente);
            cmd.Parameters.AddWithValue("@valor", caixa.valor);
            cmd.Parameters.AddWithValue("@parcela", caixa.parcela);
            //cmd.Parameters.AddWithValue("@tipoParcela", caixa.tipoParcela);
            cmd.Parameters.AddWithValue("@dataPagamento", caixa.dataPagamento);
            cmd.Parameters.AddWithValue("@status", caixa.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro no pré serviço ... ", "Informação", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                //Console.WriteLine("Deu erro na inserção do caixa ... ");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void PreSrvCaixa(Model.caixa caixa)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into caixa values (@idServico, @cliente, @valor, NULL, NULL, @status)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idServico", caixa.idServico);
            cmd.Parameters.AddWithValue("@cliente", caixa.cliente);
            cmd.Parameters.AddWithValue("@valor", caixa.valor);
            cmd.Parameters.AddWithValue("@status", caixa.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro no pré serviço caixa ... ", "Informação", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                //Console.WriteLine("Deu erro na inserção do caixa ... ");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update(Model.caixa caixa)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update caixa set idServico=@idServico,";
            sql += "cliente=@cliente, valor=@valor,";
            sql += "parcela=@parcela, dataPagamento=@dataPagamento,";
            sql += "status=@status";
            sql += " where idCaixa=@idCaixa;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCaixa", caixa.idCaixa);
            cmd.Parameters.AddWithValue("@idServico", caixa.idServico);
            cmd.Parameters.AddWithValue("@cliente", caixa.cliente);
            cmd.Parameters.AddWithValue("@valor", caixa.valor);
            cmd.Parameters.AddWithValue("@parcela", caixa.parcela);
            //cmd.Parameters.AddWithValue("@tipoParcela", caixa.tipoParcela);
            cmd.Parameters.AddWithValue("@dataPagamento", caixa.dataPagamento);
            cmd.Parameters.AddWithValue("@status", caixa.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização do caixa ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.caixa caixa)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from caixa where idCaixa=@idCaixa;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCaixa", caixa.idCaixa);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção do caixa ... ");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
