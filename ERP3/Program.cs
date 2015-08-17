using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP3{
    
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frmLogin = new frmLogin();

            frmLogin.ShowDialog();
            string opc = "False";


                if (frmLogin.ativo.Equals(opc))
                {
                frmInserirSenha frmInserirSenha = new frmInserirSenha();

                frmInserirSenha.ShowDialog();

                }
            
            else
            { 
                if (frmLogin.logado)
                {
                    Application.Run(new frmPrincipal(frmLogin.usuario));
                }
            } 
        }
    }
}
