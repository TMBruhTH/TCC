using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class cliente
    {
        private string strCon = Conexao.getConexao();

        public List<Model.cliente> Select()
        {
            List < Model.cliente> ListaCliente = new List<Model.cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.cliente cliente = new Model.cliente();
                    cliente.idCliente = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.nr = reader["nr"].ToString();
                    cliente.cpf = reader["cpf"].ToString();
                    cliente.rg = reader["rg"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    ListaCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de clientes ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaCliente;
        }

        public void Insert(Model.cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into cliente values (@nome, @email, @endereco, @cep, @nr, @cpf, @rg, @telefone, @cidade, @estado)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@nr", cliente.nr);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("Deu erro na inserção de clientes ... ");
            }

            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update cliente set nome=@nome,";
            sql += "email=@email, endereco=@endereco,";
            sql += "cep=@cep, nr=@nr,";
            sql += "cpf=@cpf, rg=@rg,";
            sql += "telefone=@telefone, cidade=@cidade,";
            sql += "estado=@estado";
            sql += " where idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@nr", cliente.nr);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de clientes .... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from cliente where idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de clientes ... ");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
