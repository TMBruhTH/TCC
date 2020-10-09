using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class fornecedor
    {
        private string strCon = Conexao.getConexao();

        public List<Model.fornecedor> Select()
        {
            List<Model.fornecedor> ListaFornecedor = new List<Model.fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from fornecedor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.fornecedor fornecedor = new Model.fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(reader[0].ToString());
                    fornecedor.razao_social = reader["razao_social"].ToString();
                    fornecedor.email = reader["email"].ToString();
                    fornecedor.cnpj = reader["cnpj"].ToString();
                    fornecedor.endereco = reader["endereco"].ToString();
                    fornecedor.nr = reader["nr"].ToString();
                    fornecedor.iestadual = reader["iestadual"].ToString();
                    fornecedor.imunicipal = reader["imunicipal"].ToString();
                    fornecedor.cidade = reader["cidade"].ToString();
                    fornecedor.estado = reader["estado"].ToString();
                    fornecedor.telefone = reader["telefone"].ToString();
                    ListaFornecedor.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de fornecedores ... ");
            }
            finally
            {
                conexao.Close();
            }
            return ListaFornecedor;
        }

        public void Insert(Model.fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into fornecedor values (@razao_social, @email, @cnpj, @endereco, @nr, @iestadual, @imunicipal, @cidade, @estado, @telefone)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@razao_social", fornecedor.razao_social);
            cmd.Parameters.AddWithValue("@email", fornecedor.email);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@nr", fornecedor.nr);
            cmd.Parameters.AddWithValue("@iestadual", fornecedor.iestadual);
            cmd.Parameters.AddWithValue("@imunicipal", fornecedor.imunicipal);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("@estado", fornecedor.estado);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.telefone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de fornecedores ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update fornecedor set razao_social=@razao_social,";
            sql += "email=@email, cnpj=@cnpj,";
            sql += "endereco=@endereco, nr=@nr,";
            sql += "iestadual=@iestadual, imunicipal=@imunicipal,";
            sql += "cidade=@cidade, estado=@estado,";
            sql += "telefone=@telefone";
            sql += " where idFornecedor=@idFornecedor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.idFornecedor);
            cmd.Parameters.AddWithValue("@razao_social", fornecedor.razao_social);
            cmd.Parameters.AddWithValue("@email", fornecedor.email);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@nr", fornecedor.nr);
            cmd.Parameters.AddWithValue("@iestadual", fornecedor.iestadual);
            cmd.Parameters.AddWithValue("@imunicipal", fornecedor.imunicipal);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("@estado", fornecedor.estado);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.telefone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de fornecedores ... ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from fornecedor where idFornecedor=@idFornecedor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.idFornecedor);
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
