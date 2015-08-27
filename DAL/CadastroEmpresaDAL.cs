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
    public class CadastroEmpresaDAL
    {
        public void Inlcuir(ConsultaCNPJ empresa)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into cdt_empresa(cnpj, razaosocial, insestadual, nomefantasia, natjuridica, ativeconomica, logradouro, numero, cep, bairro, cidade, estado) values (@cnpj, @razaosocial, @insestadual, @nomefantasia, @natjuridica, @ativeconomica, @logradouro, @numero, @cep, @bairro, @cidade, @estado); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                cmd.Parameters.AddWithValue("@razaosocial", empresa.RazaoSocial);
                cmd.Parameters.AddWithValue("@insestadual", empresa.IncEstadual);
                cmd.Parameters.AddWithValue("@nomefantasia", empresa.NomeFantasia);
                cmd.Parameters.AddWithValue("@natjuridica", empresa.NaturezaJuridica);
                cmd.Parameters.AddWithValue("@ativeconomica", empresa.AtividadeEconomicaPrimaria);
                cmd.Parameters.AddWithValue("@logradouro", empresa.Endereco);
                cmd.Parameters.AddWithValue("@numero", empresa.Numero);
                cmd.Parameters.AddWithValue("@cep", empresa.Cep);
                cmd.Parameters.AddWithValue("@bairro", empresa.Bairro);
                cmd.Parameters.AddWithValue("@cidade", empresa.Cidade);
                cmd.Parameters.AddWithValue("@estado", empresa.Estado);
                cn.Open();
                cmd.ExecuteScalar();
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

        public ConsultaCNPJ Pesquisa (ConsultaCNPJ empresa)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT COUNT(cnpj) FROM cdt_empresa WHERE cnpj = @cnpj";
                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = empresa.Cnpj;
                cn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    empresa.Auxpesquisa = false;
                    
                }
                else
                {
                    empresa.Auxpesquisa = true;
                }

                return empresa;

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

        public ConsultaCNPJ RetornoCNPJ(ConsultaCNPJ empresa)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select id_empresa, cnpj, razaosocial, insestadual, nomefantasia, natjuridica, ativeconomica, logradouro, numero, cep, bairro, cidade, estado from cdt_empresa WHERE cnpj = @cnpj";
                cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                cn.Open();
                //instância do leitor


                //enquanto leitor lê 
                SqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    //passo os valores para o objeto cliente 

                    //que será retornado 
                    empresa.Id_empresa = Convert.ToInt32(leitor["id_empresa"].ToString());
                    empresa.Cnpj = leitor["cnpj"].ToString();
                    empresa.RazaoSocial = leitor["razaosocial"].ToString();
                    empresa.IncEstadual = leitor["insestadual"].ToString();
                    empresa.NomeFantasia = leitor["nomefantasia"].ToString();
                    empresa.NaturezaJuridica = leitor["natjuridica"].ToString();
                    empresa.AtividadeEconomicaPrimaria = leitor["ativeconomica"].ToString();
                    empresa.Endereco = leitor["logradouro"].ToString();
                    empresa.Numero = leitor["numero"].ToString();
                    empresa.Cep = leitor["cep"].ToString();
                    empresa.Bairro = leitor["bairro"].ToString();
                    empresa.Cidade = leitor["cidade"].ToString();
                    empresa.Estado = leitor["estado"].ToString();
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
            return empresa;
        }

        }
}
