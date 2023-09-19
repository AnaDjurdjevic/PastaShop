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
    public partial class OrdersPage : UserControl
    {
        public static OrdersPage instance;
        public OrdersPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void orders1_Load(object sender, EventArgs e)
        {

        }
    }
}
