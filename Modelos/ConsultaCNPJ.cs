using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORD.Modelos
{
    public class ConsultaCNPJ
    {
        public static int _id_empresa;
        public static string _cnpj;
        public static string _razaoSocial;
        public static string _nomefantasia;
        public static string _endereco;
        public static string _bairro;
        public static string _cep;
        public static string _cnae;
        public static string _incEstadual;
        public static string _contato;
        public static string _numero;
        public static string _estado;
        public static string _cidade;
        public static string _telefone;
        public static string _email;
        public static string _fax;
        public static string _AtividadeEconomicaPrimaria;
        public static string _NaturezaJuridica;
        public static bool auxpesquisa;
        public static bool verificaaux;

        public bool Verificaaux
        {
            get { return verificaaux; }
            set { verificaaux = value; }
        }
        public int Id_empresa
        {
            get { return _id_empresa; }
            set { _id_empresa = value; }
        }

        public string NaturezaJuridica
        {
            get { return _NaturezaJuridica; }
            set { _NaturezaJuridica = value; }
        }
        public string AtividadeEconomicaPrimaria
        {
            get { return _AtividadeEconomicaPrimaria; }
            set { _AtividadeEconomicaPrimaria = value; }
        }

        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

        public string NomeFantasia
        {
            get { return _nomefantasia; }
            set { _nomefantasia = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string Cnae
        {
            get { return _cnae; }
            set { _cnae = value; }
        }

        public string IncEstadual
        {
            get { return _incEstadual; }
            set { _incEstadual = value; }
        }

        public string Contato
        {
            get { return _contato; }
            set { _contato = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public bool Auxpesquisa
        {
            get { return auxpesquisa; }
            set { auxpesquisa = value; }
        }

    }
}

