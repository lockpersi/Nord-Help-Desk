using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using NORD.Modelos;

namespace NORD.DAL
{
    public class ControleVendasDAL
    {
        public DataTable ListaDeProdutos
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from cdt_produtos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        //Propriedade que retorna uma Lista de Clientes
        public DataTable ListaDeClientes
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from cdt_clientes", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        public void Incluir(ControleVenda venda)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            SqlTransaction t = null;
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = cn;
                cmd1.CommandText = @"insert into ctl_vendas
(id_cliente,
id_produto,
data,
quantidade,
faturado)
VALUES
(@id_cliente,
@id_produto,
@data,
@quantidade,
@faturado);select @@IDENTITY;";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = cn;
                cmd2.CommandText = @"Update cdt_produtos
Set estoque = estoque - @Quantidade
Where id_produto=@id_produto";
                cn.Open();
                t = cn.BeginTransaction(IsolationLevel.Serializable);//default
                cmd1.Transaction = t;
                cmd2.Transaction = t;
                cmd1.Parameters.AddWithValue("@id_cliente", venda.Id_Cliente);
                cmd1.Parameters.AddWithValue("@id_produto", venda.Id_Produto);
                cmd1.Parameters.AddWithValue("@data", venda.Data);
                cmd1.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                cmd1.Parameters.AddWithValue("@faturado", venda.Faturado);
                cmd2.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                cmd2.Parameters.AddWithValue("@id_produto", venda.Id_Produto);
                venda.Id_venda = Convert.ToInt32(cmd1.ExecuteScalar());
                cmd2.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                throw new Exception("Servidor no Servidor:" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
