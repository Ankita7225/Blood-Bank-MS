
namespace Blood_Bank_MS
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnnewregister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.PBuser = new System.Windows.Forms.PictureBox();
            this.PBpassword = new System.Windows.Forms.PictureBox();
            this.CBshowpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blood_Bank_MS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(148, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(19, 214);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 21);
            this.lblPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(73, 223);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(76, 287);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLogin.Location = new System.Drawing.Point(148, 364);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 37);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnnewregister
            // 
            this.btnnewregister.BackColor = System.Drawing.Color.Transparent;
            this.btnnewregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnewregister.FlatAppearance.BorderSize = 0;
            this.btnnewregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnewregister.ForeColor = System.Drawing.Color.Transparent;
            this.btnnewregister.Location = new System.Drawing.Point(208, 449);
            this.btnnewregister.Name = "btnnewregister";
            this.btnnewregister.Size = new System.Drawing.Size(203, 44);
            this.btnnewregister.TabIndex = 8;
            this.btnnewregister.Text = "New Register";
            this.btnnewregister.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 58);
            this.panel1.TabIndex = 9;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbltitle.Location = new System.Drawing.Point(80, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(244, 25);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // PBuser
            // 
            this.PBuser.Image = global::Blood_Bank_MS.Properties.Resources.user;
            this.PBuser.Location = new System.Drawing.Point(22, 219);
            this.PBuser.Name = "PBuser";
            this.PBuser.Size = new System.Drawing.Size(30, 30);
            this.PBuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBuser.TabIndex = 10;
            this.PBuser.TabStop = false;
            // 
            // PBpassword
            // 
            this.PBpassword.Image = global::Blood_Bank_MS.Properties.Resources._lock;
            this.PBpassword.Location = new System.Drawing.Point(26, 284);
            this.PBpassword.Name = "PBpassword";
            this.PBpassword.Size = new System.Drawing.Size(30, 30);
            this.PBpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBpassword.TabIndex = 11;
            this.PBpassword.TabStop = false;
            // 
            // CBshowpassword
            // 
            this.CBshowpassword.AutoSize = true;
            this.CBshowpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBshowpassword.Location = new System.Drawing.Point(215, 325);
            this.CBshowpassword.Name = "CBshowpassword";
            this.CBshowpassword.Size = new System.Drawing.Size(108, 19);
            this.CBshowpassword.TabIndex = 12;
            this.CBshowpassword.Text = "Show Password";
            this.CBshowpassword.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(371, 496);
            this.Controls.Add(this.CBshowpassword);
            this.Controls.Add(this.PBpassword);
            this.Controls.Add(this.PBuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnnewregister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnnewregister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox PBuser;
        private System.Windows.Forms.PictureBox PBpassword;
        private System.Windows.Forms.CheckBox CBshowpassword;
    }
}

