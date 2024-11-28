namespace FinalProject_OOP
{
    partial class UC_PlaceOrder
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
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxItemName = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.nudQantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(27, 30);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(211, 39);
            this.lblPlaceOrder.TabIndex = 1;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxItemName);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.cbxTable);
            this.panel2.Controls.Add(this.lblTable);
            this.panel2.Controls.Add(this.cbxSize);
            this.panel2.Controls.Add(this.nudQantity);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lbItem);
            this.panel2.Controls.Add(this.lblSize);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Location = new System.Drawing.Point(351, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 265);
            this.panel2.TabIndex = 17;
            // 
            // cbxItemName
            // 
            this.cbxItemName.FormattingEnabled = true;
            this.cbxItemName.Location = new System.Drawing.Point(146, 10);
            this.cbxItemName.Name = "cbxItemName";
            this.cbxItemName.Size = new System.Drawing.Size(158, 24);
            this.cbxItemName.TabIndex = 22;
            this.cbxItemName.SelectedIndexChanged += new System.EventHandler(this.cbxItemName_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Chocolate;
            this.btnPay.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPay.Location = new System.Drawing.Point(189, 222);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(91, 37);
            this.btnPay.TabIndex = 21;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // cbxTable
            // 
            this.cbxTable.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Location = new System.Drawing.Point(146, 181);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(157, 24);
            this.cbxTable.TabIndex = 20;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTable.Location = new System.Drawing.Point(3, 182);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(66, 23);
            this.lblTable.TabIndex = 19;
            this.lblTable.Text = "Table";
            // 
            // cbxSize
            // 
            this.cbxSize.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(146, 50);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(157, 24);
            this.cbxSize.TabIndex = 18;
            this.cbxSize.SelectedIndexChanged += new System.EventHandler(this.cbxSize_SelectedIndexChanged);
            // 
            // nudQantity
            // 
            this.nudQantity.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nudQantity.Location = new System.Drawing.Point(146, 96);
            this.nudQantity.Name = "nudQantity";
            this.nudQantity.Size = new System.Drawing.Size(157, 22);
            this.nudQantity.TabIndex = 14;
            this.nudQantity.ValueChanged += new System.EventHandler(this.nudQantity_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chocolate;
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(36, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblQuantity.Location = new System.Drawing.Point(3, 95);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(102, 23);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbItem.Location = new System.Drawing.Point(3, 10);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(124, 23);
            this.lbItem.TabIndex = 7;
            this.lbItem.Text = "Item Name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSize.Location = new System.Drawing.Point(3, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(53, 23);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Size";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPrice.Location = new System.Drawing.Point(3, 137);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 23);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtPrice.Location = new System.Drawing.Point(146, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table,
            this.ItemName,
            this.Quantity,
            this.ItemSize,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(352, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(320, 222);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(331, 434);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // Table
            // 
            this.Table.HeaderText = "Table";
            this.Table.MinimumWidth = 6;
            this.Table.Name = "Table";
            this.Table.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 55F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // ItemSize
            // 
            this.ItemSize.HeaderText = "Size";
            this.ItemSize.MinimumWidth = 6;
            this.ItemSize.Name = "ItemSize";
            this.ItemSize.Width = 50;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPlaceOrder);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(689, 527);
            this.Load += new System.EventHandler(this.UC_PlaceOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.NumericUpDown nudQantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
