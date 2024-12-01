namespace FinalProject_OOP
{
    partial class Feedback
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.cbbPrintBill = new System.Windows.Forms.ComboBox();
            this.cbbPayment = new System.Windows.Forms.ComboBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblPrintBill = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.cbbPrintBill);
            this.panel1.Controls.Add(this.cbbPayment);
            this.panel1.Controls.Add(this.txtFeedback);
            this.panel1.Controls.Add(this.lblFeedback);
            this.panel1.Controls.Add(this.lblPrintBill);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 526);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAccept.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(137, 443);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(127, 53);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbbPrintBill
            // 
            this.cbbPrintBill.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbbPrintBill.FormattingEnabled = true;
            this.cbbPrintBill.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbbPrintBill.Location = new System.Drawing.Point(46, 193);
            this.cbbPrintBill.Name = "cbbPrintBill";
            this.cbbPrintBill.Size = new System.Drawing.Size(121, 24);
            this.cbbPrintBill.TabIndex = 5;
            // 
            // cbbPayment
            // 
            this.cbbPayment.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbbPayment.FormattingEnabled = true;
            this.cbbPayment.Items.AddRange(new object[] {
            "Cash",
            "Bank transfer",
            "Visa"});
            this.cbbPayment.Location = new System.Drawing.Point(46, 103);
            this.cbbPayment.Name = "cbbPayment";
            this.cbbPayment.Size = new System.Drawing.Size(121, 24);
            this.cbbPayment.TabIndex = 4;
            // 
            // txtFeedback
            // 
            this.txtFeedback.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtFeedback.Location = new System.Drawing.Point(46, 288);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(306, 121);
            this.txtFeedback.TabIndex = 3;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(20, 257);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(286, 28);
            this.lblFeedback.TabIndex = 2;
            this.lblFeedback.Text = "Please give your feedback";
            // 
            // lblPrintBill
            // 
            this.lblPrintBill.AutoSize = true;
            this.lblPrintBill.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintBill.Location = new System.Drawing.Point(20, 162);
            this.lblPrintBill.Name = "lblPrintBill";
            this.lblPrintBill.Size = new System.Drawing.Size(307, 28);
            this.lblPrintBill.TabIndex = 1;
            this.lblPrintBill.Text = "Would you like to print bill?";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(20, 72);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(195, 28);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment Method";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(891, 526);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbbPrintBill;
        private System.Windows.Forms.ComboBox cbbPayment;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblPrintBill;
        private System.Windows.Forms.Label lblPayment;
    }
}