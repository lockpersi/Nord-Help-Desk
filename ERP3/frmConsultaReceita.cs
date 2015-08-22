using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NORD.Modelos;

namespace ERP3
{
    public partial class frmConsultaReceita : Form
    {
        
        public ConsultaCNPJ empresa;
        private ConsultaCNPJBLL consulta;
        public frmConsultaReceita()
        {
            InitializeComponent();
        }

        public void carregarCaptcha()
        {
            try {
                consulta = new ConsultaCNPJBLL();
                tb_letras.Text = "";
                tb_letras.Focus();
                Cursor cursor;
                cursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                Bitmap bit = consulta.GetCaptcha();
                if (bit != null)
                    picLetras.Image = bit;
                else
                    MessageBox.Show("Não foi possível recuperar a imagem de validação do site da Receita Federal");
                this.Cursor = cursor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private enum Coluna
        {
            RazaoSocial = 0,
            NomeFantasia,

            AtividadeEconomicaPrimaria,
            AtividadeEconomicaSecundaria,

            NumeroDaInscricao,
            MatrizFilial,
            NaturezaJuridica,

            SituacaoCadastral,
            DataSituacaoCadastral,
            MotivoSituacaoCadastral,

            EnderecoLogradouro,
            EnderecoNumero,
            EnderecoComplemento,
            EnderecoCEP,
            EnderecoBairro,
            EnderecoCidade,
            EnderecoEstado


        };

        private String RecuperaColunaValor(String pattern, Coluna col)
        {
            String S = pattern.Replace("\n", "").Replace("\t", "").Replace("\r", "");

            switch (col)
            {
                case Coluna.RazaoSocial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NOME EMPRESARIAL -->", "<!-- Fim Linha NOME EMPRESARIAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NomeFantasia:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ESTABELECIMENTO -->", "<!-- Fim Linha ESTABELECIMENTO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NaturezaJuridica:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NATUREZA JURÍDICA -->", "<!-- Fim Linha NATUREZA JURÍDICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaPrimaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA -->", "<!-- Fim Linha ATIVIDADE ECONOMICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaSecundaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA SECUNDARIA-->", "<!-- Fim Linha ATIVIDADE ECONOMICA SECUNDARIA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NumeroDaInscricao:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MatrizFilial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoLogradouro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoNumero:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoComplemento:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoCEP:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoBairro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoCidade:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoEstado:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.SituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.DataSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MotivoSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha MOTIVO DE SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha MOTIVO DE SITUAÇÃO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }

                default:
                    {
                        return S;
                    }
            }
        }

        private String StringEntreString(String Str, String StrInicio, String StrFinal)
        {
            int Ini;
            int Fim;
            int Diff;
            Ini = Str.IndexOf(StrInicio);
            Fim = Str.IndexOf(StrFinal);
            if (Ini > 0) Ini = Ini + StrInicio.Length;
            if (Fim > 0) Fim = Fim + StrFinal.Length;
            Diff = ((Fim - Ini) - StrFinal.Length);
            if ((Fim > Ini) && (Diff > 0))
                return Str.Substring(Ini, Diff);
            else
                return "";
        }

        private String StringSaltaString(String Str, String StrInicio)
        {
            int Ini;
            Ini = Str.IndexOf(StrInicio);
            if (Ini > 0)
            {
                Ini = Ini + StrInicio.Length;
                return Str.Substring(Ini);
            }
            else
                return Str;
        }

        public string StringPrimeiraLetraMaiuscula(String Str)
        {
            string StrResult = "";
            if (Str.Length > 0)
            {
                StrResult += Str.Substring(0, 1).ToUpper();
                StrResult += Str.Substring(1, Str.Length - 1).ToLower();
            }
            return StrResult;
        }

        private void frmConsultaReceita_Load(object sender, EventArgs e)
        {
            carregarCaptcha();
        }

        private void picLetras_Click(object sender, EventArgs e)
        {
            carregarCaptcha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {


            Cursor cursor;
            cursor = this.Cursor;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string cnpj1 = tb_cnpj.Text;
                cnpj1 = String.Format(@"{0:00\.000\.000\/0000\-00}", cnpj1);
                string tmp = consulta.Consulta(cnpj1, tb_letras.Text);

                if (tmp.Length > 0)
                {
                    empresa = new ConsultaCNPJ();
                    empresa.Cnpj = tb_cnpj.Text;
                    empresa.RazaoSocial = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                    empresa.NomeFantasia = RecuperaColunaValor(tmp, Coluna.NomeFantasia);
                    empresa.Endereco = RecuperaColunaValor(tmp, Coluna.EnderecoLogradouro);
                    empresa.Endereco += ", " + RecuperaColunaValor(tmp, Coluna.EnderecoNumero);
                    empresa.Bairro = RecuperaColunaValor(tmp, Coluna.EnderecoBairro);
                    empresa.Cep = RecuperaColunaValor(tmp, Coluna.EnderecoCEP);
                    empresa.Cnae = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaPrimaria);
                    //empresa.Cidade = RecuperaColunaValor(tmp, Coluna.EnderecoCidade);
                    //empresa.Estado = RecuperaColunaValor(tmp, Coluna.EnderecoEstado);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                carregarCaptcha();
            }

            this.Cursor = cursor;
        }
    }
}

