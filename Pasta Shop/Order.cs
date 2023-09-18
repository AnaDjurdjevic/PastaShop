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
    public partial class Order : Form
    {
        public static Order instance;
        public Order()
        {
            InitializeComponent();
            instance = this;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            PastaShopLogin form = new PastaShopLogin();
            form.Show();
            this.Close();
        }

        private void OrderTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
