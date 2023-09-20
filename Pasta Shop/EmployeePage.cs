using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasta_Shop
{
    public partial class EmployeePage : Form
    {
        public static EmployeePage Instance;

        public EmployeePage()
        {
            InitializeComponent();
            Instance = this;
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            articlesPage1.Hide();
            articlesPage1.SendToBack();
            ordersPage1.Show();
            ordersPage1.BringToFront();
            ordersPage1.ShowOrders();

        }

        private void ArticlesButton_Click(object sender, EventArgs e)
        {
            ordersPage1.Hide();
            ordersPage1.SendToBack();
            articlesPage1.Show();
            articlesPage1.BringToFront();
            articlesPage1.ShowTable();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            PastaShopLogin form = new PastaShopLogin();
            form.Show();
            this.Close();
        }
    }
}
