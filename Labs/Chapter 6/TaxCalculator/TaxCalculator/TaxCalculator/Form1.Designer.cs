namespace TaxCalculator
{
    partial class IncomeTaxCalculator
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
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.lblIncomeTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtIncomeTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Location = new System.Drawing.Point(12, 29);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(85, 13);
            this.lblTaxableIncome.TabIndex = 0;
            this.lblTaxableIncome.Text = "Taxable income:";
            // 
            // lblIncomeTaxOwed
            // 
            this.lblIncomeTaxOwed.AutoSize = true;
            this.lblIncomeTaxOwed.Location = new System.Drawing.Point(12, 55);
            this.lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            this.lblIncomeTaxOwed.Size = new System.Drawing.Size(91, 13);
            this.lblIncomeTaxOwed.TabIndex = 1;
            this.lblIncomeTaxOwed.Text = "Income tax owed:";
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Location = new System.Drawing.Point(119, 26);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 20);
            this.txtTaxableIncome.TabIndex = 2;
            // 
            // txtIncomeTaxOwed
            // 
            this.txtIncomeTaxOwed.BackColor = System.Drawing.SystemColors.Control;
            this.txtIncomeTaxOwed.Location = new System.Drawing.Point(119, 52);
            this.txtIncomeTaxOwed.Name = "txtIncomeTaxOwed";
            this.txtIncomeTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeTaxOwed.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 86);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(144, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IncomeTaxCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(264, 129);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIncomeTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblIncomeTaxOwed);
            this.Controls.Add(this.lblTaxableIncome);
            this.Name = "IncomeTaxCalculator";
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.Label lblIncomeTaxOwed;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtIncomeTaxOwed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

