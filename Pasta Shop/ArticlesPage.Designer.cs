namespace Pasta_Shop
{
    partial class ArticlesPage
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
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdPastaLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.IdPastaPlaceholder = new System.Windows.Forms.TextBox();
            this.QuantityPlaceholder = new System.Windows.Forms.TextBox();
            this.PricePlaceholder = new System.Windows.Forms.TextBox();
            this.TypePlaceholder = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddArticleButton = new System.Windows.Forms.Button();
            this.DeleteArticleButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpdateQuantityButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertQuantityAddLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(533, 320);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(73, 36);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 388);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdPastaLabel
            // 
            this.IdPastaLabel.AutoSize = true;
            this.IdPastaLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.IdPastaLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPastaLabel.Location = new System.Drawing.Point(546, 258);
            this.IdPastaLabel.Name = "IdPastaLabel";
            this.IdPastaLabel.Size = new System.Drawing.Size(49, 16);
            this.IdPastaLabel.TabIndex = 2;
            this.IdPastaLabel.Text = "IdPasta";
            this.IdPastaLabel.Visible = false;
            this.IdPastaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.TypeLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(552, 24);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(32, 16);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TypeLabel.Visible = false;
            this.TypeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.PriceLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(552, 106);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 16);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.Visible = false;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.QuantityLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(542, 180);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(53, 16);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            this.QuantityLabel.Visible = false;
            // 
            // IdPastaPlaceholder
            // 
            this.IdPastaPlaceholder.BackColor = System.Drawing.Color.Gainsboro;
            this.IdPastaPlaceholder.Location = new System.Drawing.Point(501, 294);
            this.IdPastaPlaceholder.Name = "IdPastaPlaceholder";
            this.IdPastaPlaceholder.Size = new System.Drawing.Size(137, 20);
            this.IdPastaPlaceholder.TabIndex = 6;
            this.IdPastaPlaceholder.Visible = false;
            // 
            // QuantityPlaceholder
            // 
            this.QuantityPlaceholder.BackColor = System.Drawing.Color.Gainsboro;
            this.QuantityPlaceholder.Location = new System.Drawing.Point(501, 218);
            this.QuantityPlaceholder.Name = "QuantityPlaceholder";
            this.QuantityPlaceholder.Size = new System.Drawing.Size(137, 20);
            this.QuantityPlaceholder.TabIndex = 7;
            this.QuantityPlaceholder.Visible = false;
            // 
            // PricePlaceholder
            // 
            this.PricePlaceholder.BackColor = System.Drawing.Color.Gainsboro;
            this.PricePlaceholder.Location = new System.Drawing.Point(501, 140);
            this.PricePlaceholder.Name = "PricePlaceholder";
            this.PricePlaceholder.Size = new System.Drawing.Size(137, 20);
            this.PricePlaceholder.TabIndex = 8;
            this.PricePlaceholder.Visible = false;
            // 
            // TypePlaceholder
            // 
            this.TypePlaceholder.BackColor = System.Drawing.Color.Gainsboro;
            this.TypePlaceholder.Location = new System.Drawing.Point(501, 63);
            this.TypePlaceholder.Name = "TypePlaceholder";
            this.TypePlaceholder.Size = new System.Drawing.Size(137, 20);
            this.TypePlaceholder.TabIndex = 9;
            this.TypePlaceholder.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(533, 352);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(73, 36);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddArticleButton
            // 
            this.AddArticleButton.Location = new System.Drawing.Point(13, 411);
            this.AddArticleButton.Name = "AddArticleButton";
            this.AddArticleButton.Size = new System.Drawing.Size(137, 36);
            this.AddArticleButton.TabIndex = 11;
            this.AddArticleButton.Text = "Add New Article";
            this.AddArticleButton.UseVisualStyleBackColor = true;
            this.AddArticleButton.Click += new System.EventHandler(this.AddArticleButton_Click);
            // 
            // DeleteArticleButton
            // 
            this.DeleteArticleButton.Location = new System.Drawing.Point(172, 411);
            this.DeleteArticleButton.Name = "DeleteArticleButton";
            this.DeleteArticleButton.Size = new System.Drawing.Size(137, 36);
            this.DeleteArticleButton.TabIndex = 12;
            this.DeleteArticleButton.Text = "Delete Article";
            this.DeleteArticleButton.UseVisualStyleBackColor = true;
            this.DeleteArticleButton.Click += new System.EventHandler(this.DeleteArticleButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // UpdateQuantityButton
            // 
            this.UpdateQuantityButton.Location = new System.Drawing.Point(331, 411);
            this.UpdateQuantityButton.Name = "UpdateQuantityButton";
            this.UpdateQuantityButton.Size = new System.Drawing.Size(137, 36);
            this.UpdateQuantityButton.TabIndex = 13;
            this.UpdateQuantityButton.Text = "Update Quantity";
            this.UpdateQuantityButton.UseVisualStyleBackColor = true;
            this.UpdateQuantityButton.Click += new System.EventHandler(this.UpdateQuantityButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(533, 338);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(73, 36);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertQuantityAddLabel
            // 
            this.InsertQuantityAddLabel.AutoSize = true;
            this.InsertQuantityAddLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.InsertQuantityAddLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertQuantityAddLabel.Location = new System.Drawing.Point(498, 180);
            this.InsertQuantityAddLabel.Name = "InsertQuantityAddLabel";
            this.InsertQuantityAddLabel.Size = new System.Drawing.Size(127, 16);
            this.InsertQuantityAddLabel.TabIndex = 15;
            this.InsertQuantityAddLabel.Text = "Insert Quantity To Add";
            this.InsertQuantityAddLabel.Visible = false;
            // 
            // ArticlesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.InsertQuantityAddLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateQuantityButton);
            this.Controls.Add(this.DeleteArticleButton);
            this.Controls.Add(this.AddArticleButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TypePlaceholder);
            this.Controls.Add(this.PricePlaceholder);
            this.Controls.Add(this.QuantityPlaceholder);
            this.Controls.Add(this.IdPastaPlaceholder);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.IdPastaLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddButton);
            this.Name = "ArticlesPage";
            this.Size = new System.Drawing.Size(763, 496);
            this.Load += new System.EventHandler(this.Articles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IdPastaLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox IdPastaPlaceholder;
        private System.Windows.Forms.TextBox QuantityPlaceholder;
        private System.Windows.Forms.TextBox PricePlaceholder;
        private System.Windows.Forms.TextBox TypePlaceholder;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddArticleButton;
        private System.Windows.Forms.Button DeleteArticleButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button UpdateQuantityButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label InsertQuantityAddLabel;
    }
}
