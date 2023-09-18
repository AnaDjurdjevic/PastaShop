using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            
            //MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pasta_shop;UserId = student; Password=studentana1*;");
            //conn.Open();
            //string query = "SELECT * FROM pasta_shop.account";
            //MySqlCommand cmd=new MySqlCommand(query, conn);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Username"]);
            //    Console.WriteLine(reader["Password"]);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PastaShopLogin p1 = new PastaShopLogin();
            p1.Show();
            Application.Run();
            //Application.Run(new PastaShopLogin());
            //Application.Run(new EmployeePage());
        }
    }
}
