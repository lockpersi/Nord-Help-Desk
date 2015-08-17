using System;
using System.Data;
using NORD.Modelos;
using NORD.DAL;

namespace NORD.BLL
{
    public class AtualizaLicencaBLL
    {
        public void validar(AtualizaLicenca atualiza)
        {
            if(atualiza.Codigo.Trim().Length == 0)
            {
                throw new Exception("O campo SERIAL não pode estar vazio !");
            }
        }
    }
}