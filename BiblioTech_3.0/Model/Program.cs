using BiblioTech_3._0.Model;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
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
            Application.Run(new frmPrincipal());
        }
    }
}
