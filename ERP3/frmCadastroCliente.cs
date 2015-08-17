using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NORD.BLL;
using NORD.DAL;
using NORD.Modelos;

namespace ERP3
{
    public partial class frmCadastroCliente : Form
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

        public frmCadastroCliente()
        {
            InitializeComponent();
            this.UpdateTextPosition();
        }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_InserirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroCliente cliente = new CadastroCliente();
                cliente.Nome = tb_nome.Text;
                cliente.Email = tb_email.Text;
                cliente.Telefone = tb_telefone.Text;
                cliente.Empresa = cb_empresa.Text;
                CadastroClienteBLL obj = new CadastroClienteBLL();
                obj.Incluir(cliente);
                MessageBox.Show("O cliente foi incluído com sucesso!");
                this.Close();
                //tb_codigocliente.Text = Convert.ToString(cliente.Id_cliente);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroClienteEmpresa.cdt_empresas'. Você pode movê-la ou removê-la conforme necessário.
            this.cdt_empresasTableAdapter.Fill(this.cadastroClienteEmpresa.cdt_empresas);

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
