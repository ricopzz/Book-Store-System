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
            this.btnDeletePublisher = new System.Windows.Forms.Button();
            this.btnUpdatePublisher = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.dataPublisher = new System.Windows.Forms.DataGridView();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.groupBoxPublisher = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPublisherAddress = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).BeginInit();
            this.tabAccount.SuspendLayout();
            this.groupBoxPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPublisher);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 444);
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
            this.tabPublisher.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPublisher.Size = new System.Drawing.Size(687, 418);
            this.tabPublisher.TabIndex = 0;
            this.tabPublisher.Text = "Manage Publisher";
            this.tabPublisher.UseVisualStyleBackColor = true;
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePublisher.Location = new System.Drawing.Point(433, 113);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(243, 47);
            this.btnDeletePublisher.TabIndex = 3;
            this.btnDeletePublisher.Text = "Delete";
            this.btnDeletePublisher.UseVisualStyleBackColor = true;
            this.btnDeletePublisher.Click += new System.EventHandler(this.btnAddDelete_Click);
            // 
            // btnUpdatePublisher
            // 
            this.btnUpdatePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePublisher.Location = new System.Drawing.Point(433, 60);
            this.btnUpdatePublisher.Name = "btnUpdatePublisher";
            this.btnUpdatePublisher.Size = new System.Drawing.Size(243, 47);
            this.btnUpdatePublisher.TabIndex = 2;
            this.btnUpdatePublisher.Text = "Update";
            this.btnUpdatePublisher.UseVisualStyleBackColor = true;
            this.btnUpdatePublisher.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.Location = new System.Drawing.Point(433, 7);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(243, 47);
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
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAccount.Size = new System.Drawing.Size(687, 418);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Manage Account";
            this.tabAccount.UseVisualStyleBackColor = true;
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
            this.groupBoxPublisher.Size = new System.Drawing.Size(243, 245);
            this.groupBoxPublisher.TabIndex = 4;
            this.groupBoxPublisher.TabStop = false;
            this.groupBoxPublisher.Text = "Publisher Details";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(433, 113);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(243, 47);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Location = new System.Drawing.Point(433, 60);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(243, 47);
            this.btnUpdateAccount.TabIndex = 6;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(433, 7);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(243, 47);
            this.btnAddAccount.TabIndex = 5;
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
            this.dataAccount.TabIndex = 4;
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Location = new System.Drawing.Point(433, 167);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(243, 245);
            this.groupBoxAccount.TabIndex = 8;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account Details";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(91, 102);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtPublisherAddress
            // 
            this.txtPublisherAddress.Location = new System.Drawing.Point(91, 65);
            this.txtPublisherAddress.Name = "txtPublisherAddress";
            this.txtPublisherAddress.Size = new System.Drawing.Size(146, 20);
            this.txtPublisherAddress.TabIndex = 5;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(91, 28);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(146, 20);
            this.txtPublisherName.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Admin_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_MainMenu";
            this.Text = "Admin_MainMenu";
            this.Load += new System.EventHandler(this.Admin_MainMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPublisher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).EndInit();
            this.tabAccount.ResumeLayout(false);
            this.groupBoxPublisher.ResumeLayout(false);
            this.groupBoxPublisher.PerformLayout();
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
    }
}