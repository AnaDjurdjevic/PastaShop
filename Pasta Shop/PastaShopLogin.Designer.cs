namespace Pasta_Shop
{
    partial class PastaShopLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastaShopLogin));
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernamePlaceholder = new System.Windows.Forms.TextBox();
            this.PasswordPlaceholder = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.HaveAccountLabel = new System.Windows.Forms.Label();
            this.RegisterLink = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(-10, -72);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(394, 525);
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Swis721 Blk BT", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.ForeColor = System.Drawing.Color.Tomato;
            this.LoginTitle.Location = new System.Drawing.Point(390, 53);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(398, 64);
            this.LoginTitle.TabIndex = 1;
            this.LoginTitle.Text = "PASTA SHOP";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Tomato;
            this.UsernameLabel.Location = new System.Drawing.Point(412, 194);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(130, 25);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Tomato;
            this.PasswordLabel.Location = new System.Drawing.Point(412, 256);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(125, 25);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernamePlaceholder
            // 
            this.UsernamePlaceholder.AcceptsReturn = true;
            this.UsernamePlaceholder.BackColor = System.Drawing.Color.PeachPuff;
            this.UsernamePlaceholder.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernamePlaceholder.ForeColor = System.Drawing.Color.Tomato;
            this.UsernamePlaceholder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsernamePlaceholder.Location = new System.Drawing.Point(569, 194);
            this.UsernamePlaceholder.Name = "UsernamePlaceholder";
            this.UsernamePlaceholder.Size = new System.Drawing.Size(184, 25);
            this.UsernamePlaceholder.TabIndex = 4;
            this.UsernamePlaceholder.TextChanged += new System.EventHandler(this.UsernamePlaceholder_TextChanged);
            // 
            // PasswordPlaceholder
            // 
            this.PasswordPlaceholder.BackColor = System.Drawing.Color.PeachPuff;
            this.PasswordPlaceholder.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordPlaceholder.ForeColor = System.Drawing.Color.Tomato;
            this.PasswordPlaceholder.Location = new System.Drawing.Point(569, 256);
            this.PasswordPlaceholder.Name = "PasswordPlaceholder";
            this.PasswordPlaceholder.Size = new System.Drawing.Size(184, 25);
            this.PasswordPlaceholder.TabIndex = 5;
            this.PasswordPlaceholder.TextChanged += new System.EventHandler(this.PasswordPlaceholder_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.PeachPuff;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginButton.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Tomato;
            this.LoginButton.Location = new System.Drawing.Point(540, 322);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(105, 36);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // HaveAccountLabel
            // 
            this.HaveAccountLabel.AutoSize = true;
            this.HaveAccountLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaveAccountLabel.ForeColor = System.Drawing.Color.Tomato;
            this.HaveAccountLabel.Location = new System.Drawing.Point(414, 388);
            this.HaveAccountLabel.Name = "HaveAccountLabel";
            this.HaveAccountLabel.Size = new System.Drawing.Size(122, 15);
            this.HaveAccountLabel.TabIndex = 8;
            this.HaveAccountLabel.Text = "Don\'t have an account?";
            this.HaveAccountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterLink
            // 
            this.RegisterLink.BackColor = System.Drawing.Color.PeachPuff;
            this.RegisterLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLink.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLink.ForeColor = System.Drawing.Color.Tomato;
            this.RegisterLink.Location = new System.Drawing.Point(542, 383);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(156, 25);
            this.RegisterLink.TabIndex = 9;
            this.RegisterLink.Text = "Click here to register";
            this.RegisterLink.UseVisualStyleBackColor = false;
            this.RegisterLink.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // PastaShopLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.HaveAccountLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordPlaceholder);
            this.Controls.Add(this.UsernamePlaceholder);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.pictureBoxLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PastaShopLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PastaShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PastaShopLogin_FormClosed);
            this.Load += new System.EventHandler(this.PastaShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernamePlaceholder;
        private System.Windows.Forms.TextBox PasswordPlaceholder;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label HaveAccountLabel;
        private System.Windows.Forms.Button RegisterLink;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

