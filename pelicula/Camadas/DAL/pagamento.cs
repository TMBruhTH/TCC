using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class pagamento
    {
        private string strCon = Conexao.getConexao();

        public List<Model.pagamento> Select()
        {
            List<Model.pagamento> ListaPagamento = new List<Model.pagamento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from pagamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.pagamento pgt = new Model.pagamento();
                    pgt.idPagamento = Convert.ToInt32(reader[0].ToString());
                    pgt.desc_pagamento = reader["desc_pagamento"].ToString();
                    ListaPagamento.Add(pgt);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução de pagamentos ...");
            }
            finally
            {
                conexao.Close();
            }
            return ListaPagamento;
        }

        public void Insert(Model.pagamento pgt)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into pagamento values (@desc_pagamento)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc_pagamento", pgt.desc_pagamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de pagamentos ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.pagamento pgt)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update pagamento set desc_pagamento=@desc_pagamento";
            sql += " where idPagamento=@idPagamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPagamento", pgt.idPagamento);
            cmd.Parameters.AddWithValue("@desc_pagamento", pgt.desc_pagamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de pagamentos ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.pagamento pgt)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from pagamento where idPagamento=@idPagamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPagamento", pgt.idPagamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de pagamentos ...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

