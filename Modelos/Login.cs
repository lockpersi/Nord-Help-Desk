using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORD.Modelos
{
    public class Login
    {
        private string _usu;
        private string _pwd;
        private bool _logado = false;
        private string _ativo;

        public string Usu
        {
            get { return _usu; }
            set { _usu = value; }
        }

        public string Pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        public bool Logado
        {
            get { return _logado; }
            set { _logado = value; }
        }

        public string Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
    }
}
