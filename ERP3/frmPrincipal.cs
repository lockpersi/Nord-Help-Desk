using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP3
{

    public partial class frmPrincipal : Form
    {
        public string usuario;

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

        public frmPrincipal()
        {

            InitializeComponent();
    }

    public frmPrincipal(string usu)
        {
            this.usuario = usu;
            InitializeComponent();

        }

        private void principal_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();

            flogin.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nOVOCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCadastroCliente obj = new frmCadastroCliente();
            obj.MdiParent = MdiParent;
            obj.TopLevel = true;
            obj.AutoScroll = true;
            //this.Enabled = false;
            obj.ShowDialog();

        }

        private void eMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa obj = new frmCadastroEmpresa();
            obj.MdiParent = MdiParent;
            obj.TopLevel = true;
            obj.AutoScroll = true;
            //this.Enabled = false;
            obj.ShowDialog();

        }
    }
}
