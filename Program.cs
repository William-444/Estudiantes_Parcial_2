using PARCIAL_2.Formularios;
using RepoDb;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PARCIAL_2
{
    internal static class Program
    {
        [STAThread]
        [Obsolete]
        static void Main()
        {
            SqlServerBootstrap.Initialize();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.frmRegistrarNota());
        }
    }
}