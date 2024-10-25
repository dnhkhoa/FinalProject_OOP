namespace FinalProject_OOP
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.nudQuantity = new System.Windows.Forms.Panel();
            this.lbPlaceOrder = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.bgroundExitOrder = new System.Windows.Forms.PictureBox();
            this.bgroundSearchButton = new System.Windows.Forms.PictureBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundExitOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundSearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuantity
            // 
            this.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantity.Controls.Add(this.dataGridView1);
            this.nudQuantity.Controls.Add(this.numericUpDown1);
            this.nudQuantity.Controls.Add(this.textBox1);
            this.nudQuantity.Controls.Add(this.lbQuantity);
            this.nudQuantity.Controls.Add(this.lbItem);
            this.nudQuantity.Controls.Add(this.bgroundSearchButton);
            this.nudQuantity.Controls.Add(this.bgroundExitOrder);
            this.nudQuantity.Controls.Add(this.lstOrder);
            this.nudQuantity.Controls.Add(this.txtSearch);
            this.nudQuantity.Controls.Add(this.cbxCategory);
            this.nudQuantity.Controls.Add(this.lbCategory);
            this.nudQuantity.Controls.Add(this.lbPlaceOrder);
            this.nudQuantity.Controls.Add(this.panel1);
            this.nudQuantity.Location = new System.Drawing.Point(13, 13);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(726, 532);
            this.nudQuantity.TabIndex = 0;
            // 
            // lbPlaceOrder
            // 
            this.lbPlaceOrder.AutoSize = true;
            this.lbPlaceOrder.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaceOrder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPlaceOrder.Location = new System.Drawing.Point(18, 17);
            this.lbPlaceOrder.Name = "lbPlaceOrder";
            this.lbPlaceOrder.Size = new System.Drawing.Size(191, 42);
            this.lbPlaceOrder.TabIndex = 0;
            this.lbPlaceOrder.Text = "Place Order";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(20, 68);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(111, 32);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Drink",
            "Cake"});
            this.cbxCategory.Location = new System.Drawing.Point(25, 103);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(174, 24);
            this.cbxCategory.TabIndex = 2;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 155);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 16;
            this.lstOrder.Location = new System.Drawing.Point(25, 202);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(174, 308);
            this.lstOrder.TabIndex = 4;
            // 
            // bgroundExitOrder
            // 
            this.bgroundExitOrder.Image = ((System.Drawing.Image)(resources.GetObject("bgroundExitOrder.Image")));
            this.bgroundExitOrder.Location = new System.Drawing.Point(696, -2);
            this.bgroundExitOrder.Name = "bgroundExitOrder";
            this.bgroundExitOrder.Size = new System.Drawing.Size(30, 31);
            this.bgroundExitOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgroundExitOrder.TabIndex = 5;
            this.bgroundExitOrder.TabStop = false;
            // 
            // bgroundSearchButton
            // 
            this.bgroundSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("bgroundSearchButton.Image")));
            this.bgroundSearchButton.Location = new System.Drawing.Point(172, 155);
            this.bgroundSearchButton.Name = "bgroundSearchButton";
            this.bgroundSearchButton.Size = new System.Drawing.Size(27, 22);
            this.bgroundSearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgroundSearchButton.TabIndex = 6;
            this.bgroundSearchButton.TabStop = false;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(277, 68);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(137, 32);
            this.lbItem.TabIndex = 7;
            this.lbItem.Text = "Item Name";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(269, 111);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(68, 32);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(277, 146);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(110, 32);
            this.lbQuantity.TabIndex = 9;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(269, 33);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(61, 32);
            this.lbSize.TabIndex = 10;
            this.lbSize.Text = "Size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(283, 181);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(157, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(314, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbSize);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(240, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 244);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(240, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 145);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 4;
            this.Column2.Name = "Column2";
            this.Column2.Width = 98;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 4;
            this.Column3.Name = "Column3";
            this.Column3.Width = 98;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 4;
            this.Column4.Name = "Column4";
            this.Column4.Width = 98;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 557);
            this.Controls.Add(this.nudQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.nudQuantity.ResumeLayout(false);
            this.nudQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundExitOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundSearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nudQuantity;
        private System.Windows.Forms.Label lbPlaceOrder;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox bgroundSearchButton;
        private System.Windows.Forms.PictureBox bgroundExitOrder;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}