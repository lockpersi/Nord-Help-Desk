using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NORD.Modelos;
using System.Data;

namespace NORD.DAL
{

    public class LoginDAL
   {
     

        public void logar(Login login)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT COUNT(id_usuario)FROM mnt_usuarios WHERE usuario = @usuario AND senha = @senha";
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = login.Usu;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = login.Pwd;
                cn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    //MessageBox.Show("Logado com sucesso!");
          
                    login.Logado = true;
                    string sql = "select ativo from mnt_usuarios WHERE usuario = @usuarios";
                    SqlCommand cmd1 = new SqlCommand(sql, cn);
                    cmd1.Parameters.Add("@usuarios", SqlDbType.VarChar).Value = login.Usu;

                    login.Ativo = cmd1.ExecuteScalar().ToString();
                                                
                }
                else
                {
                    //MessageBox.Show("Erro ao logar, verifique seu login e senha !!");
                    login.Logado = false;
                    throw new Exception("Login ou Senha incorretos !");
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
    }
}
