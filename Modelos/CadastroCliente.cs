using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORD.Modelos
{
    public class CadastroCliente
    {
        private int _id_cliente;
        private string _nome;
        private string _email;
        private string _telefone;
        private string _empresa;

        public int Id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }        
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        } 

        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
    }
}
