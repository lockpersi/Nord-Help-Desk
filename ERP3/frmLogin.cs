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
using NORD.BLL;

namespace ERP3
{
    public partial class frmLogin : Form
    {
        public bool logado = false;
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
        

        public string ativo;

        public frmLogin()
        {
            try {
                InitializeComponent();
                UpdateTextPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void logar()
        {

            try
            {
                Login login = new Login();
                login.Usu = tb_usuario.Text;
                login.Pwd = tb_senha.Text;
                LoginBLL LoginBLL = new LoginBLL();
                LoginBLL.validar(login);
                logado = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    frmInserirSenha frmInserirSenha = new frmInserirSenha();
                    frmInserirSenha.ShowDialog();
                    break;

            }
        }
    }
}
