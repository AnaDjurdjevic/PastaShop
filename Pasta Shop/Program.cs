using System;
using System.Windows.Forms;

namespace Pasta_Shop
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
            PastaShopLogin p1 = new PastaShopLogin();
            p1.Show();
            Application.Run();
        }
    }
}
