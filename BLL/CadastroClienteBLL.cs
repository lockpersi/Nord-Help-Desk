using System;
using System.Data;
using NORD.Modelos;
using NORD.DAL;

namespace NORD.BLL
{
    public class CadastroClienteBLL
    {
        public void Incluir(CadastroCliente cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //E-mail é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();

            if (cliente.Empresa.Trim().Length == 0)
            {
                throw new Exception("O campo empresa é obrigatório");
            }
            //Se tudo está Ok, chama a rotina de inserção.
            CadastroClientesDAL obj = new CadastroClientesDAL();
            obj.Incluir(cliente);
        }
        public void Alterar(CadastroCliente cliente)
        {
            CadastroClientesDAL obj = new CadastroClientesDAL();
            obj.Alterar(cliente);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");
            }
            CadastroClientesDAL obj = new CadastroClientesDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem()
        {
            CadastroClientesDAL obj = new CadastroClientesDAL();
            return obj.Listagem();
        }

        public CadastroCliente Pesquisa(CadastroCliente cliente)
        {
            CadastroClientesDAL obj = new CadastroClientesDAL();
            obj.Pesquisar(cliente);
            
            return cliente;
        }
    }
}