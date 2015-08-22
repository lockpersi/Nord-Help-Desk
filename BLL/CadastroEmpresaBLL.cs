using System;
using System.Data;
using NORD.Modelos;
using NORD.DAL;


namespace NORD.BLL
{
    public class CadastroEmpresaBLL
    {

        public ConsultaCNPJ PesquisaCNPJ(ConsultaCNPJ empresa)
        {
            return empresa;
        }

        public static string MascaraCnpjCpf(string pCnpjCpf)
        {
            string result = "";
            if (pCnpjCpf.Length == 14)
            {
                result = pCnpjCpf.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            
            if ((pCnpjCpf.Length != 11) && (pCnpjCpf.Length != 14))
            {
                result = pCnpjCpf;
            }
            return result;
        }
    }
}
