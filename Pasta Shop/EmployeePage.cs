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
            articles1.Hide();
            articles1.SendToBack();
           orders1.Show();
            orders1.BringToFront();

        }

        private void ArticlesButton_Click(object sender, EventArgs e)
        {
            orders1.Hide();
            orders1.SendToBack();
            articles1.Show();
            articles1.BringToFront();
        }

        private void articles1_Load(object sender, EventArgs e)
        {

        }
    }
}
