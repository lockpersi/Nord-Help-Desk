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
        //variaveis
        public static string tmpCnpj;
       // ConsultaCNPJ empresa = new ConsultaCNPJ();

        public frmCadastroEmpresa()
        {
            
            InitializeComponent();
      
        }

        public void LimparControles()
        {
            this.LimparControles(this);
        }

        public void LimparControles(Control parent)
        {
            foreach (Control cont in parent.Controls)
            {
                if (cont is TextBox)
                    (cont as TextBox).Text = "";
                if (cont is ComboBox)
                    (cont as ComboBox).Text = "";
                if (cont is MaskedTextBox)
                    (cont as MaskedTextBox).Text = "";
                if (cont is RadioButton)
                    (cont as RadioButton).Checked = false;
                if (cont is CheckedListBox)
                {
                    foreach (ListControl item in (cont as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
                if (cont is ListView)
                    (cont as ListView).Items.Clear();

                // varre os filhos...
                this.LimparControles(cont);
            }
        }

        public void ReadOnlyTrue()
        {
            this.ReadOnlyTrue(this);
        }

        public void ReadOnlyTrue(Control parent)
        {
            foreach (Control cont in parent.Controls)
            {
                if (cont is TextBox)
                    (cont as TextBox).ReadOnly = true;
                if (cont is CheckedListBox)
                {
                    foreach (ListControl item in (cont as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
                if (cont is ListView)
                    (cont as ListView).Items.Clear();

                // varre os filhos...
                this.ReadOnlyTrue(cont);
            }
        }

        public void ReadOnlyFalse()
        {
            this.ReadOnlyFalse(this);
        }

        public void ReadOnlyFalse(Control parent)
        {
            foreach (Control cont in parent.Controls)
            {
                if (cont is TextBox)
                    (cont as TextBox).ReadOnly = false;
                if (cont is CheckedListBox)
                {
                    foreach (ListControl item in (cont as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
                if (cont is ListView)
                    (cont as ListView).Items.Clear();

                // varre os filhos...
                this.ReadOnlyFalse(cont);
            }
        }

        public void pb_pesquisa2_Click(object sender, EventArgs e)
        {
            try {
                string tmp1 = tb_cnpj.Text;
                string tmp2 = tmp1;
                tmp1 = String.Format((@"{0:00\.000\.000\/0000\-00}"), Convert.ToInt64(tmp1));
                ConsultaCNPJ empresa = new ConsultaCNPJ();
                empresa.Auxpesquisa = true;
                empresa.Cnpj = tmp1.ToString();
                CadastroEmpresaBLL obj = new CadastroEmpresaBLL();
                obj.Pesquisar(empresa);
              

                if (empresa.Auxpesquisa)
                {
                    DialogResult confirm = MessageBox.Show("Não foi encontrado registro para esse CNPJ, deseja cadastrar?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        empresa.Cnpj = tmp2.ToString();
                        frmConsultaReceita obj1 = new frmConsultaReceita();
                        obj1.ShowDialog();
                    }
                }
                else
                {
                    
                        obj.RetornoCNPJ(empresa);
                    
                    
                }
                pesquisaRetornoNovo();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pesquisaRetornoNovo()
        {
            if(ConsultaCNPJ.auxpesquisa == false)
            {
                tb_codigo.Text = ConsultaCNPJ._id_empresa.ToString();
            }
            //tb_cnpj.Text = ConsultaCNPJ._cnpj;
            tb_razaosocial.Text = ConsultaCNPJ._razaoSocial;
            tb_insEstadual.Text = ConsultaCNPJ._incEstadual;
            tb_nomeFantasia.Text = ConsultaCNPJ._nomefantasia;
            tb_naturezajuridica.Text = ConsultaCNPJ._NaturezaJuridica;
            tb_atividadeeconomica.Text = ConsultaCNPJ._AtividadeEconomicaPrimaria;
            tb_endereco.Text = ConsultaCNPJ._endereco;
            tb_numero.Text = ConsultaCNPJ._numero;
            tb_cep.Text = ConsultaCNPJ._cep;
            tb_bairro.Text = ConsultaCNPJ._bairro;
            tb_cidade.Text = ConsultaCNPJ._cidade;
            tb_estado.Text = ConsultaCNPJ._estado;

            ReadOnlyTrue();
        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
           // tb_cnpj. = CadastroEmpresaBLL.MascaraCnpjCpf(tb_cnpj.Text);
        }

        private void tsb_novo_Click(object sender, EventArgs e)
        {
            LimparControles();
            ReadOnlyFalse();
            tb_codigo.ReadOnly = true;
        }

        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))

            {

                e.Handled = true;

            }
        }

        private void tb_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))

            {

                e.Handled = true;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaCNPJ empresa = new ConsultaCNPJ();
                string tpm1 = tb_cnpj.Text;
                tpm1 = String.Format((@"{0:00\.000\.000\/0000\-00}"), Convert.ToInt64(tpm1));
                empresa.Cnpj = tpm1.ToString();
                empresa.RazaoSocial = tb_razaosocial.Text;
                empresa.IncEstadual = tb_insEstadual.Text;
                empresa.NomeFantasia = tb_nomeFantasia.Text;
                empresa.NaturezaJuridica = tb_naturezajuridica.Text;
                empresa.AtividadeEconomicaPrimaria = tb_atividadeeconomica.Text;
                empresa.Endereco = tb_endereco.Text;
                empresa.Numero = tb_numero.Text;
                empresa.Cep = tb_cep.Text;
                empresa.Bairro = tb_bairro.Text;
                empresa.Cidade = tb_cidade.Text;
                empresa.Estado = tb_estado.Text;
                CadastroEmpresaBLL obj = new CadastroEmpresaBLL();
                obj.Incluir(empresa);
                MessageBox.Show("A empresa foi cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tb_cnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pb_pesquisa2_Click(sender, e);
            }
        }
    }
}
