namespace Database_Final
{
    partial class Admin_MainMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPublisher = new System.Windows.Forms.TabPage();
            this.groupBoxPublisher = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtPublisherAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletePublisher = new System.Windows.Forms.Button();
            this.btnUpdatePublisher = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.dataPublisher = new System.Windows.Forms.DataGridView();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.boxPosition = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPublisher.SuspendLayout();
            this.groupBoxPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).BeginInit();
            this.tabAccount.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPublisher);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 683);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPublisher
            // 
            this.tabPublisher.Controls.Add(this.groupBoxPublisher);
            this.tabPublisher.Controls.Add(this.btnDeletePublisher);
            this.tabPublisher.Controls.Add(this.btnUpdatePublisher);
            this.tabPublisher.Controls.Add(this.btnAddPublisher);
            this.tabPublisher.Controls.Add(this.dataPublisher);
            this.tabPublisher.Location = new System.Drawing.Point(4, 29);
            this.tabPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPublisher.Name = "tabPublisher";
            this.tabPublisher.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPublisher.Size = new System.Drawing.Size(1034, 650);
            this.tabPublisher.TabIndex = 0;
            this.tabPublisher.Text = "Manage Publisher";
            this.tabPublisher.UseVisualStyleBackColor = true;
            // 
            // groupBoxPublisher
            // 
            this.groupBoxPublisher.Controls.Add(this.btnCancel);
            this.groupBoxPublisher.Controls.Add(this.btnSave);
            this.groupBoxPublisher.Controls.Add(this.txtPublisherName);
            this.groupBoxPublisher.Controls.Add(this.txtPublisherAddress);
            this.groupBoxPublisher.Controls.Add(this.txtPhoneNumber);
            this.groupBoxPublisher.Controls.Add(this.label3);
            this.groupBoxPublisher.Controls.Add(this.label2);
            this.groupBoxPublisher.Controls.Add(this.label1);
            this.groupBoxPublisher.Location = new System.Drawing.Point(650, 257);
            this.groupBoxPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPublisher.Name = "groupBoxPublisher";
            this.groupBoxPublisher.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPublisher.Size = new System.Drawing.Size(364, 377);
            this.groupBoxPublisher.TabIndex = 4;
            this.groupBoxPublisher.TabStop = false;
            this.groupBoxPublisher.Text = "Publisher Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 332);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(136, 43);
            this.txtPublisherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(217, 26);
            this.txtPublisherName.TabIndex = 6;
            // 
            // txtPublisherAddress
            // 
            this.txtPublisherAddress.Location = new System.Drawing.Point(136, 100);
            this.txtPublisherAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublisherAddress.Name = "txtPublisherAddress";
            this.txtPublisherAddress.Size = new System.Drawing.Size(217, 26);
            this.txtPublisherAddress.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(136, 157);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(217, 26);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePublisher.Location = new System.Drawing.Point(650, 174);
            this.btnDeletePublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(364, 72);
            this.btnDeletePublisher.TabIndex = 3;
            this.btnDeletePublisher.Text = "Delete";
            this.btnDeletePublisher.UseVisualStyleBackColor = true;
            this.btnDeletePublisher.Click += new System.EventHandler(this.btnAddDelete_Click);
            // 
            // btnUpdatePublisher
            // 
            this.btnUpdatePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePublisher.Location = new System.Drawing.Point(650, 92);
            this.btnUpdatePublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePublisher.Name = "btnUpdatePublisher";
            this.btnUpdatePublisher.Size = new System.Drawing.Size(364, 72);
            this.btnUpdatePublisher.TabIndex = 2;
            this.btnUpdatePublisher.Text = "Update";
            this.btnUpdatePublisher.UseVisualStyleBackColor = true;
            this.btnUpdatePublisher.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.Location = new System.Drawing.Point(650, 11);
            this.btnAddPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(364, 72);
            this.btnAddPublisher.TabIndex = 1;
            this.btnAddPublisher.Text = "Add";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // dataPublisher
            // 
            this.dataPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPublisher.Location = new System.Drawing.Point(9, 9);
            this.dataPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataPublisher.Name = "dataPublisher";
            this.dataPublisher.Size = new System.Drawing.Size(630, 625);
            this.dataPublisher.TabIndex = 0;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.groupBoxAccount);
            this.tabAccount.Controls.Add(this.btnDeleteAccount);
            this.tabAccount.Controls.Add(this.btnUpdateAccount);
            this.tabAccount.Controls.Add(this.btnAddAccount);
            this.tabAccount.Controls.Add(this.dataAccount);
            this.tabAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAccount.Size = new System.Drawing.Size(1034, 650);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Manage Staff";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.txtAge);
            this.groupBoxAccount.Controls.Add(this.rbFemale);
            this.groupBoxAccount.Controls.Add(this.boxPosition);
            this.groupBoxAccount.Controls.Add(this.txtPassword);
            this.groupBoxAccount.Controls.Add(this.txtUsername);
            this.groupBoxAccount.Controls.Add(this.txtEmail);
            this.groupBoxAccount.Controls.Add(this.label11);
            this.groupBoxAccount.Controls.Add(this.label10);
            this.groupBoxAccount.Controls.Add(this.label9);
            this.groupBoxAccount.Controls.Add(this.label8);
            this.groupBoxAccount.Controls.Add(this.rbMale);
            this.groupBoxAccount.Controls.Add(this.label7);
            this.groupBoxAccount.Controls.Add(this.btnCancelAccount);
            this.groupBoxAccount.Controls.Add(this.btnSaveAccount);
            this.groupBoxAccount.Controls.Add(this.txtAccountName);
            this.groupBoxAccount.Controls.Add(this.txtAccountAddress);
            this.groupBoxAccount.Controls.Add(this.label4);
            this.groupBoxAccount.Controls.Add(this.label5);
            this.groupBoxAccount.Controls.Add(this.label6);
            this.groupBoxAccount.Location = new System.Drawing.Point(650, 257);
            this.groupBoxAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAccount.Size = new System.Drawing.Size(364, 377);
            this.groupBoxAccount.TabIndex = 8;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(215, 157);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 27;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // boxPosition
            // 
            this.boxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxPosition.FormattingEnabled = true;
            this.boxPosition.Items.AddRange(new object[] {
            "Cashier",
            "Stock",
            "Manager"});
            this.boxPosition.Location = new System.Drawing.Point(136, 251);
            this.boxPosition.Name = "boxPosition";
            this.boxPosition.Size = new System.Drawing.Size(217, 28);
            this.boxPosition.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 218);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(217, 26);
            this.txtPassword.TabIndex = 25;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 186);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 26);
            this.txtUsername.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 125);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(141, 157);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 18;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Location = new System.Drawing.Point(14, 332);
            this.btnCancelAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(112, 35);
            this.btnCancelAccount.TabIndex = 16;
            this.btnCancelAccount.Text = "Cancel";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            this.btnCancelAccount.Click += new System.EventHandler(this.btnCancelAccount_Click);
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Location = new System.Drawing.Point(241, 332);
            this.btnSaveAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(112, 35);
            this.btnSaveAccount.TabIndex = 15;
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(136, 34);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(217, 26);
            this.txtAccountName.TabIndex = 14;
            // 
            // txtAccountAddress
            // 
            this.txtAccountAddress.Location = new System.Drawing.Point(136, 64);
            this.txtAccountAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountAddress.Name = "txtAccountAddress";
            this.txtAccountAddress.Size = new System.Drawing.Size(217, 26);
            this.txtAccountAddress.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(650, 174);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(364, 72);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Location = new System.Drawing.Point(650, 92);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(364, 72);
            this.btnUpdateAccount.TabIndex = 6;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(650, 11);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(364, 72);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dataAccount
            // 
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Location = new System.Drawing.Point(9, 9);
            this.dataAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.Size = new System.Drawing.Size(630, 625);
            this.dataAccount.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(136, 95);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(217, 26);
            this.txtAge.TabIndex = 28;
            // 
            // Admin_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 678);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_MainMenu";
            this.Text = "Admin_MainMenu";
            this.Load += new System.EventHandler(this.Admin_MainMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPublisher.ResumeLayout(false);
            this.groupBoxPublisher.ResumeLayout(false);
            this.groupBoxPublisher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).EndInit();
            this.tabAccount.ResumeLayout(false);
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPublisher;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnDeletePublisher;
        private System.Windows.Forms.Button btnUpdatePublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.DataGridView dataPublisher;
        private System.Windows.Forms.GroupBox groupBoxPublisher;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtPublisherAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox boxPosition;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelAccount;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
    }
}