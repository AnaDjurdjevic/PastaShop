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
    public partial class Articles : UserControl
    {
        public static Articles instance;
        public Articles()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }
    }
}
