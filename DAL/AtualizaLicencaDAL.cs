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
   public class AtualizaLicencaDAL
    {
        public void atualiza(AtualizaLicenca atualiza)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.StringDeConexao;
            SqlCommand cmd = new SqlCommand();
            //dados
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cdt_clientes set nome = @nome, email = @email, telefone = @telefone, empresa = @empresa where id_cliente = @id_cliente;";




        }
    }
}
