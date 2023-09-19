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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.OrderButton = new System.Windows.Forms.Button();
            this.TypePlaceholder = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
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
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 101);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(369, 293);
            this.dataGridViewOrder.TabIndex = 4;
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.OrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OrderButton.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.OrderButton.Location = new System.Drawing.Point(545, 402);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(105, 36);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "ORDER";
            this.OrderButton.UseVisualStyleBackColor = false;
            // 
            // TypePlaceholder
            // 
            this.TypePlaceholder.BackColor = System.Drawing.Color.PeachPuff;
            this.TypePlaceholder.Location = new System.Drawing.Point(563, 118);
            this.TypePlaceholder.Name = "TypePlaceholder";
            this.TypePlaceholder.Size = new System.Drawing.Size(137, 20);
            this.TypePlaceholder.TabIndex = 10;
            this.TypePlaceholder.Visible = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Tomato;
            this.UsernameLabel.Location = new System.Drawing.Point(427, 114);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 22);
            this.UsernameLabel.TabIndex = 11;
            this.UsernameLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(427, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(427, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Location = new System.Drawing.Point(563, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox2.Location = new System.Drawing.Point(563, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.AddToOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToOrderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddToOrderButton.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToOrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.AddToOrderButton.Location = new System.Drawing.Point(489, 290);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(172, 36);
            this.AddToOrderButton.TabIndex = 16;
            this.AddToOrderButton.Text = "Add To Order";
            this.AddToOrderButton.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TypePlaceholder);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.OrderLabel1);
            this.Controls.Add(this.OrderTitle);
            this.Controls.Add(this.LogoutButton);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.Label OrderLabel1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.TextBox TypePlaceholder;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddToOrderButton;
    }
}