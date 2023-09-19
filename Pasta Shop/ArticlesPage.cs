using MySql.Data.MySqlClient;
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
    public partial class ArticlesPage : UserControl
    {
        public static ArticlesPage instance;
        private DataSet ds;
        private DataTable dt;
        private MySqlDataAdapter adapter;
        private MySqlConnection conn = null;
        public ArticlesPage()
        {
            InitializeComponent();
            instance = this;
            
            //// Kreiranje DataSet-a...
            conn = MySqlUtil.GetConnection();
            ds = new DataSet("dsArticles");
            dt = new DataTable("dtArticles");
            dt.Columns.Add("IdPasta", typeof(int));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Quantity", typeof(double));
            ds.Tables.Add(dt);
            //// Kreiranje adaptera sa upitom za čitanje podataka
            adapter = new MySqlDataAdapter("SELECT IdPasta, Type, Price, Quantity FROM `pasta`", conn);
            adapter.Fill(ds, "dtArticles");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "dtArticles";
            MySqlUtil.CloseQuietly(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
