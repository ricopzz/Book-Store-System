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
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.boxCategory = new System.Windows.Forms.ComboBox();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.qtyNum = new System.Windows.Forms.NumericUpDown();
            this.boxPublisher = new System.Windows.Forms.ComboBox();
            this.publishDatepicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dataBook = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPublisher.SuspendLayout();
            this.groupBoxPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).BeginInit();
            this.tabAccount.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.tabBooks.SuspendLayout();
            this.groupBoxBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPublisher);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPublisher
            // 
            this.tabPublisher.Controls.Add(this.groupBoxPublisher);
            this.tabPublisher.Controls.Add(this.btnDeletePublisher);
            this.tabPublisher.Controls.Add(this.btnUpdatePublisher);
            this.tabPublisher.Controls.Add(this.btnAddPublisher);
            this.tabPublisher.Controls.Add(this.dataPublisher);
            this.tabPublisher.Location = new System.Drawing.Point(4, 22);
            this.tabPublisher.Name = "tabPublisher";
            this.tabPublisher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublisher.Size = new System.Drawing.Size(732, 418);
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
            this.groupBoxPublisher.Location = new System.Drawing.Point(433, 167);
            this.groupBoxPublisher.Name = "groupBoxPublisher";
            this.groupBoxPublisher.Size = new System.Drawing.Size(290, 245);
            this.groupBoxPublisher.TabIndex = 4;
            this.groupBoxPublisher.TabStop = false;
            this.groupBoxPublisher.Text = "Publisher Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(9, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(91, 28);
            this.txtPublisherName.MaxLength = 50;
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(193, 20);
            this.txtPublisherName.TabIndex = 4;
            // 
            // txtPublisherAddress
            // 
            this.txtPublisherAddress.Location = new System.Drawing.Point(91, 65);
            this.txtPublisherAddress.MaxLength = 100;
            this.txtPublisherAddress.Name = "txtPublisherAddress";
            this.txtPublisherAddress.Size = new System.Drawing.Size(193, 20);
            this.txtPublisherAddress.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(91, 102);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(193, 20);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePublisher.Location = new System.Drawing.Point(433, 113);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(290, 47);
            this.btnDeletePublisher.TabIndex = 3;
            this.btnDeletePublisher.Text = "Delete";
            this.btnDeletePublisher.UseVisualStyleBackColor = true;
            this.btnDeletePublisher.Click += new System.EventHandler(this.btnDeletePublisher_Click);
            // 
            // btnUpdatePublisher
            // 
            this.btnUpdatePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePublisher.Location = new System.Drawing.Point(433, 60);
            this.btnUpdatePublisher.Name = "btnUpdatePublisher";
            this.btnUpdatePublisher.Size = new System.Drawing.Size(290, 47);
            this.btnUpdatePublisher.TabIndex = 2;
            this.btnUpdatePublisher.Text = "Update";
            this.btnUpdatePublisher.UseVisualStyleBackColor = true;
            this.btnUpdatePublisher.Click += new System.EventHandler(this.btnUpdatePublisher_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.Location = new System.Drawing.Point(433, 7);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(290, 47);
            this.btnAddPublisher.TabIndex = 1;
            this.btnAddPublisher.Text = "Add";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // dataPublisher
            // 
            this.dataPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPublisher.Location = new System.Drawing.Point(6, 6);
            this.dataPublisher.Name = "dataPublisher";
            this.dataPublisher.Size = new System.Drawing.Size(420, 406);
            this.dataPublisher.TabIndex = 0;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.groupBoxAccount);
            this.tabAccount.Controls.Add(this.btnDeleteAccount);
            this.tabAccount.Controls.Add(this.btnUpdateAccount);
            this.tabAccount.Controls.Add(this.btnAddAccount);
            this.tabAccount.Controls.Add(this.dataAccount);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(732, 418);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Manage Staff";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.birthDatePicker);
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
            this.groupBoxAccount.Location = new System.Drawing.Point(433, 167);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(290, 245);
            this.groupBoxAccount.TabIndex = 8;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account Details";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(91, 62);
            this.birthDatePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(193, 20);
            this.birthDatePicker.TabIndex = 6;
            this.birthDatePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(143, 103);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 9;
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
            this.boxPosition.Location = new System.Drawing.Point(91, 161);
            this.boxPosition.Margin = new System.Windows.Forms.Padding(2);
            this.boxPosition.Name = "boxPosition";
            this.boxPosition.Size = new System.Drawing.Size(193, 21);
            this.boxPosition.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 141);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(91, 121);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(193, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 82);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(94, 103);
            this.rbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Location = new System.Drawing.Point(9, 216);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAccount.TabIndex = 13;
            this.btnCancelAccount.Text = "Cancel";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            this.btnCancelAccount.Click += new System.EventHandler(this.btnCancelAccount_Click);
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Location = new System.Drawing.Point(209, 216);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAccount.TabIndex = 14;
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(91, 22);
            this.txtAccountName.MaxLength = 50;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(193, 20);
            this.txtAccountName.TabIndex = 4;
            // 
            // txtAccountAddress
            // 
            this.txtAccountAddress.Location = new System.Drawing.Point(91, 42);
            this.txtAccountAddress.MaxLength = 100;
            this.txtAccountAddress.Name = "txtAccountAddress";
            this.txtAccountAddress.Size = new System.Drawing.Size(193, 20);
            this.txtAccountAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(433, 113);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(290, 47);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Location = new System.Drawing.Point(433, 60);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(290, 47);
            this.btnUpdateAccount.TabIndex = 2;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(433, 7);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(290, 47);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dataAccount
            // 
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Location = new System.Drawing.Point(6, 6);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.Size = new System.Drawing.Size(420, 406);
            this.dataAccount.TabIndex = 15;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.groupBoxBooks);
            this.tabBooks.Controls.Add(this.btnDeleteBook);
            this.tabBooks.Controls.Add(this.btnUpdateBook);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.dataBook);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(732, 418);
            this.tabBooks.TabIndex = 2;
            this.tabBooks.Text = "Manage Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.txtURL);
            this.groupBoxBooks.Controls.Add(this.label18);
            this.groupBoxBooks.Controls.Add(this.boxCategory);
            this.groupBoxBooks.Controls.Add(this.priceNum);
            this.groupBoxBooks.Controls.Add(this.qtyNum);
            this.groupBoxBooks.Controls.Add(this.boxPublisher);
            this.groupBoxBooks.Controls.Add(this.publishDatepicker);
            this.groupBoxBooks.Controls.Add(this.label17);
            this.groupBoxBooks.Controls.Add(this.label16);
            this.groupBoxBooks.Controls.Add(this.label15);
            this.groupBoxBooks.Controls.Add(this.btnCancelBook);
            this.groupBoxBooks.Controls.Add(this.btnSaveBook);
            this.groupBoxBooks.Controls.Add(this.txtTitle);
            this.groupBoxBooks.Controls.Add(this.label12);
            this.groupBoxBooks.Controls.Add(this.label13);
            this.groupBoxBooks.Controls.Add(this.label14);
            this.groupBoxBooks.Location = new System.Drawing.Point(433, 167);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Size = new System.Drawing.Size(290, 245);
            this.groupBoxBooks.TabIndex = 9;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Books Details";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(91, 176);
            this.txtURL.MaxLength = 750;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(190, 20);
            this.txtURL.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Image URL";
            // 
            // boxCategory
            // 
            this.boxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCategory.FormattingEnabled = true;
            this.boxCategory.Items.AddRange(new object[] {
            "Comic",
            "Novel",
            "Drama",
            "Horror",
            "Biography",
            "Labolatory Report",
            "Textbook",
            "Fiction Book"});
            this.boxCategory.Location = new System.Drawing.Point(91, 127);
            this.boxCategory.Name = "boxCategory";
            this.boxCategory.Size = new System.Drawing.Size(190, 21);
            this.boxCategory.TabIndex = 8;
            // 
            // priceNum
            // 
            this.priceNum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceNum.Location = new System.Drawing.Point(91, 102);
            this.priceNum.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.priceNum.Minimum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(190, 20);
            this.priceNum.TabIndex = 7;
            this.priceNum.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // qtyNum
            // 
            this.qtyNum.Location = new System.Drawing.Point(91, 78);
            this.qtyNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtyNum.Name = "qtyNum";
            this.qtyNum.Size = new System.Drawing.Size(190, 20);
            this.qtyNum.TabIndex = 6;
            this.qtyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // boxPublisher
            // 
            this.boxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxPublisher.FormattingEnabled = true;
            this.boxPublisher.Location = new System.Drawing.Point(91, 53);
            this.boxPublisher.Name = "boxPublisher";
            this.boxPublisher.Size = new System.Drawing.Size(190, 21);
            this.boxPublisher.TabIndex = 5;
            // 
            // publishDatepicker
            // 
            this.publishDatepicker.Location = new System.Drawing.Point(91, 152);
            this.publishDatepicker.Name = "publishDatepicker";
            this.publishDatepicker.Size = new System.Drawing.Size(190, 20);
            this.publishDatepicker.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Date Publish";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Category";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Price";
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.Location = new System.Drawing.Point(9, 216);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBook.TabIndex = 10;
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = true;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Location = new System.Drawing.Point(209, 216);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBook.TabIndex = 11;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(91, 28);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(190, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Publisher";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Title";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(433, 113);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(290, 47);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(433, 60);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(290, 47);
            this.btnUpdateBook.TabIndex = 2;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(433, 7);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(290, 47);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dataBook
            // 
            this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBook.Location = new System.Drawing.Point(6, 6);
            this.dataBook.Name = "dataBook";
            this.dataBook.Size = new System.Drawing.Size(420, 406);
            this.dataBook.TabIndex = 12;
            // 
            // Admin_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 441);
            this.Controls.Add(this.tabControl1);
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
            this.tabBooks.ResumeLayout(false);
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
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
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dataBook;
        private System.Windows.Forms.NumericUpDown qtyNum;
        private System.Windows.Forms.ComboBox boxPublisher;
        private System.Windows.Forms.DateTimePicker publishDatepicker;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.ComboBox boxCategory;
        private System.Windows.Forms.NumericUpDown priceNum;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label18;
    }
}