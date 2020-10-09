using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class veiculo
    {
        private string strCon = Conexao.getConexao();

        public List<Model.veiculo> Select()
        {
            List < Model.veiculo> ListaVeiculo = new List<Model.veiculo>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from veiculo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.veiculo veiculo = new Model.veiculo();
                    veiculo.idVeiculo = Convert.ToInt32(reader[0].ToString());
                    veiculo.idCiente = Convert.ToInt32(reader["idCliente"].ToString());
                    veiculo.nome = reader["nome"].ToString();
                    veiculo.modelo = reader["modelo"].ToString();
                    veiculo.chassi = reader["chassi"].ToString();
                    veiculo.ano = reader["ano"].ToString();
                    veiculo.placa = reader["placa"].ToString();
                    ListaVeiculo.Add(veiculo);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de Veiculos ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaVeiculo;
        }

        public void Insert(Model.veiculo veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into veiculo values (@idCliente, @nome, @modelo, @chassi, @ano, @placa)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", veiculo.idCiente);
            cmd.Parameters.AddWithValue("@nome", veiculo.nome);
            cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
            cmd.Parameters.AddWithValue("@chassi", veiculo.chassi);
            cmd.Parameters.AddWithValue("@ano", veiculo.ano);
            cmd.Parameters.AddWithValue("@placa", veiculo.placa);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na inserção de veiculos ... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.veiculo veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update veiculo set idCliente=@idCliente,";
            sql += "nome=@nome, modelo=@modelo,";
            sql += "chassi=@chassi, ano=@ano,";
            sql += "placa=@placa";
            sql += " where idVeiculo=@idVeiculo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVeiculo", veiculo.idVeiculo);
            cmd.Parameters.AddWithValue("@idCliente", veiculo.idCiente);
            cmd.Parameters.AddWithValue("@nome", veiculo.nome);
            cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
            cmd.Parameters.AddWithValue("@chassi", veiculo.chassi);
            cmd.Parameters.AddWithValue("@ano", veiculo.ano);
            cmd.Parameters.AddWithValue("@placa", veiculo.placa);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de veiculos ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.veiculo veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from veiculo where idVeiculo=@idVeiculo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVeiculo", veiculo.idVeiculo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de  ... ");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
