using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using NORD.DAL;
using NORD.Modelos;

namespace NORD.BLL
{
    public class CadastroProdutosBLL
    {
        public ArrayList ProdutosEmFalta()
        {

            CadastroProdutosDAL obj = new CadastroProdutosDAL();
            return obj.ProdutosEmFalta();
        }
        public void Incluir(CadastroProduto produto)
        {
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }
            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }
            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }
            //Se tudo estiver ok, chama a rotina de gravação
            CadastroProdutosDAL obj = new CadastroProdutosDAL();
            obj.Incluir(produto);
        }
        public void Alterar(CadastroProduto produto)
        {
            CadastroProdutosDAL obj = new CadastroProdutosDAL();
            obj.Alterar(produto);
        }
        public void Excluir(int codigo)
        {
            CadastroProdutosDAL obj = new CadastroProdutosDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem()
        {
            CadastroProdutosDAL obj = new CadastroProdutosDAL();
            return obj.Listagem();
        }
    }
}