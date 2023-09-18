using Pasta_Shop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pasta_Shop
{
    public partial class Register : Form
    {
        Account account = new Account();
        public static Register instance;
        public Register()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            //username
            if (string.IsNullOrEmpty(UsernamePlaceholder.Text.Trim()))
            {
                errorProvider1.SetError(UsernamePlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(UsernamePlaceholder, string.Empty);
            }
            //password
            if (string.IsNullOrEmpty(PasswordPlaceholder.Text.Trim()))
            {
                errorProvider2.SetError(PasswordPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider2.SetError(PasswordPlaceholder, string.Empty);
            }
            //address
            if (string.IsNullOrEmpty(AddressPlaceholder.Text.Trim()))
            {
                errorProvider3.SetError(AddressPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider3.SetError(AddressPlaceholder, string.Empty);
            }
            //telephone
            if (string.IsNullOrEmpty(TelephonePlaceholder.Text.Trim()))
            {
                errorProvider4.SetError(TelephonePlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider4.SetError(TelephonePlaceholder, string.Empty);
            }
            //location name
            if (string.IsNullOrEmpty(LocationNamePlaceholder.Text.Trim()))
            {
                errorProvider5.SetError(LocationNamePlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider5.SetError(LocationNamePlaceholder, string.Empty);
            }
            //post number
            if (string.IsNullOrEmpty(PostNumberPlaceholder.Text.Trim()))
            {
                errorProvider6.SetError(PostNumberPlaceholder, "This field is required.");
                return;
            }
            else
            {
                errorProvider6.SetError(PostNumberPlaceholder, string.Empty);
            }
            if (EnterpriseRadioButton.Checked)
            {
                //JIB
                if (string.IsNullOrEmpty(JIBPlaceholder.Text.Trim()))
                {
                    errorProvider7.SetError(JIBPlaceholder, "This field is required.");
                    return;
                }
                else
                {
                    errorProvider7.SetError(JIBPlaceholder, string.Empty);
                }
                //enterprise name
                if (string.IsNullOrEmpty(EnterpriseNamePlaceholder.Text.Trim()))
                {
                    errorProvider8.SetError(EnterpriseNamePlaceholder, "This field is required.");
                    return;
                }
                else
                {
                    errorProvider8.SetError(EnterpriseNamePlaceholder, string.Empty);
                }
            }
            if (IndividualRadioButton.Checked)
            {
                //firstname
                if (string.IsNullOrEmpty(FirstNamePlaceholder.Text.Trim()))
                {
                    errorProvider9.SetError(FirstNamePlaceholder, "This field is required.");
                    return;
                }
                else
                {
                    errorProvider9.SetError(FirstNamePlaceholder, string.Empty);
                }
                //lastname
                if (string.IsNullOrEmpty(LastNamePlaceholder.Text.Trim()))
                {
                    errorProvider10.SetError(LastNamePlaceholder, "This field is required.");
                    return;
                }
                else
                {
                    errorProvider10.SetError(LastNamePlaceholder, string.Empty);
                }
            }
            account.Username = UsernamePlaceholder.Text;
            account.Password = PasswordPlaceholder.Text;
            bool success = account.Insert();
            if (success)
            {
                PastaShopLogin form = new PastaShopLogin();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Unsuccessful registration.");
            }
        }

        private void UsernamePlaceholder_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterpriseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EnterpriseRadioButton.Checked)
            {
                JIBLabel.Visible = true;
                JIBPlaceholder.Visible = true;
                EnterpriseNameLabel.Visible = true;
                EnterpriseNamePlaceholder.Visible = true;
                FirstNameLabel.Visible = false;
                FirstNamePlaceholder.Visible = false;
                LastNameLabel.Visible = false;
                LastNamePlaceholder.Visible = false;
            }
        }

        private void IndividualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (IndividualRadioButton.Checked)
            {
                JIBLabel.Visible = false;
                JIBPlaceholder.Visible = false;
                EnterpriseNameLabel.Visible = false;
                EnterpriseNamePlaceholder.Visible = false;
                FirstNameLabel.Visible = true;
                FirstNamePlaceholder.Visible = true;
                LastNameLabel.Visible = true;
                LastNamePlaceholder.Visible = true;
            }
        }
    }
}
