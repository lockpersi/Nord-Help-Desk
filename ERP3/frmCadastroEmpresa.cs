using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NORD.Modelos;
using NORD.BLL;

namespace ERP3
{
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void pb_pesquisa2_Click(object sender, EventArgs e)
        {
            frmConsultaReceita obj = new frmConsultaReceita();
            obj.ShowDialog();
        }

        public void pesquisaRetornoNovo(ConsultaCNPJ empresa)
        {
            tb_codigo.ReadOnly = true;
            tb_cnpj.Text = empresa.Cnpj;
        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
           // tb_cnpj. = CadastroEmpresaBLL.MascaraCnpjCpf(tb_cnpj.Text);
        }
    }
}
