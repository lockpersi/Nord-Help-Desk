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

            if (atualiza.Tempo.Trim().Length == 0)
            {
                throw new Exception("O campo SERIAL não pode estar vazio !");
            }
            //serial

            string ysk7y2, ysk7y1, ysk7y3, ysk7y4, ysk7y5;
            string ysk7y = DateTime.Now.Year.ToString();
            string ysk7x = DateTime.Now.DayOfWeek.ToString();
            string ysk7x1 = DateTime.Now.DayOfYear.ToString();
            int ysk7x2 = DateTime.Now.DayOfYear;
            double ysk7x3 = DateTime.Now.DayOfYear;
            double ysk7x4 = DateTime.Now.Day;
            ysk7y3 = ysk7x[0].ToString();
            ysk7y2 = ysk7y[3].ToString();
            ysk7y4 = ysk7x[2].ToString().ToUpper();
            ysk7y5 = ysk7x[4].ToString().ToUpper();
            ysk7x2 = ysk7x2 * 754 + 399;
            ysk7x1 = ysk7x1 + ysk7x2;
            ysk7x3 = Math.Truncate(ysk7x3 * 55 / ysk7x4);
            ysk7y1 = ysk7y4 + ysk7y2 + ysk7y3 + ysk7x1 + ysk7x3 + ysk7y5;

            //tempo

            string tpmysk, tpmysk1, tpmysk2, tpmysk3, tpmysk4, tpmysk5, tpmysk6;

            tpmysk = DateTime.Now.DayOfWeek.ToString().ToUpper();
            tpmysk1 = tpmysk[1].ToString();
            tpmysk2 = tpmysk[3].ToString();

            //fazer verificao
            tpmysk4 = tpmysk2 + tpmysk1;
            //
            
            tpmysk3 = atualiza.Tempo[1].ToString();
            tpmysk5 = atualiza.Tempo[3].ToString();

            tpmysk6 = tpmysk2 + tpmysk5 + tpmysk1 + tpmysk5;

            tpmysk3 = tpmysk3 + tpmysk5;

            int tempo = Convert.ToInt32(tpmysk3);

            string xrlt = atualiza.Tempo[0].ToString();
            string xrlt1 = atualiza.Tempo[2].ToString();

            if ((xrlt.Equals(tpmysk2)) && (xrlt1.Equals(tpmysk1))){

                if (atualiza.Codigo.Equals(ysk7y1))
                {
                    throw new Exception("Senha Correta !");
                }
                else
                {
                    throw new Exception("Serial Invalido !");
                }
            }
            else
            {
                throw new Exception("Serial Invalido !");
            }

            if (atualiza.Codigo.Equals(ysk7y1))
            {
                throw new Exception("Aguarde... Atualizando Sistema !");
            }
            else
            {
                throw new Exception(" SERIAL INVÁLIDO!");
            }
        }
    }
}