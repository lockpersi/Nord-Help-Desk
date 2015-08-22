using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NORD.Modelos;

namespace NORD.DAL
{
    public class CadastroClientesDAL
    {

        public void Incluir(CadastroCliente cliente)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into cdt_clientes(nome,email,telefone,empresa) values (@nome,@email,@telefone,@empresa); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@empresa", cliente.Empresa);
                cn.Open();
                cliente.Id_cliente = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
           
        }
        public void Alterar(CadastroCliente cliente)
        {
            // conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update cdt_clientes set nome = @nome, email = @email, telefone = @telefone, empresa = @empresa where id_cliente = @id_cliente;";
                cmd.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@empresa", cliente.Empresa);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int id_cliente)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from cdt_clientes where id_cliente = " + id_cliente;
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente " + id_cliente);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        
        public DataTable Listagem()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from cdt_clientes", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }

        public CadastroCliente Pesquisar(CadastroCliente cliente)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select id_cliente, nome, empresa from cdt_clientes where id_cliente = @id_cliente";
                cmd.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                cn.Open();
                //instância do leitor
                 
                SqlDataReader leitor = cmd.ExecuteReader();

                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //passo os valores para o objeto cliente 
                    //que será retornado 
                    cliente.Id_cliente = Convert.ToInt32(leitor["id_cliente"].ToString());
                    cliente.Nome = leitor["nome"].ToString();
                    cliente.Empresa = leitor["empresa"].ToString();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return cliente;
        }
    }
}
