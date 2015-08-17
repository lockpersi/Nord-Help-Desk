using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORD.Modelos
{
    public class AtualizaLicenca
    {
        private string _codigo;
        private string _tempo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Tempo
        {
            get { return _tempo; }
            set { _tempo = value; }
        }
    }
}
