namespace InvoiceTotal
{
    partial class InvoiceTotalForm
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.lblInvoiceAverage = new System.Windows.Forms.Label();
            this.lblTotalOfInvoices = new System.Windows.Forms.Label();
            this.lblNumberOfInvoices = new System.Windows.Forms.Label();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.lblLargestInvoice = new System.Windows.Forms.Label();
            this.lblSmallestInvoice = new System.Windows.Forms.Label();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(23, 81);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "&Subtotal";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(23, 106);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPercent.TabIndex = 1;
            this.lblDiscountPercent.Text = "Discount Percent:";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountPercent.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(23, 131);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(90, 13);
            this.lblDiscountAmount.TabIndex = 2;
            this.lblDiscountAmount.Text = "Discount amount:";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountAmount.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(23, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubtotal.Location = new System.Drawing.Point(123, 78);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(123, 103);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercent.TabIndex = 2;
            this.txtDiscountPercent.TabStop = false;
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.txtDiscountPercent_TextChanged);
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(123, 128);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmount.TabIndex = 3;
            this.txtDiscountAmount.TabStop = false;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.txtDiscountAmount_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(123, 153);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(259, 193);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(421, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(363, 52);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfInvoices.TabIndex = 5;
            this.txtNumberOfInvoices.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnterSubtotal.Enabled = false;
            this.txtEnterSubtotal.Location = new System.Drawing.Point(123, 53);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSubtotal.TabIndex = 1;
            this.txtEnterSubtotal.TextChanged += new System.EventHandler(this.txtEnterSubtotal_TextChanged);
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(363, 78);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtTotalOfInvoices.TabIndex = 6;
            this.txtTotalOfInvoices.TextChanged += new System.EventHandler(this.txtTotalOfInvoices_TextChanged);
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Enabled = false;
            this.lblEnterSubtotal.Location = new System.Drawing.Point(23, 55);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(77, 13);
            this.lblEnterSubtotal.TabIndex = 11;
            this.lblEnterSubtotal.Text = "Enter Subtotal:";
            this.lblEnterSubtotal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.BackColor = System.Drawing.SystemColors.Control;
            this.txtInvoiceAverage.Location = new System.Drawing.Point(363, 104);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceAverage.TabIndex = 7;
            this.txtInvoiceAverage.TextChanged += new System.EventHandler(this.txtInvoiceAverage_TextChanged);
            // 
            // lblInvoiceAverage
            // 
            this.lblInvoiceAverage.AutoSize = true;
            this.lblInvoiceAverage.Location = new System.Drawing.Point(257, 107);
            this.lblInvoiceAverage.Name = "lblInvoiceAverage";
            this.lblInvoiceAverage.Size = new System.Drawing.Size(87, 13);
            this.lblInvoiceAverage.TabIndex = 13;
            this.lblInvoiceAverage.Text = "Invoice average:";
            this.lblInvoiceAverage.Click += new System.EventHandler(this.lblInvoiceAverage_Click);
            // 
            // lblTotalOfInvoices
            // 
            this.lblTotalOfInvoices.AutoSize = true;
            this.lblTotalOfInvoices.Location = new System.Drawing.Point(256, 81);
            this.lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            this.lblTotalOfInvoices.Size = new System.Drawing.Size(88, 13);
            this.lblTotalOfInvoices.TabIndex = 14;
            this.lblTotalOfInvoices.Text = "Total of invoices:";
            this.lblTotalOfInvoices.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblNumberOfInvoices
            // 
            this.lblNumberOfInvoices.AutoSize = true;
            this.lblNumberOfInvoices.Location = new System.Drawing.Point(256, 55);
            this.lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            this.lblNumberOfInvoices.Size = new System.Drawing.Size(101, 13);
            this.lblNumberOfInvoices.TabIndex = 15;
            this.lblNumberOfInvoices.Text = "Number of invoices:";
            this.lblNumberOfInvoices.Click += new System.EventHandler(this.lblNumberOfInvoices_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(340, 193);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotals.TabIndex = 16;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // lblLargestInvoice
            // 
            this.lblLargestInvoice.AutoSize = true;
            this.lblLargestInvoice.Location = new System.Drawing.Point(256, 133);
            this.lblLargestInvoice.Name = "lblLargestInvoice";
            this.lblLargestInvoice.Size = new System.Drawing.Size(82, 13);
            this.lblLargestInvoice.TabIndex = 17;
            this.lblLargestInvoice.Text = "Largest invoice:";
            this.lblLargestInvoice.Click += new System.EventHandler(this.lblLargestInvoice_Click);
            // 
            // lblSmallestInvoice
            // 
            this.lblSmallestInvoice.AutoSize = true;
            this.lblSmallestInvoice.Location = new System.Drawing.Point(256, 159);
            this.lblSmallestInvoice.Name = "lblSmallestInvoice";
            this.lblSmallestInvoice.Size = new System.Drawing.Size(86, 13);
            this.lblSmallestInvoice.TabIndex = 18;
            this.lblSmallestInvoice.Text = "Smallest invoice:";
            this.lblSmallestInvoice.Click += new System.EventHandler(this.lblSmallestInvoice_Click);
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.txtSmallestInvoice.Location = new System.Drawing.Point(363, 156);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtSmallestInvoice.TabIndex = 19;
            this.txtSmallestInvoice.TextChanged += new System.EventHandler(this.txtSmallestInvoice_TextChanged);
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.txtLargestInvoice.Location = new System.Drawing.Point(363, 130);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtLargestInvoice.TabIndex = 8;
            this.txtLargestInvoice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(24, 17);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(66, 13);
            this.lblEnterName.TabIndex = 20;
            this.lblEnterName.Text = "Enter Name:";
            this.lblEnterName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(96, 14);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 21;
            this.txtEnterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(202, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceTotalForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(539, 253);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.lblSmallestInvoice);
            this.Controls.Add(this.lblLargestInvoice);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.lblNumberOfInvoices);
            this.Controls.Add(this.lblTotalOfInvoices);
            this.Controls.Add(this.lblInvoiceAverage);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "InvoiceTotalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.Label lblTotalOfInvoices;
        private System.Windows.Forms.Label lblNumberOfInvoices;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Label lblLargestInvoice;
        private System.Windows.Forms.Label lblSmallestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Button btnOK;
    }
}

