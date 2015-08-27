using System;
using System.Data;
using NORD.Modelos;
using NORD.DAL;


namespace NORD.BLL
{
    public class CadastroEmpresaBLL
    {

        public ConsultaCNPJ PesquisaCNPJ(ConsultaCNPJ empresa)
        {
            return empresa;
        }

        public static string MascaraCnpjCpf(string pCnpjCpf)
        {
            string result = "";
            if (pCnpjCpf.Length == 14)
            {
                result = pCnpjCpf.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            
            if ((pCnpjCpf.Length != 11) && (pCnpjCpf.Length != 14))
            {
                result = pCnpjCpf;
            }
            return result;
        }

        public void Incluir(ConsultaCNPJ empresa)
        {
            if(empresa.Cnpj.Trim().Length == 0)
            {
                throw new Exception("O campo CNPJ não pode estar em branco !");
            }

            if(empresa.RazaoSocial.Trim().Length == 0)
            {
                throw new Exception("O campo Razão Social não pode estar em branco !");
            }

            if(empresa.IncEstadual.Trim().Length == 0)
            {
                throw new Exception("O campo Inscrição Estadual não pode estar em branco !");
            }

            if(empresa.NomeFantasia.Trim().Length == 0)
            {
                throw new Exception("O campo Nome Fantasia não pode estar em branco !");
            }

            if(empresa.NaturezaJuridica.Trim().Length == 0)
            {
                throw new Exception("O campo Natureza Jurídica não pode estar em branco !");
            }

            if(empresa.AtividadeEconomicaPrimaria.Trim().Length == 0)
            {
                throw new Exception("O campo Atividade Econômica não pode estar em branco !");
            }

            if(empresa.Endereco.Trim().Length == 0)
            {
                throw new Exception("O campo Endereço não pode estar em branco !");
            }

            if(empresa.Numero.Trim().Length == 0)
            {
                throw new Exception("O campo Número não pode estar em branco !");
            }

            if (empresa.Cep.Trim().Length == 0)
            {
                throw new Exception("O campo CEP não pode estar em branco !");
            }

            if(empresa.Bairro.Trim().Length == 0)
            {
                throw new Exception("O campo Bairro não pode estar em branco !");
            }

            if (empresa.Cidade.Trim().Length == 0)
            {
                throw new Exception("O campo Cidade não pode estar em branco !");
            }

            if (empresa.Estado.Trim().Length == 0)
            {
                throw new Exception("O campo Estado não pode estar em branco !");
            }
            Pesquisar(empresa);

            if (empresa.Auxpesquisa == false)
            {
                throw new Exception("Empresa já cadastrada no Banco de Dados !");
            }
            CadastroEmpresaDAL obj = new CadastroEmpresaDAL();
            obj.Inlcuir(empresa);

        }

        public ConsultaCNPJ Pesquisar(ConsultaCNPJ empresa)
        {
            CadastroEmpresaDAL obj = new CadastroEmpresaDAL();
            obj.Pesquisa(empresa);
            return empresa;
        } 

        public ConsultaCNPJ RetornoCNPJ(ConsultaCNPJ empresa)
        {
            CadastroEmpresaDAL obj = new CadastroEmpresaDAL();
            obj.RetornoCNPJ(empresa);
            return empresa;
        }

        //Valida  CNPJ
        private bool ValidaCnpj(String cnpj)
        {
            Boolean valida = true;
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            String tempCnpj;
            String digito;
            String verifica;
            int soma;
            int resto;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace("/", "").Replace(".", "").Replace("-", "");

            if (cnpj.Length == 14)
            {
                verifica = cnpj.Substring(12);
                tempCnpj = cnpj.Substring(0, 12);
                soma = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma = soma + int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;
                resto = resto < 2 ? resto = 0 : resto = 11 - resto; ;
                digito = resto.ToString();

                tempCnpj = tempCnpj + digito;

                soma = 0;
                for (int i = 0; i < 13; i++)
                {
                    soma = soma + int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;
                resto = resto < 2 ? resto = 0 : resto = 11 - resto; ;
                digito = digito + resto.ToString();

                if (digito != verifica)
                {
                    throw new Exception("CNPJ digitado inválido !");
                }

                switch (cnpj)
                {
                    case "11111111111111":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "22222222222222":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "33333333333333":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "44444444444444":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "55555555555555":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "66666666666666":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "77777777777777":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "88888888888888":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                    case "99999999999999":
                        {
                            throw new Exception("CNPJ digitado inválido !");
                        }
                }
            }
            else
            {
                throw new Exception("CNPJ digitado inválido !");
            }
            return valida;
        }
    }
}
