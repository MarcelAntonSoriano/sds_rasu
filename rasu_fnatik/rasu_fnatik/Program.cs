using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rasu_fnatik
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Splash());
            Application.Run(new login());
            Application.Run(new Menu());
            Application.Run(new About());


        }
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0)
                Application.ExitThread();
            else
                Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
