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
    public partial class OrderPage : Form
    {
        public static OrderPage instance;

        private DataSet ds;
        private DataTable dt;
        private MySqlDataAdapter adapter;
        private MySqlConnection conn = null;

        DataTable orderDT = new DataTable();
        Order Order = new Order();

        Item Item = new Item();
        public OrderPage()
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
                orderDT.Columns.Add("IdPasta", typeof(int));
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
                cmd.CommandText = "select Price, Type,IdPasta from pasta p where p.IdPasta = @Id";
                cmd.Parameters.AddWithValue("@Id", Item.Pasta.IdPasta);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item.Price = Item.Quantity * reader.GetDouble(0);
                    Item.Pasta.Type= reader.GetString(1);
                    Item.Pasta.IdPasta = reader.GetInt32(2);
                }
                orderDT.Rows.Add(Item.Pasta.IdPasta,Item.Pasta.Type,Item.Quantity,Item.Price);
                dataGridViewOrder.AutoGenerateColumns = true;
                dataGridViewOrder.DataSource = orderDT;
                dataGridViewOrder.DataSource = orderDT;
                dataGridViewOrder.Columns[0].Visible = false;
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
            MySqlCommand cmd;
            Order.Date = DateTime.Now;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "create_order";
                cmd.Parameters.AddWithValue("@pDate", Order.Date);
                cmd.Parameters["@pDate"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pStatus", "Created");
                cmd.Parameters["@pStatus"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pCustomer", Account.User.Username);
                cmd.Parameters["@pCustomer"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pId", MySqlDbType.Int32);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int ConfirmationNumber = Convert.ToInt32(cmd.Parameters["@pId"].Value);
                foreach (DataRow row in orderDT.Rows)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into `item`(`ORDER_ConfirmationNumber`,`PASTA_IdPasta`,`Quantity`,`Price`)values (@pConfirmationNumber,@pIdPasta,@pQuantity,@pPrice);";
                    cmd.Parameters.AddWithValue("@pConfirmationNumber", ConfirmationNumber);
                    cmd.Parameters["@pConfirmationNumber"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@pIdPasta", row[0]);
                    cmd.Parameters["@pIdPasta"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@pQuantity", row[2]);
                    cmd.Parameters["@pQuantity"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@pPrice", row[3]);
                    cmd.Parameters["@pPrice"].Direction = ParameterDirection.Input;
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Successfully created order. Thank you!");
              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to create an order. Please try again.");
                Trace.WriteLine(ex.Message + ex.StackTrace);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
