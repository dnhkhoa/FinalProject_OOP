﻿namespace FinalProject_OOP
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_PlaceOrder1 = new FinalProject_OOP.UC_PlaceOrder();
            this.uC_Income1 = new FinalProject_OOP.UC_Income();
            this.uC_RemoveItems1 = new FinalProject_OOP.UC_RemoveItems();
            this.uC_UpdateItems1 = new FinalProject_OOP.UC_UpdateItems();
            this.uC_AddItems1 = new FinalProject_OOP.UC_AddItems();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.lblRegister);
            this.panel1.Controls.Add(this.btnExitMain);
            this.panel1.Controls.Add(this.linklblLogOut);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnUpdateItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 527);
            this.panel1.TabIndex = 0;
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackColor = System.Drawing.Color.Tan;
            this.btnExitMain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMain.Location = new System.Drawing.Point(3, 3);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(30, 30);
            this.btnExitMain.TabIndex = 9;
            this.btnExitMain.Text = "X";
            this.btnExitMain.UseVisualStyleBackColor = false;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // linklblLogOut
            // 
            this.linklblLogOut.AutoSize = true;
            this.linklblLogOut.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogOut.ForeColor = System.Drawing.Color.MediumBlue;
            this.linklblLogOut.Location = new System.Drawing.Point(65, 482);
            this.linklblLogOut.Name = "linklblLogOut";
            this.linklblLogOut.Size = new System.Drawing.Size(75, 21);
            this.linklblLogOut.TabIndex = 8;
            this.linklblLogOut.TabStop = true;
            this.linklblLogOut.Text = "LogOut";
            this.linklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogOut_LinkClicked);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnIncome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnIncome.Location = new System.Drawing.Point(14, 328);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(202, 54);
            this.btnIncome.TabIndex = 5;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRemoveItems.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRemoveItems.Location = new System.Drawing.Point(14, 258);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(202, 54);
            this.btnRemoveItems.TabIndex = 3;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnUpdateItems.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdateItems.Location = new System.Drawing.Point(14, 188);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(202, 54);
            this.btnUpdateItems.TabIndex = 2;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddItems.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddItems.Location = new System.Drawing.Point(14, 117);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(202, 54);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPlaceOrder.Location = new System.Drawing.Point(14, 47);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(202, 54);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_Income1);
            this.panel2.Controls.Add(this.uC_RemoveItems1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_AddItems1);
            this.panel2.Location = new System.Drawing.Point(214, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 527);
            this.panel2.TabIndex = 1;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.BurlyWood;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(690, 527);
            this.uC_PlaceOrder1.TabIndex = 4;
            this.uC_PlaceOrder1.Load += new System.EventHandler(this.uC_PlaceOrder1_Load);
            // 
            // uC_Income1
            // 
            this.uC_Income1.BackColor = System.Drawing.Color.BurlyWood;
            this.uC_Income1.Location = new System.Drawing.Point(0, 0);
            this.uC_Income1.Name = "uC_Income1";
            this.uC_Income1.Size = new System.Drawing.Size(690, 527);
            this.uC_Income1.TabIndex = 3;
            // 
            // uC_RemoveItems1
            // 
            this.uC_RemoveItems1.BackColor = System.Drawing.Color.BurlyWood;
            this.uC_RemoveItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItems1.Name = "uC_RemoveItems1";
            this.uC_RemoveItems1.Size = new System.Drawing.Size(690, 527);
            this.uC_RemoveItems1.TabIndex = 2;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.BurlyWood;
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(690, 527);
            this.uC_UpdateItems1.TabIndex = 1;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.BurlyWood;
            this.uC_AddItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(690, 527);
            this.uC_AddItems1.TabIndex = 0;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblRegister.Location = new System.Drawing.Point(66, 454);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(80, 22);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.Text = "Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAccount.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAccount.Location = new System.Drawing.Point(14, 397);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(202, 54);
            this.btnAccount.TabIndex = 13;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(916, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.Button btnExitMain;
        private UC_AddItems uC_AddItems1;
        private UC_UpdateItems uC_UpdateItems1;
        private UC_RemoveItems uC_RemoveItems1;
        private UC_Income uC_Income1;
        private UC_PlaceOrder uC_PlaceOrder1;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnAccount;
    }
}