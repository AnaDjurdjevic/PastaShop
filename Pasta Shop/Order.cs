using MySql.Data.MySqlClient;
using Pasta_Shop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pasta_Shop
{
    public partial class Order : Form
    {
        public static Order instance;

        private DataSet ds;
        private DataTable dt;
        private MySqlDataAdapter adapter;
        private MySqlConnection conn = null;

        DataTable orderDT = new DataTable();

        Item Item = new Item();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        public void ShowMenu()
        {
            try
            {
                conn = MySqlUtil.GetConnection();
                ds = new DataSet("dsMenu");
                dt = new DataTable("dtMenu");
                dt.Columns.Add("IdPasta", typeof(int));
                dt.Columns.Add("Type", typeof(string));
                dt.Columns.Add("Price", typeof(decimal));
                ds.Tables.Add(dt);
                adapter = new MySqlDataAdapter("SELECT * FROM `articles_menu`", conn);
                adapter.Fill(ds, "dtMenu");
                dataGridViewMenu.AutoGenerateColumns = true;
                dataGridViewMenu.DataSource = ds;
                dataGridViewMenu.DataMember = "dtMenu";
                orderDT.Columns.Add("Type", typeof(string));
                orderDT.Columns.Add("Quantity", typeof(decimal));
                orderDT.Columns.Add("Price", typeof(decimal));
            }
            catch (MySqlException ex)
            {
                Trace.WriteLine(ex.Message + ex.StackTrace);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPlaceholder.Text.Trim()))
            {
                errorProvider1.SetError(IdPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(IdPlaceholder, string.Empty);
            }
            if (string.IsNullOrEmpty(QuantityPlaceholder.Text.Trim()))
            {
                errorProvider2.SetError(QuantityPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider2.SetError(QuantityPlaceholder, string.Empty);
            }
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Item.Pasta.IdPasta = Convert.ToInt32(IdPlaceholder.Text);
            Item.Quantity = Convert.ToDouble(QuantityPlaceholder.Text);
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select Price, Type from pasta p where p.IdPasta = @Id";
                cmd.Parameters.AddWithValue("@Id", Item.Pasta.IdPasta);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item.Price = Item.Quantity * reader.GetDouble(0);
                    Item.Pasta.Type= reader.GetString(1);
                }
                orderDT.Rows.Add(Item.Pasta.Type,Item.Quantity,Item.Price);
                dataGridViewOrder.AutoGenerateColumns = true;
                dataGridViewOrder.DataSource = orderDT;
            }
            catch (MySqlException ex)
            {
                Trace.WriteLine(ex.Message + ex.StackTrace);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            //MySqlCommand cmd;
            //try
            //{
            //    conn = MySqlUtil.GetConnection();
            //    cmd = conn.CreateCommand();
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "create_order";
            //    cmd.Parameters.AddWithValue("@pPostNumber", Location.PostNumber);
            //    cmd.Parameters["@pPostNumber"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pLocationName", Location.Name);
            //    cmd.Parameters["@pLocationName"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pAddress", Address);
            //    cmd.Parameters["@pAddress"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pTelephone", Telephone);
            //    cmd.Parameters["@pTelephone"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pUsername", Username);
            //    cmd.Parameters["@pUsername"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pPassword", Password);
            //    cmd.Parameters["@pPassword"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pFirstName", FirstName);
            //    cmd.Parameters["@pFirstName"].Direction = ParameterDirection.Input;
            //    cmd.Parameters.AddWithValue("@pLastName", LastName);
            //    cmd.Parameters["@pLastName"].Direction = ParameterDirection.Input;
            //    cmd.ExecuteNonQuery();
                
            //        MessageBox.Show("Successfully created order. Thank you!");
                
            //}
            //catch (MySqlException ex)
            //{
            //    Trace.WriteLine(ex.Message + ex.StackTrace);
            //}
            //finally
            //{
            //    MySqlUtil.CloseQuietly(conn);
            //}
        }
    }
}
