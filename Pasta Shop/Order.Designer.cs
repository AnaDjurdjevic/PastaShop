namespace Pasta_Shop
{
    partial class Order
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.OrderLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(713, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OrderTitle
            // 
            this.OrderTitle.AutoSize = true;
            this.OrderTitle.Font = new System.Drawing.Font("Swis721 Blk BT", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTitle.ForeColor = System.Drawing.Color.Tomato;
            this.OrderTitle.Location = new System.Drawing.Point(276, 9);
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(230, 64);
            this.OrderTitle.TabIndex = 2;
            this.OrderTitle.Text = "ORDER";
            this.OrderTitle.Click += new System.EventHandler(this.OrderTitle_Click);
            // 
            // OrderLabel1
            // 
            this.OrderLabel1.AutoSize = true;
            this.OrderLabel1.Font = new System.Drawing.Font("Swis721 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel1.ForeColor = System.Drawing.Color.Tomato;
            this.OrderLabel1.Location = new System.Drawing.Point(313, 64);
            this.OrderLabel1.Name = "OrderLabel1";
            this.OrderLabel1.Size = new System.Drawing.Size(157, 25);
            this.OrderLabel1.TabIndex = 3;
            this.OrderLabel1.Text = "Make an order";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderLabel1);
            this.Controls.Add(this.OrderTitle);
            this.Controls.Add(this.LogoutButton);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.Label OrderLabel1;
    }
}