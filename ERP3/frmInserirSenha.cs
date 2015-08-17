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
using NORD.DAL;
using NORD.BLL;

namespace ERP3
{
    public partial class frmInserirSenha : Form
    {

        public void validar()
        {

            string ysk7y2, ysk7y1, ysk7y3, ysk7y4, ysk7y5;
            string ysk7y = DateTime.Now.Year.ToString();
            string ysk7x = DateTime.Now.DayOfWeek.ToString();
            string ysk7x1 = DateTime.Now.DayOfYear.ToString();
            int ysk7x2 = DateTime.Now.DayOfYear;
            double ysk7x3 = DateTime.Now.DayOfYear;
            double ysk7x4 = DateTime.Now.Day;
            ysk7y3 = ysk7x[0].ToString();
            ysk7y2 = ysk7y[3].ToString();
            ysk7y4 = ysk7x[2].ToString().ToUpper();
            ysk7y5 = ysk7x[4].ToString().ToUpper();
            ysk7x2 = ysk7x2 * 754 + 1000;
            ysk7x1 = ysk7x1 + ysk7x2;
            ysk7x3 = Math.Truncate(ysk7x3 * 55 / ysk7x4);
            ysk7y1 = ysk7y4 + ysk7y2 + ysk7y3 + ysk7x1 + ysk7x3 + ysk7y5;

            string codigo;

            try
            {
                AtualizaLicenca atualiza = new AtualizaLicenca();
                atualiza.Codigo = tb_senhaserial.Text;
                AtualizaLicencaBLL atualizabll = new AtualizaLicencaBLL();
                atualizabll.validar(atualiza);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public frmInserirSenha()
        {
            InitializeComponent();
        }

        private void bt_inserirsenha_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
