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
        
        public frmInserirSenha()
        {
            InitializeComponent();
        }

        private void bt_inserirsenha_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaLicenca atualiza = new AtualizaLicenca();
                atualiza.Codigo = tb_senhaserial.Text;
                atualiza.Tempo = tb_tempo.Text;
                AtualizaLicencaBLL atualizabll = new AtualizaLicencaBLL();
                atualizabll.validar(atualiza);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_senhaserial_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInserirSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
