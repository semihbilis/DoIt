
namespace DoIt.WindowsFormsApp
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnJoinnow = new System.Windows.Forms.Button();
            this.btnSingin = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.tbxRPassword = new System.Windows.Forms.TextBox();
            this.tbxRName = new System.Windows.Forms.TextBox();
            this.tbxREmail = new System.Windows.Forms.TextBox();
            this.lblRName = new System.Windows.Forms.Label();
            this.tbxRSurname = new System.Windows.Forms.TextBox();
            this.lblRSurname = new System.Windows.Forms.Label();
            this.lblREmail = new System.Windows.Forms.Label();
            this.btnRRegister = new System.Windows.Forms.Button();
            this.lblRPassword = new System.Windows.Forms.Label();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 15);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // btnJoinnow
            // 
            this.btnJoinnow.Location = new System.Drawing.Point(17, 64);
            this.btnJoinnow.Name = "btnJoinnow";
            this.btnJoinnow.Size = new System.Drawing.Size(75, 23);
            this.btnJoinnow.TabIndex = 3;
            this.btnJoinnow.Text = "Join Now";
            this.btnJoinnow.UseVisualStyleBackColor = true;
            this.btnJoinnow.Click += new System.EventHandler(this.btnJoinnow_Click);
            // 
            // btnSingin
            // 
            this.btnSingin.Location = new System.Drawing.Point(98, 64);
            this.btnSingin.Name = "btnSingin";
            this.btnSingin.Size = new System.Drawing.Size(75, 23);
            this.btnSingin.TabIndex = 2;
            this.btnSingin.Text = "Sign In";
            this.btnSingin.UseVisualStyleBackColor = true;
            this.btnSingin.Click += new System.EventHandler(this.btnSingin_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(73, 12);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 4;
            this.tbxEmail.Text = "asd@a";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(73, 38);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 5;
            this.tbxPassword.Text = "asdfg";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.tbxRPassword);
            this.pnlRegister.Controls.Add(this.tbxRName);
            this.pnlRegister.Controls.Add(this.tbxREmail);
            this.pnlRegister.Controls.Add(this.lblRName);
            this.pnlRegister.Controls.Add(this.tbxRSurname);
            this.pnlRegister.Controls.Add(this.lblRSurname);
            this.pnlRegister.Controls.Add(this.lblREmail);
            this.pnlRegister.Controls.Add(this.btnRRegister);
            this.pnlRegister.Controls.Add(this.lblRPassword);
            this.pnlRegister.Location = new System.Drawing.Point(4, 95);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(173, 139);
            this.pnlRegister.TabIndex = 6;
            this.pnlRegister.Visible = false;
            // 
            // tbxRPassword
            // 
            this.tbxRPassword.Location = new System.Drawing.Point(68, 82);
            this.tbxRPassword.Name = "tbxRPassword";
            this.tbxRPassword.PasswordChar = '*';
            this.tbxRPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxRPassword.TabIndex = 15;
            // 
            // tbxRName
            // 
            this.tbxRName.Location = new System.Drawing.Point(68, 4);
            this.tbxRName.Name = "tbxRName";
            this.tbxRName.Size = new System.Drawing.Size(100, 20);
            this.tbxRName.TabIndex = 12;
            // 
            // tbxREmail
            // 
            this.tbxREmail.Location = new System.Drawing.Point(68, 56);
            this.tbxREmail.Name = "tbxREmail";
            this.tbxREmail.Size = new System.Drawing.Size(100, 20);
            this.tbxREmail.TabIndex = 14;
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Location = new System.Drawing.Point(27, 7);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(35, 13);
            this.lblRName.TabIndex = 10;
            this.lblRName.Text = "Name";
            // 
            // tbxRSurname
            // 
            this.tbxRSurname.Location = new System.Drawing.Point(68, 30);
            this.tbxRSurname.Name = "tbxRSurname";
            this.tbxRSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxRSurname.TabIndex = 13;
            // 
            // lblRSurname
            // 
            this.lblRSurname.AutoSize = true;
            this.lblRSurname.Location = new System.Drawing.Point(13, 33);
            this.lblRSurname.Name = "lblRSurname";
            this.lblRSurname.Size = new System.Drawing.Size(49, 13);
            this.lblRSurname.TabIndex = 9;
            this.lblRSurname.Text = "Surname";
            // 
            // lblREmail
            // 
            this.lblREmail.AutoSize = true;
            this.lblREmail.Location = new System.Drawing.Point(27, 59);
            this.lblREmail.Name = "lblREmail";
            this.lblREmail.Size = new System.Drawing.Size(35, 13);
            this.lblREmail.TabIndex = 8;
            this.lblREmail.Text = "E-mail";
            // 
            // btnRRegister
            // 
            this.btnRRegister.Location = new System.Drawing.Point(12, 108);
            this.btnRRegister.Name = "btnRRegister";
            this.btnRRegister.Size = new System.Drawing.Size(156, 23);
            this.btnRRegister.TabIndex = 16;
            this.btnRRegister.Text = "Register";
            this.btnRRegister.UseVisualStyleBackColor = true;
            this.btnRRegister.Click += new System.EventHandler(this.btnRRegister_Click);
            // 
            // lblRPassword
            // 
            this.lblRPassword.AutoSize = true;
            this.lblRPassword.Location = new System.Drawing.Point(9, 85);
            this.lblRPassword.Name = "lblRPassword";
            this.lblRPassword.Size = new System.Drawing.Size(53, 13);
            this.lblRPassword.TabIndex = 7;
            this.lblRPassword.Text = "Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(184, 101);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnSingin);
            this.Controls.Add(this.btnJoinnow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Do It ";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnJoinnow;
        private System.Windows.Forms.Button btnSingin;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox tbxRPassword;
        private System.Windows.Forms.TextBox tbxRName;
        private System.Windows.Forms.TextBox tbxREmail;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.TextBox tbxRSurname;
        private System.Windows.Forms.Label lblRSurname;
        private System.Windows.Forms.Label lblREmail;
        private System.Windows.Forms.Button btnRRegister;
        private System.Windows.Forms.Label lblRPassword;
    }
}

