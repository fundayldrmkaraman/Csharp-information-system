using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FınalOdev
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static public string connstring = "Data Source=LAPTOP-SGFGEIP6\\FUNDA; Initial Catalog=VeriFinal;User ID=ServiceAccount;Password=turkuazmavisifalanfilan;";
    }
}
