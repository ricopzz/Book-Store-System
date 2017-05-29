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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataPublisher = new System.Windows.Forms.DataGridView();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).BeginInit();
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
            this.tabPublisher.Controls.Add(this.button3);
            this.tabPublisher.Controls.Add(this.button2);
            this.tabPublisher.Controls.Add(this.button1);
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(650, 174);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(364, 72);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(650, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(650, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAccount.Size = new System.Drawing.Size(1034, 650);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Manage Account";
            this.tabAccount.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPublisher;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataPublisher;
    }
}