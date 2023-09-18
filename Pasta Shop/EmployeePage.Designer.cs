namespace Pasta_Shop
{
    partial class EmployeePage
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ArticlesButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.articles1 = new Pasta_Shop.Articles();
            this.orders1 = new Pasta_Shop.orders1();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(0, 0);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(106, 81);
            this.OrdersButton.TabIndex = 1;
            this.OrdersButton.Text = "ORDERS";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ArticlesButton
            // 
            this.ArticlesButton.Location = new System.Drawing.Point(0, 78);
            this.ArticlesButton.Name = "ArticlesButton";
            this.ArticlesButton.Size = new System.Drawing.Size(106, 81);
            this.ArticlesButton.TabIndex = 2;
            this.ArticlesButton.Text = "ARTICLES";
            this.ArticlesButton.UseVisualStyleBackColor = true;
            this.ArticlesButton.Click += new System.EventHandler(this.ArticlesButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 81);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.LogoutButton);
            this.Panel.Controls.Add(this.OrdersButton);
            this.Panel.Controls.Add(this.ArticlesButton);
            this.Panel.Controls.Add(this.button4);
            this.Panel.Controls.Add(this.button3);
            this.Panel.Location = new System.Drawing.Point(1, 2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(106, 448);
            this.Panel.TabIndex = 6;
            // 
            // articles1
            // 
            this.articles1.BackColor = System.Drawing.Color.NavajoWhite;
            this.articles1.Location = new System.Drawing.Point(106, 2);
            this.articles1.Name = "articles1";
            this.articles1.Size = new System.Drawing.Size(694, 448);
            this.articles1.TabIndex = 5;
            this.articles1.Load += new System.EventHandler(this.articles1_Load);
            // 
            // orders1
            // 
            this.orders1.BackColor = System.Drawing.Color.MistyRose;
            this.orders1.Location = new System.Drawing.Point(106, 2);
            this.orders1.Name = "orders1";
            this.orders1.Size = new System.Drawing.Size(694, 448);
            this.orders1.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(0, 409);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(106, 39);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.articles1);
            this.Controls.Add(this.orders1);
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePage";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private orders1 orders1;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ArticlesButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Articles articles1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button LogoutButton;
    }
}