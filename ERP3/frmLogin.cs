using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NORD.Modelos;

namespace ERP3
{
    public partial class frmLogin : Form
    {
        private void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }

        SqlConnection SqlConn = null;
        private string strConn = @"Data Source=SQL5016.Smarterasp.net;Initial Catalog=DB_9D62CD_nord;User ID=DB_9D62CD_nord_admin;Password=1598741a";
        private string _Sql = string.Empty;


        public bool logado = false;
        public string usuario;
        public int ativo;

        public frmLogin()
        {
            InitializeComponent();
            UpdateTextPosition();
        }

        public void logar()
        {
      
            string usu, pwd;

            SqlConn = new SqlConnection(strConn);
            try
            {
                usu = tb_usuario.Text;
                pwd = tb_senha.Text;

                _Sql = "SELECT COUNT(id_usuario) FROM mnt_usuarios WHERE usuario = @usuario AND senha = @senha";

                SqlCommand cmd = new SqlCommand(_Sql, SqlConn);

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;

                SqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    //MessageBox.Show("Logado com sucesso!");
                    SqlConn.Close();
                    logado = true;
                    string sql = "select ativo from mnt_usuarios WHERE usuario = @usuario";
                    SqlCommand cmd1 = new SqlCommand(sql, SqlConn);
                    cmd1.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
                    SqlConn.Open();

                    ativo = c ;
                    usuario = usu;
                    usuario = usuario.ToUpper();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Erro ao logar, verifique seu login e senha !!");
                    logado = false;
           
                }

            }
            catch (SqlException erooo)
            {
                MessageBox.Show(erooo+"No banco");
            }
        }
       
        private void tb_senha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }

        private void bt_logar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
