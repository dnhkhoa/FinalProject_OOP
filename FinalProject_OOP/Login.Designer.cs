namespace FinalProject_OOP
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bgroundLogin = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsename = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.lblAccountYet = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgroundLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bgroundLogin
            // 
            this.bgroundLogin.Image = ((System.Drawing.Image)(resources.GetObject("bgroundLogin.Image")));
            this.bgroundLogin.Location = new System.Drawing.Point(0, -1);
            this.bgroundLogin.Name = "bgroundLogin";
            this.bgroundLogin.Size = new System.Drawing.Size(916, 551);
            this.bgroundLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgroundLogin.TabIndex = 0;
            this.bgroundLogin.TabStop = false;
            this.bgroundLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(128, 94);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(215, 34);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Ready to Login";
            // 
            // lbUsename
            // 
            this.lbUsename.AutoSize = true;
            this.lbUsename.BackColor = System.Drawing.Color.Transparent;
            this.lbUsename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsename.Location = new System.Drawing.Point(26, 165);
            this.lbUsename.Name = "lbUsename";
            this.lbUsename.Size = new System.Drawing.Size(102, 23);
            this.lbUsename.TabIndex = 2;
            this.lbUsename.Text = "Usename";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(147, 166);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(26, 235);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 23);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(147, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 34);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbOrder.Location = new System.Drawing.Point(154, 351);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(168, 20);
            this.lbOrder.TabIndex = 7;
            this.lbOrder.Text = "Continue as customer";
            this.lbOrder.Click += new System.EventHandler(this.lbOrder_Click);
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitLogin.Location = new System.Drawing.Point(0, -1);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(30, 30);
            this.btnExitLogin.TabIndex = 8;
            this.btnExitLogin.Text = "X";
            this.btnExitLogin.UseVisualStyleBackColor = false;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(203, 264);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(129, 20);
            this.checkBoxShowPass.TabIndex = 9;
            this.checkBoxShowPass.Text = "Show PassWord";
            this.checkBoxShowPass.UseVisualStyleBackColor = false;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // lblAccountYet
            // 
            this.lblAccountYet.AutoSize = true;
            this.lblAccountYet.Location = new System.Drawing.Point(102, 498);
            this.lblAccountYet.Name = "lblAccountYet";
            this.lblAccountYet.Size = new System.Drawing.Size(136, 16);
            this.lblAccountYet.TabIndex = 10;
            this.lblAccountYet.Text = "Have no account yet?";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRegister.Location = new System.Drawing.Point(255, 498);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(88, 16);
            this.lblRegister.TabIndex = 11;
            this.lblRegister.Text = "Register here";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 548);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblAccountYet);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUsename);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.bgroundLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgroundLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgroundLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsename;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Label lblAccountYet;
        private System.Windows.Forms.Label lblRegister;
    }
}