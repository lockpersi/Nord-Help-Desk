using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NORD.Modelos;
using NORD.DAL;

namespace NORD.BLL
{
    public class LoginBLL
    {
        public void validar(Login login)
        {
            if(login.Usu.Trim().Length == 0)
            {
                throw new Exception("Você precisa digitar um login !");
            }

            if(login.Pwd.Trim().Length == 0)
            {
                throw new Exception("O campo senha não pode estar em branco");
            }

            LoginDAL LoginDAL = new LoginDAL();
            LoginDAL.logar(login);

        }
    }
}
