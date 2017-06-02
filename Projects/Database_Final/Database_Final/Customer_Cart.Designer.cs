namespace Database_Final
{
    partial class Customer_Cart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupInvoice = new System.Windows.Forms.GroupBox();
            this.txtRequestDate = new System.Windows.Forms.TextBox();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbStoreCredit = new System.Windows.Forms.RadioButton();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.qtyNum = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupInvoice.SuspendLayout();
            this.groupPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(996, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupInvoice
            // 
            this.groupInvoice.Controls.Add(this.txtRequestDate);
            this.groupInvoice.Controls.Add(this.lblRequestDate);
            this.groupInvoice.Controls.Add(this.txtRequestID);
            this.groupInvoice.Controls.Add(this.lblRequestID);
            this.groupInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInvoice.Location = new System.Drawing.Point(12, 425);
            this.groupInvoice.Name = "groupInvoice";
            this.groupInvoice.Size = new System.Drawing.Size(448, 161);
            this.groupInvoice.TabIndex = 1;
            this.groupInvoice.TabStop = false;
            this.groupInvoice.Text = "Invoice Details";
            // 
            // txtRequestDate
            // 
            this.txtRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestDate.Location = new System.Drawing.Point(181, 93);
            this.txtRequestDate.Name = "txtRequestDate";
            this.txtRequestDate.Size = new System.Drawing.Size(227, 26);
            this.txtRequestDate.TabIndex = 6;
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDate.Location = new System.Drawing.Point(34, 96);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(109, 20);
            this.lblRequestDate.TabIndex = 7;
            this.lblRequestDate.Text = "Request Date";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestID.Location = new System.Drawing.Point(181, 47);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(227, 26);
            this.txtRequestID.TabIndex = 5;
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(34, 50);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(91, 20);
            this.lblRequestID.TabIndex = 5;
            this.lblRequestID.Text = "Request ID";
            // 
            // groupPayment
            // 
            this.groupPayment.Controls.Add(this.txtCardNumber);
            this.groupPayment.Controls.Add(this.rbCreditCard);
            this.groupPayment.Controls.Add(this.rbStoreCredit);
            this.groupPayment.Controls.Add(this.lblCardNumber);
            this.groupPayment.Controls.Add(this.lblPaymentType);
            this.groupPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPayment.Location = new System.Drawing.Point(466, 425);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(439, 257);
            this.groupPayment.TabIndex = 2;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "Payment Information";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(183, 135);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(228, 26);
            this.txtCardNumber.TabIndex = 4;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreditCard.Location = new System.Drawing.Point(183, 78);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(114, 24);
            this.rbCreditCard.TabIndex = 3;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // rbStoreCredit
            // 
            this.rbStoreCredit.AutoSize = true;
            this.rbStoreCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStoreCredit.Location = new System.Drawing.Point(183, 48);
            this.rbStoreCredit.Name = "rbStoreCredit";
            this.rbStoreCredit.Size = new System.Drawing.Size(119, 24);
            this.rbStoreCredit.TabIndex = 2;
            this.rbStoreCredit.TabStop = true;
            this.rbStoreCredit.Text = "Store Credit";
            this.rbStoreCredit.UseVisualStyleBackColor = true;
            this.rbStoreCredit.CheckedChanged += new System.EventHandler(this.rbStoreCredit_CheckedChanged);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(33, 138);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(103, 20);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(33, 50);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(109, 20);
            this.lblPaymentType.TabIndex = 0;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(438, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Shopping Cart";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(936, 12);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(172, 26);
            this.txtBalance.TabIndex = 4;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(862, 15);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(911, 475);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(196, 73);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Confirm Order";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(912, 554);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(196, 76);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Continue Shopping";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // qtyNum
            // 
            this.qtyNum.Location = new System.Drawing.Point(1014, 90);
            this.qtyNum.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.qtyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyNum.Name = "qtyNum";
            this.qtyNum.Size = new System.Drawing.Size(93, 26);
            this.qtyNum.TabIndex = 8;
            this.qtyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(1020, 67);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(68, 20);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Quantity";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1014, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 84);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Remove Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1014, 122);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 38);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Customer_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 694);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.qtyNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupPayment);
            this.Controls.Add(this.groupInvoice);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Cart";
            this.Text = "Customer_Cart";
            this.Load += new System.EventHandler(this.Customer_Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupInvoice.ResumeLayout(false);
            this.groupInvoice.PerformLayout();
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupInvoice;
        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbStoreCredit;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TextBox txtRequestDate;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown qtyNum;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
    }
}