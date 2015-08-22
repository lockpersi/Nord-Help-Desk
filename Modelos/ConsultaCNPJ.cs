using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORD.Modelos
{
    public class ConsultaCNPJ
    {
        private string _cnpj;
        private string _razaoSocial;
        private string _nomefantasia;
        private string _endereco;
        private string _bairro;
        private string _cep;
        private string _cnae;

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
    }
}
