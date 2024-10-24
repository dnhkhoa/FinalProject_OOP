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
            ((System.ComponentModel.ISupportInitialize)(this.bgroundLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bgroundLogin
            // 
            this.bgroundLogin.Image = ((System.Drawing.Image)(resources.GetObject("bgroundLogin.Image")));
            this.bgroundLogin.Location = new System.Drawing.Point(0, -1);
            this.bgroundLogin.Name = "bgroundLogin";
            this.bgroundLogin.Size = new System.Drawing.Size(916, 552);
            this.bgroundLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgroundLogin.TabIndex = 0;
            this.bgroundLogin.TabStop = false;
            this.bgroundLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(111, 100);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(221, 34);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Ready to Login";
            // 
            // lbUsename
            // 
            this.lbUsename.AutoSize = true;
            this.lbUsename.BackColor = System.Drawing.Color.Transparent;
            this.lbUsename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsename.Location = new System.Drawing.Point(40, 167);
            this.lbUsename.Name = "lbUsename";
            this.lbUsename.Size = new System.Drawing.Size(102, 23);
            this.lbUsename.TabIndex = 2;
            this.lbUsename.Text = "Usename";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 548);
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
    }
}