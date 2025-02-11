﻿namespace Pasta_Shop
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
            this.Panel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.articlesPage1 = new Pasta_Shop.ArticlesPage();
            this.ordersPage1 = new Pasta_Shop.OrdersPage();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(0, 76);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(102, 81);
            this.OrdersButton.TabIndex = 1;
            this.OrdersButton.Text = "ORDERS";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ArticlesButton
            // 
            this.ArticlesButton.Location = new System.Drawing.Point(1, 0);
            this.ArticlesButton.Name = "ArticlesButton";
            this.ArticlesButton.Size = new System.Drawing.Size(102, 81);
            this.ArticlesButton.TabIndex = 2;
            this.ArticlesButton.Text = "ARTICLES";
            this.ArticlesButton.UseVisualStyleBackColor = true;
            this.ArticlesButton.Click += new System.EventHandler(this.ArticlesButton_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.LogoutButton);
            this.Panel.Controls.Add(this.OrdersButton);
            this.Panel.Controls.Add(this.ArticlesButton);
            this.Panel.Location = new System.Drawing.Point(1, 2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(106, 448);
            this.Panel.TabIndex = 6;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(0, 409);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(102, 39);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // articlesPage1
            // 
            this.articlesPage1.BackColor = System.Drawing.Color.PeachPuff;
            this.articlesPage1.Location = new System.Drawing.Point(103, 2);
            this.articlesPage1.Name = "articlesPage1";
            this.articlesPage1.Size = new System.Drawing.Size(681, 488);
            this.articlesPage1.TabIndex = 8;
            // 
            // ordersPage1
            // 
            this.ordersPage1.BackColor = System.Drawing.Color.MistyRose;
            this.ordersPage1.Location = new System.Drawing.Point(103, 2);
            this.ordersPage1.Name = "ordersPage1";
            this.ordersPage1.Size = new System.Drawing.Size(681, 448);
            this.ordersPage1.TabIndex = 7;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.articlesPage1);
            this.Controls.Add(this.ordersPage1);
            this.Controls.Add(this.Panel);
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePage";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ArticlesButton;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button LogoutButton;
        private OrdersPage ordersPage1;
        private ArticlesPage articlesPage1;
    }
}