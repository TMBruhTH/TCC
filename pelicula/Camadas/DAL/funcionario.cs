using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class funcionario
    {
        private string strCon = Conexao.getConexao();

        public List<Model.funcionario> Select()
        {
            List<Model.funcionario> ListaFuncionario = new List<Model.funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from funcionario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.funcionario funcionario = new Model.funcionario();
                    funcionario.idFuncionario = Convert.ToInt32(reader[0].ToString());
                    funcionario.nome = reader["nome"].ToString();
                    funcionario.email = reader["email"].ToString();
                    funcionario.rg = reader["rg"].ToString();
                    funcionario.cpf = reader["cpf"].ToString();
                    funcionario.endereco = reader["endereco"].ToString();
                    funcionario.nr = reader["nr"].ToString();
                    funcionario.cep = reader["cep"].ToString();
                    funcionario.admissao = reader["admissao"].ToString();
                    funcionario.cidade = reader["cidade"].ToString();
                    funcionario.estado = reader["estado"].ToString();
                    ListaFuncionario.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de funcionarios ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaFuncionario;
        }

        public void Insert(Model.funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into funcionario values(@nome, @email, @rg, @cpf, @endereco, @nr, @cep, @admissao, @cidade, @estado)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@email", funcionario.email);
            cmd.Parameters.AddWithValue("@rg", funcionario.rg);
            cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
            cmd.Parameters.AddWithValue("@nr", funcionario.nr);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@admissao", funcionario.admissao);
            cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
            cmd.Parameters.AddWithValue("@estado", funcionario.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de funcionarios ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update funcionario set nome=@nome,";
            sql += "email=@email, rg=@rg,";
            sql += "cpf=@cpf, endereco=@endereco,";
            sql += "nr=@nr, cep=@cep,";
            sql += "admissao=@admissao, cidade=@cidade,";
            sql += "estado=@estado";
            sql += " where idFuncionario=@idFuncionario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFuncionario", funcionario.idFuncionario);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@email", funcionario.email);
            cmd.Parameters.AddWithValue("@rg", funcionario.rg);
            cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
            cmd.Parameters.AddWithValue("@nr", funcionario.nr);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@admissao", funcionario.admissao);
            cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
            cmd.Parameters.AddWithValue("@estado", funcionario.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de funcionarios ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.funcionario funcioario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from funcionario where idFuncionario=@idFuncionario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFuncionario", funcioario.idFuncionario);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de funcionario ... ");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
