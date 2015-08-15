using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NORD.DAL;
using NORD.Modelos;

namespace NORD.BLL
{
    public class ControleVendasBLL
    {
        //Este é um campo privado para armazenar uma instância da classe DAL.
        private ControleVendasDAL objDAL;
        //Esse é o construtor da classe VendasBLL
        public ControleVendasBLL()
        {
            objDAL = new ControleVendasDAL();
        }
        public DataTable ListaDeProdutos
        {
            get
            {
                return objDAL.ListaDeProdutos;
            }
        }
        public DataTable ListaDeClientes
        {
            get
            {
                return objDAL.ListaDeClientes;
            }
        }
        public void Incluir(ControleVenda venda)
        {
            objDAL.Incluir(venda);
        }
    }
}