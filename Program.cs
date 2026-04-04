using SalesManagementApp.SalesMamagementPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            FrmLogIn login = new FrmLogIn();
            // this will show the login form as a dialog, and we will check the result
            if (login.ShowDialog() == DialogResult.OK)
            {
                // this means the user logged in successfully, so we can open the main form
                Application.Run(new FrmMainForm());
            }
            else
            {
                // this means the user either canceled the login or failed to log in, so we will exit the application
                Application.Exit();
            }
        }
    }
}
