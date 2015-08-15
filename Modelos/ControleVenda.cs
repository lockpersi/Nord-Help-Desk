using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORD.Modelos
{
    public class ControleVenda
    {
        private int _id_venda;
        public int Id_venda
        {
            get { return _id_venda; }
            set { _id_venda = value; }
        }
        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private bool _faturado;
        public bool Faturado
        {
            get { return _faturado; }
            set { _faturado = value; }
        }
        private int _id_cliente;
        public int Id_Cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        private int _id_produto;
        public int Id_Produto
        {
            get { return _id_produto; }
            set { _id_produto = value; }
        }
        private string _nomeCliente;
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

    }
}
