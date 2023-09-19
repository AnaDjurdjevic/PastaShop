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

namespace Pasta_Shop
{
    public partial class ArticlesPage : UserControl
    {
        Pasta article = new Pasta();
        public static ArticlesPage instance;
        private DataSet ds;
        private DataTable dt;
        private MySqlDataAdapter adapter;
        private MySqlConnection conn = null;
        public ArticlesPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowTable()
        {
            conn = MySqlUtil.GetConnection();
            ds = new DataSet("dsArticles");
            dt = new DataTable("dtArticles");
            dt.Columns.Add("IdPasta", typeof(int));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Quantity", typeof(decimal));
            ds.Tables.Add(dt);
            adapter = new MySqlDataAdapter("SELECT * FROM `articles_view`", conn);
            adapter.Fill(ds, "dtArticles");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "dtArticles";
            MySqlUtil.CloseQuietly(conn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TypePlaceholder.Text.Trim()))
            {
                errorProvider1.SetError(TypePlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(TypePlaceholder, string.Empty);
            }
            if (string.IsNullOrEmpty(PricePlaceholder.Text.Trim()))
            {
                errorProvider2.SetError(PricePlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider2.SetError(PricePlaceholder, string.Empty);
            }
            if (string.IsNullOrEmpty(QuantityPlaceholder.Text.Trim()))
            {
                errorProvider3.SetError(QuantityPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider3.SetError(QuantityPlaceholder, string.Empty);
            }
            article.Price = Convert.ToDouble(PricePlaceholder.Text);
            article.Type = TypePlaceholder.Text;
            article.Quantity= Convert.ToDouble(QuantityPlaceholder.Text);
            try
            {
                conn = MySqlUtil.GetConnection();
                adapter.InsertCommand = conn.CreateCommand();
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.CommandText = "add_pasta";
                adapter.InsertCommand.Parameters.AddWithValue("@pType", article.Type);
                adapter.InsertCommand.Parameters["@pType"].Direction = ParameterDirection.Input;
                adapter.InsertCommand.Parameters.AddWithValue("@pPrice", article.Price);
                adapter.InsertCommand.Parameters["@pPrice"].Direction = ParameterDirection.Input;
                adapter.InsertCommand.Parameters.AddWithValue("@pQuantity", article.Quantity);
                adapter.InsertCommand.Parameters["@pQuantity"].Direction = ParameterDirection.Input;
                adapter.InsertCommand.Parameters.AddWithValue("@pEmployee", "Snjeza");
                adapter.InsertCommand.Parameters["@pEmployee"].Direction = ParameterDirection.Input;
                adapter.InsertCommand.ExecuteNonQuery();
                adapter.Update(dt);
                dt.Clear();
                adapter.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dtArticles";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddArticleButton_Click(object sender, EventArgs e)
        {
            TypeLabel.Visible = true;
            TypePlaceholder.Visible = true;
            PriceLabel.Visible = true;
            PricePlaceholder.Visible = true;
            QuantityLabel.Visible = true;
            QuantityPlaceholder.Visible = true;
            AddButton.Visible = true;
            IdPastaLabel.Visible = false;
            IdPastaPlaceholder.Visible = false;
            DeleteButton.Visible = false;
            UpdateButton.Visible = false;
            InsertQuantityAddLabel.Visible = false;
        }

        private void DeleteArticleButton_Click(object sender, EventArgs e)
        {
            TypeLabel.Visible = false;
            TypePlaceholder.Visible = false;
            PriceLabel.Visible = false;
            PricePlaceholder.Visible = false;
            QuantityLabel.Visible = false;
            QuantityPlaceholder.Visible = false;
            AddButton.Visible = false;
            IdPastaLabel.Visible = true;
            IdPastaPlaceholder.Visible = true;
            DeleteButton.Visible = true;
            UpdateButton.Visible = false;
            InsertQuantityAddLabel.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPastaPlaceholder.Text.Trim()))
            {
                errorProvider4.SetError(IdPastaPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider4.SetError(IdPastaPlaceholder, string.Empty);
            }
            article.IdPasta=Convert.ToInt32(IdPastaPlaceholder.Text);
            try
            {
                conn = MySqlUtil.GetConnection();
                adapter.DeleteCommand = conn.CreateCommand();
                adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adapter.DeleteCommand.CommandText = "delete_pasta";
                adapter.DeleteCommand.Parameters.AddWithValue("@pIdPasta", article.IdPasta);
                adapter.DeleteCommand.Parameters["@pIdPasta"].Direction = ParameterDirection.Input;
                adapter.DeleteCommand.Parameters.Add("@pStatus", MySqlDbType.Int32);
                adapter.DeleteCommand.Parameters["@pStatus"].Direction = ParameterDirection.Output;
                adapter.DeleteCommand.ExecuteNonQuery();
                int success = Convert.ToInt32(adapter.DeleteCommand.Parameters["@pStatus"].Value);
                if (success == 1)
                {
                    adapter.Update(dt);
                    dt.Clear();
                    adapter.Fill(dt);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "dtArticles";
                }
                else
                {
                    MessageBox.Show("Unable to delete pasta article. Please try again.");
                }
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPastaPlaceholder.Text.Trim()))
            {
                errorProvider4.SetError(IdPastaPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider4.SetError(IdPastaPlaceholder, string.Empty);
            }
            if (string.IsNullOrEmpty(QuantityPlaceholder.Text.Trim()))
            {
                errorProvider3.SetError(QuantityPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider3.SetError(QuantityPlaceholder, string.Empty);
            }
            article.IdPasta = Convert.ToInt32(IdPastaPlaceholder.Text);
            article.Quantity= Convert.ToDouble(QuantityPlaceholder.Text);
            try
            {
                conn = MySqlUtil.GetConnection();
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adapter.UpdateCommand.CommandText = "update_pasta";
                adapter.UpdateCommand.Parameters.AddWithValue("@pIdPasta", article.IdPasta);
                adapter.UpdateCommand.Parameters["@pIdPasta"].Direction = ParameterDirection.Input;
                adapter.UpdateCommand.Parameters.AddWithValue("@pQuantity", article.Quantity);
                adapter.UpdateCommand.Parameters["@pQuantity"].Direction = ParameterDirection.Input;
                adapter.UpdateCommand.Parameters.Add("@pStatus", MySqlDbType.Int32);
                adapter.UpdateCommand.Parameters["@pStatus"].Direction = ParameterDirection.Output;
                adapter.UpdateCommand.ExecuteNonQuery();
                int success = Convert.ToInt32(adapter.UpdateCommand.Parameters["@pStatus"].Value);
                if (success == 1)
                {
                    adapter.Update(dt);
                    dt.Clear();
                    adapter.Fill(dt);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "dtArticles";
                }
                else
                {
                    MessageBox.Show("Unable to update pasta article. Please try again.");
                }
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

        private void UpdateQuantityButton_Click(object sender, EventArgs e)
        {
            TypeLabel.Visible = false;
            TypePlaceholder.Visible = false;
            PriceLabel.Visible = false;
            PricePlaceholder.Visible = false;
            QuantityLabel.Visible = false;
            QuantityPlaceholder.Visible = true;
            InsertQuantityAddLabel.Visible = true;
            AddButton.Visible = false;
            IdPastaLabel.Visible = true;
            IdPastaPlaceholder.Visible = true;
            DeleteButton.Visible = false;
            UpdateButton.Visible = true;
        }
    }
}
