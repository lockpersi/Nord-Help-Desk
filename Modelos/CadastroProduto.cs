using System;
using System.Collections.Generic;
using System.Text;

namespace NORD.Modelos
{
    public class CadastroProduto
    {
        private int _id_produto;
        public int Id_produto
        {
            get { return _id_produto; }
            set { _id_produto = value; }
        }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        private int _estoque;
        public int Estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
        }
    }
}