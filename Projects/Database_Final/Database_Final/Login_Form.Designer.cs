﻿namespace Database_Final
{
    partial class Login_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignInUser = new System.Windows.Forms.Button();
            this.btnSignUpUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginAsStaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSignInStaff = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 571);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 623);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(374, 623);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(104, 618);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(460, 618);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(283, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // btnSignInUser
            // 
            this.btnSignInUser.Location = new System.Drawing.Point(147, 5);
            this.btnSignInUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignInUser.Name = "btnSignInUser";
            this.btnSignInUser.Size = new System.Drawing.Size(112, 35);
            this.btnSignInUser.TabIndex = 5;
            this.btnSignInUser.Text = "Sign In";
            this.btnSignInUser.UseVisualStyleBackColor = true;
            this.btnSignInUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSignUpUser
            // 
            this.btnSignUpUser.Location = new System.Drawing.Point(26, 5);
            this.btnSignUpUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignUpUser.Name = "btnSignUpUser";
            this.btnSignUpUser.Size = new System.Drawing.Size(112, 35);
            this.btnSignUpUser.TabIndex = 6;
            this.btnSignUpUser.Text = "Sign Up";
            this.btnSignUpUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSignUpUser);
            this.panel1.Controls.Add(this.btnSignInUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 45);
            this.panel1.TabIndex = 7;
            // 
            // btnLoginAsStaff
            // 
            this.btnLoginAsStaff.Location = new System.Drawing.Point(780, 585);
            this.btnLoginAsStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoginAsStaff.Name = "btnLoginAsStaff";
            this.btnLoginAsStaff.Size = new System.Drawing.Size(234, 35);
            this.btnLoginAsStaff.TabIndex = 8;
            this.btnLoginAsStaff.Text = "Login As Staff";
            this.btnLoginAsStaff.UseVisualStyleBackColor = true;
            this.btnLoginAsStaff.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnSignInStaff);
            this.panel2.Location = new System.Drawing.Point(754, 625);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 45);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSignInStaff
            // 
            this.btnSignInStaff.Location = new System.Drawing.Point(147, 5);
            this.btnSignInStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignInStaff.Name = "btnSignInStaff";
            this.btnSignInStaff.Size = new System.Drawing.Size(112, 35);
            this.btnSignInStaff.TabIndex = 5;
            this.btnSignInStaff.Text = "Sign In";
            this.btnSignInStaff.UseVisualStyleBackColor = true;
            this.btnSignInStaff.Click += new System.EventHandler(this.btnSignInStaff_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 578);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Customer Login";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Verify Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 652);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLoginAsStaff);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1051, 708);
            this.MinimumSize = new System.Drawing.Size(1051, 708);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignInUser;
        private System.Windows.Forms.Button btnSignUpUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoginAsStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSignInStaff;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button2;
    }
}

