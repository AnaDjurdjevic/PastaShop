namespace Pasta_Shop
{
    partial class OrdersPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpecificOrder = new System.Windows.Forms.DataGridView();
            this.ConfNumLabel = new System.Windows.Forms.Label();
            this.ConfNumPlaceholder = new System.Windows.Forms.TextBox();
            this.SeeOrderButton = new System.Windows.Forms.Button();
            this.ChangeStatusLabel = new System.Windows.Forms.Label();
            this.ChangeStatusButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecificOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(24, 13);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(372, 206);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // dataGridViewSpecificOrder
            // 
            this.dataGridViewSpecificOrder.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewSpecificOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecificOrder.Location = new System.Drawing.Point(24, 225);
            this.dataGridViewSpecificOrder.Name = "dataGridViewSpecificOrder";
            this.dataGridViewSpecificOrder.Size = new System.Drawing.Size(372, 194);
            this.dataGridViewSpecificOrder.TabIndex = 1;
            // 
            // ConfNumLabel
            // 
            this.ConfNumLabel.BackColor = System.Drawing.Color.MistyRose;
            this.ConfNumLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfNumLabel.Location = new System.Drawing.Point(445, 48);
            this.ConfNumLabel.Name = "ConfNumLabel";
            this.ConfNumLabel.Size = new System.Drawing.Size(164, 51);
            this.ConfNumLabel.TabIndex = 4;
            this.ConfNumLabel.Text = "Insert Confirmation Number To See Order ";
            this.ConfNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfNumLabel.Click += new System.EventHandler(this.ConfNumLabel_Click);
            // 
            // ConfNumPlaceholder
            // 
            this.ConfNumPlaceholder.BackColor = System.Drawing.Color.Gainsboro;
            this.ConfNumPlaceholder.Location = new System.Drawing.Point(463, 102);
            this.ConfNumPlaceholder.Name = "ConfNumPlaceholder";
            this.ConfNumPlaceholder.Size = new System.Drawing.Size(137, 20);
            this.ConfNumPlaceholder.TabIndex = 10;
            this.ConfNumPlaceholder.TextChanged += new System.EventHandler(this.ConfNumPlaceholder_TextChanged);
            // 
            // SeeOrderButton
            // 
            this.SeeOrderButton.Location = new System.Drawing.Point(488, 128);
            this.SeeOrderButton.Name = "SeeOrderButton";
            this.SeeOrderButton.Size = new System.Drawing.Size(91, 36);
            this.SeeOrderButton.TabIndex = 15;
            this.SeeOrderButton.Text = "SEE ORDER";
            this.SeeOrderButton.UseVisualStyleBackColor = true;
            this.SeeOrderButton.Click += new System.EventHandler(this.SeeOrderButton_Click);
            // 
            // ChangeStatusLabel
            // 
            this.ChangeStatusLabel.BackColor = System.Drawing.Color.MistyRose;
            this.ChangeStatusLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeStatusLabel.Location = new System.Drawing.Point(445, 221);
            this.ChangeStatusLabel.Name = "ChangeStatusLabel";
            this.ChangeStatusLabel.Size = new System.Drawing.Size(164, 51);
            this.ChangeStatusLabel.TabIndex = 16;
            this.ChangeStatusLabel.Text = "Change Order Status To Processed";
            this.ChangeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeStatusLabel.Click += new System.EventHandler(this.ChangeStatusLabel_Click);
            // 
            // ChangeStatusButton
            // 
            this.ChangeStatusButton.Location = new System.Drawing.Point(488, 275);
            this.ChangeStatusButton.Name = "ChangeStatusButton";
            this.ChangeStatusButton.Size = new System.Drawing.Size(91, 36);
            this.ChangeStatusButton.TabIndex = 17;
            this.ChangeStatusButton.Text = "CHANGE";
            this.ChangeStatusButton.UseVisualStyleBackColor = true;
            this.ChangeStatusButton.Click += new System.EventHandler(this.ChangeStatusButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.ChangeStatusButton);
            this.Controls.Add(this.ChangeStatusLabel);
            this.Controls.Add(this.SeeOrderButton);
            this.Controls.Add(this.ConfNumPlaceholder);
            this.Controls.Add(this.ConfNumLabel);
            this.Controls.Add(this.dataGridViewSpecificOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "OrdersPage";
            this.Size = new System.Drawing.Size(727, 433);
            this.Load += new System.EventHandler(this.orders1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecificOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewSpecificOrder;
        private System.Windows.Forms.Label ConfNumLabel;
        private System.Windows.Forms.TextBox ConfNumPlaceholder;
        private System.Windows.Forms.Button SeeOrderButton;
        private System.Windows.Forms.Label ChangeStatusLabel;
        private System.Windows.Forms.Button ChangeStatusButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
