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
            this.btnExitOrder = new System.Windows.Forms.Button();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.dataCart = new System.Windows.Forms.DataGridView();
            this.bgroundSearchButton = new System.Windows.Forms.PictureBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbPlaceOrder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.nudQantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.nudQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundSearchButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQantity)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.Tan;
            this.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantity.Controls.Add(this.btnPay);
            this.nudQuantity.Controls.Add(this.btnRemove);
            this.nudQuantity.Controls.Add(this.btnExitOrder);
            this.nudQuantity.Controls.Add(this.linklblLogOut);
            this.nudQuantity.Controls.Add(this.dataCart);
            this.nudQuantity.Controls.Add(this.bgroundSearchButton);
            this.nudQuantity.Controls.Add(this.lstOrder);
            this.nudQuantity.Controls.Add(this.txtSearch);
            this.nudQuantity.Controls.Add(this.cbxCategory);
            this.nudQuantity.Controls.Add(this.lbCategory);
            this.nudQuantity.Controls.Add(this.lbPlaceOrder);
            this.nudQuantity.Controls.Add(this.panel1);
            this.nudQuantity.Location = new System.Drawing.Point(13, 13);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(891, 526);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Paint += new System.Windows.Forms.PaintEventHandler(this.nudQuantity_Paint);
            // 
            // btnExitOrder
            // 
            this.btnExitOrder.BackColor = System.Drawing.Color.Tan;
            this.btnExitOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitOrder.Location = new System.Drawing.Point(856, 3);
            this.btnExitOrder.Name = "btnExitOrder";
            this.btnExitOrder.Size = new System.Drawing.Size(30, 30);
            this.btnExitOrder.TabIndex = 18;
            this.btnExitOrder.Text = "X";
            this.btnExitOrder.UseVisualStyleBackColor = false;
            this.btnExitOrder.Click += new System.EventHandler(this.btnExitOrder_Click);
            // 
            // linklblLogOut
            // 
            this.linklblLogOut.AutoSize = true;
            this.linklblLogOut.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogOut.Location = new System.Drawing.Point(75, 490);
            this.linklblLogOut.Name = "linklblLogOut";
            this.linklblLogOut.Size = new System.Drawing.Size(75, 21);
            this.linklblLogOut.TabIndex = 9;
            this.linklblLogOut.TabStop = true;
            this.linklblLogOut.Text = "LogOut";
            this.linklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogOut_LinkClicked);
            // 
            // dataCart
            // 
            this.dataCart.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataCart.GridColor = System.Drawing.Color.BlanchedAlmond;
            this.dataCart.Location = new System.Drawing.Point(240, 285);
            this.dataCart.Name = "dataCart";
            this.dataCart.RowHeadersWidth = 51;
            this.dataCart.RowTemplate.Height = 24;
            this.dataCart.Size = new System.Drawing.Size(614, 132);
            this.dataCart.TabIndex = 17;
            this.dataCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // lstOrder
            // 
            this.lstOrder.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 16;
            this.lstOrder.Location = new System.Drawing.Point(25, 202);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(174, 276);
            this.lstOrder.TabIndex = 4;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtSearch.Location = new System.Drawing.Point(26, 155);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(25, 103);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(174, 24);
            this.cbxCategory.TabIndex = 2;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbCategory.Location = new System.Drawing.Point(20, 68);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(113, 32);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Category";
            // 
            // lbPlaceOrder
            // 
            this.lbPlaceOrder.AutoSize = true;
            this.lbPlaceOrder.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaceOrder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbPlaceOrder.Location = new System.Drawing.Point(18, 17);
            this.lbPlaceOrder.Name = "lbPlaceOrder";
            this.lbPlaceOrder.Size = new System.Drawing.Size(191, 42);
            this.lbPlaceOrder.TabIndex = 0;
            this.lbPlaceOrder.Text = "Place Order";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Controls.Add(this.cbbTable);
            this.panel1.Controls.Add(this.cbxSize);
            this.panel1.Controls.Add(this.nudQantity);
            this.panel1.Controls.Add(this.btnAddCart);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.lbItem);
            this.panel1.Controls.Add(this.lbSize);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Location = new System.Drawing.Point(240, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 244);
            this.panel1.TabIndex = 16;
            // 
            // cbbTable
            // 
            this.cbbTable.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(168, 174);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(157, 24);
            this.cbbTable.TabIndex = 19;
            // 
            // cbxSize
            // 
            this.cbxSize.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(422, 41);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(157, 24);
            this.cbxSize.TabIndex = 18;
            this.cbxSize.SelectedIndexChanged += new System.EventHandler(this.cbxSize_SelectedIndexChanged);
            // 
            // nudQantity
            // 
            this.nudQantity.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nudQantity.Location = new System.Drawing.Point(168, 109);
            this.nudQantity.Name = "nudQantity";
            this.nudQantity.Size = new System.Drawing.Size(157, 22);
            this.nudQantity.TabIndex = 14;
            this.nudQantity.ValueChanged += new System.EventHandler(this.nudQantity_ValueChanged);
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.Chocolate;
            this.btnAddCart.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCart.Location = new System.Drawing.Point(422, 161);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(157, 37);
            this.btnAddCart.TabIndex = 15;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbQuantity.Location = new System.Drawing.Point(14, 99);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(112, 32);
            this.lbQuantity.TabIndex = 9;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(168, 41);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(157, 22);
            this.txtItemName.TabIndex = 11;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbItem.Location = new System.Drawing.Point(14, 32);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(142, 32);
            this.lbItem.TabIndex = 7;
            this.lbItem.Text = "Item Name";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbSize.Location = new System.Drawing.Point(355, 34);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(61, 32);
            this.lbSize.TabIndex = 10;
            this.lbSize.Text = "Size";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbPrice.Location = new System.Drawing.Point(348, 99);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(68, 32);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtPrice.Location = new System.Drawing.Point(422, 108);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTable.Location = new System.Drawing.Point(14, 166);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(76, 32);
            this.lblTable.TabIndex = 20;
            this.lblTable.Text = "Table";
            // 
            // Table
            // 
            this.Table.HeaderText = "Table";
            this.Table.MinimumWidth = 6;
            this.Table.Name = "Table";
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
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 4;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Size";
            this.Column3.MinimumWidth = 4;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 4;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Chocolate;
            this.btnRemove.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(338, 423);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 55);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Chocolate;
            this.btnPay.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(595, 423);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 55);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(916, 551);
            this.Controls.Add(this.nudQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.nudQuantity.ResumeLayout(false);
            this.nudQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundSearchButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQantity)).EndInit();
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
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.NumericUpDown nudQantity;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataCart;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.Button btnExitOrder;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRemove;
    }
}