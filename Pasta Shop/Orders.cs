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
    public partial class OrdersPage : UserControl
    {
        public static OrdersPage instance;
        private MySqlConnection conn = null;
        private DataSet ds;
        private DataTable dt;
        private MySqlDataAdapter adapter;
        private DataSet ds1;
        private DataTable dt1;
        private MySqlDataAdapter adapter1;
        public OrdersPage()
        {
            InitializeComponent();
            instance = this;
        }

        public void ShowOrders()
        {
            try
            {
                conn = MySqlUtil.GetConnection();
                ds = new DataSet("dsOrders");
                dt = new DataTable("dtOrders");
                dt.Columns.Add("Confirmation Number", typeof(int));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Customer", typeof(string));
                ds.Tables.Add(dt);
                adapter = new MySqlDataAdapter("SELECT * FROM `orders_view`", conn);
                adapter.Fill(ds, "dtOrders");
                dataGridViewOrders.AutoGenerateColumns = true;
                dataGridViewOrders.DataSource = ds;
                dataGridViewOrders.DataMember = "dtOrders";
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

        }

        private void orders1_Load(object sender, EventArgs e)
        {

        }

        private void ChangeStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void SeeOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfNumPlaceholder.Text.Trim()))
            {
                errorProvider1.SetError(ConfNumPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(ConfNumPlaceholder, string.Empty);
            }
            bool rowExists = false;
            int OrderNumber = Convert.ToInt32(ConfNumPlaceholder.Text);
            foreach (DataRow row in dt.Rows)
            {
                if(OrderNumber == Convert.ToInt32(row[0]))
                {
                    rowExists = true;
                }
            }
            if (rowExists)
            {
                try
                {
                    conn = MySqlUtil.GetConnection();
                    ds1 = new DataSet("dsSpecOrder");
                    dt1 = new DataTable("dsSpecOrder");
                    dt1.Columns.Add("Type", typeof(string));
                    dt1.Columns.Add("Quantity", typeof(decimal));
                    dt1.Columns.Add("Price", typeof(decimal));
                    ds1.Tables.Add(dt1);
                    adapter1 = new MySqlDataAdapter(string.Format("select `p`.`Type`, " +
                        "`i`.`Price`,`i`.`Quantity`,`o`.`CUSTOMER_ACCOUNT_Username` from `item` i" +
                        " join `order` o on `i`.`ORDER_ConfirmationNumber` = `o`.`ConfirmationNumber` " +
                        "join `pasta` p on `p`.`IdPasta` = `i`.`PASTA_IdPasta` " +
                        "where `i`.`ORDER_ConfirmationNumber` = {0}", OrderNumber), conn);
                    adapter1.Fill(ds1, "dsSpecOrder");
                    dataGridViewSpecificOrder.AutoGenerateColumns = true;
                    dataGridViewSpecificOrder.DataSource = ds1;
                    dataGridViewSpecificOrder.DataMember = "dsSpecOrder";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Could not find the order with the entered  confirmation number");
                    Trace.WriteLine(ex.Message + ex.StackTrace);
                }
                finally
                {
                    MySqlUtil.CloseQuietly(conn);
                }
            }
            else
            {
                MessageBox.Show("Invalid order confirmation number. Please try again.");
            }
        }

        private void ConfNumPlaceholder_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfNumPlaceholder.Text.Trim()))
            {
                errorProvider1.SetError(ConfNumPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(ConfNumPlaceholder, string.Empty);
            }
            int OrderNumber = Convert.ToInt32(ConfNumPlaceholder.Text);
            try
            {
                conn = MySqlUtil.GetConnection();
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adapter.UpdateCommand.CommandText = "change_order_status";
                adapter.UpdateCommand.Parameters.AddWithValue("@pOrderNumber", OrderNumber);
                adapter.UpdateCommand.Parameters["@pOrderNumber"].Direction = ParameterDirection.Input;
                adapter.UpdateCommand.Parameters.Add("@pStatus", MySqlDbType.Int32);
                adapter.UpdateCommand.Parameters["@pStatus"].Direction = ParameterDirection.Output;
                adapter.UpdateCommand.ExecuteNonQuery();
                int success = Convert.ToInt32(adapter.UpdateCommand.Parameters["@pStatus"].Value);
                if (success == 1)
                {
                    adapter.Update(dt);
                    dt.Clear();
                    adapter.Fill(dt);
                    dataGridViewOrders.AutoGenerateColumns = true;
                    dataGridViewOrders.DataSource = ds;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to change order status. Please try again.");
                Trace.WriteLine(ex.Message + ex.StackTrace);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
