namespace Pasta_Shop
{
    partial class OrderPage
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.OrderLabel1 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.OrderButton = new System.Windows.Forms.Button();
            this.IdPlaceholder = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityPlaceholder = new System.Windows.Forms.TextBox();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.YourOrderLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.dataGridViewOrder.Location = new System.Drawing.Point(240, 133);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(139, 293);
            this.dataGridViewOrder.TabIndex = 4;
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.OrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OrderButton.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.OrderButton.Location = new System.Drawing.Point(545, 390);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(105, 36);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "ORDER";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // IdPlaceholder
            // 
            this.IdPlaceholder.BackColor = System.Drawing.Color.PeachPuff;
            this.IdPlaceholder.Location = new System.Drawing.Point(591, 171);
            this.IdPlaceholder.Name = "IdPlaceholder";
            this.IdPlaceholder.Size = new System.Drawing.Size(137, 20);
            this.IdPlaceholder.TabIndex = 10;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Tomato;
            this.IdLabel.Location = new System.Drawing.Point(541, 171);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(26, 22);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "Id";
            this.IdLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.Tomato;
            this.QuantityLabel.Location = new System.Drawing.Point(394, 220);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(182, 22);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Quantity [pasta bag]";
            this.QuantityLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // QuantityPlaceholder
            // 
            this.QuantityPlaceholder.BackColor = System.Drawing.Color.PeachPuff;
            this.QuantityPlaceholder.Location = new System.Drawing.Point(591, 220);
            this.QuantityPlaceholder.Name = "QuantityPlaceholder";
            this.QuantityPlaceholder.Size = new System.Drawing.Size(137, 20);
            this.QuantityPlaceholder.TabIndex = 14;
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.AddToOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToOrderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddToOrderButton.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToOrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.AddToOrderButton.Location = new System.Drawing.Point(511, 328);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(172, 36);
            this.AddToOrderButton.TabIndex = 16;
            this.AddToOrderButton.Text = "Add To Order";
            this.AddToOrderButton.UseVisualStyleBackColor = false;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(214, 293);
            this.dataGridViewMenu.TabIndex = 17;
            // 
            // YourOrderLabel
            // 
            this.YourOrderLabel.AutoSize = true;
            this.YourOrderLabel.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourOrderLabel.ForeColor = System.Drawing.Color.Tomato;
            this.YourOrderLabel.Location = new System.Drawing.Point(256, 108);
            this.YourOrderLabel.Name = "YourOrderLabel";
            this.YourOrderLabel.Size = new System.Drawing.Size(109, 22);
            this.YourOrderLabel.TabIndex = 19;
            this.YourOrderLabel.Text = "Your Order";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Swis721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Click Here To See MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YourOrderLabel);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.QuantityPlaceholder);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdPlaceholder);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.OrderLabel1);
            this.Controls.Add(this.OrderTitle);
            this.Controls.Add(this.LogoutButton);
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.Label OrderLabel1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.TextBox IdPlaceholder;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityPlaceholder;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Label YourOrderLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}