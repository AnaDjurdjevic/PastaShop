using MySql.Data.MySqlClient;
using Pasta_Shop.Model;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pasta_Shop
{
    public partial class PastaShopLogin : Form
    {
        static PastaShopLogin obj;
        public static PastaShopLogin Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new PastaShopLogin();
                }
                return obj;
            }
        }
        public PastaShopLogin()
        {
            InitializeComponent();
        }

        Individual account = new Individual();

        private void PastaShopLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void PastaShop_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernamePlaceholder.Text.Trim()))
            {
                errorProvider1.SetError(UsernamePlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(UsernamePlaceholder, string.Empty);
            }
            if (string.IsNullOrEmpty(PasswordPlaceholder.Text.Trim()))
            {
                errorProvider2.SetError(PasswordPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider2.SetError(PasswordPlaceholder, string.Empty);
            }
            account.Username = UsernamePlaceholder.Text;
            account.Password = PasswordPlaceholder.Text;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "login";
                cmd.Parameters.AddWithValue("@pUsername", account.Username);
                cmd.Parameters["@pUsername"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pPassword", account.Password);
                cmd.Parameters["@pPassword"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pStatus", MySqlDbType.Int32);
                cmd.Parameters["@pStatus"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@pType", MySqlDbType.Int32);
                cmd.Parameters["@pType"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int success = Convert.ToInt32(cmd.Parameters["@pStatus"].Value);
                if (success == 1 && Convert.ToInt32(cmd.Parameters["@pType"].Value) == 1)
                {
                    Order form = new Order();
                    form.Show();
                    this.Close();
                }
                else if (success == 1 && Convert.ToInt32(cmd.Parameters["@pType"].Value) == 0)
                {
                    EmployeePage form = new EmployeePage();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }

            }
            catch (MySqlException ex)
            {
                Trace.WriteLine(ex.Message + ex.StackTrace);
                MessageBox.Show(ex.Number == 1045 ? "Invalid credentials. Please try again"
                    : "Cannot connect to server.  Contact administrator");
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }

        }

        private void UsernamePlaceholder_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordPlaceholder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
