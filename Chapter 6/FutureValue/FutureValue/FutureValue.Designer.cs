namespace FutureValue
{
    partial class frmFutureValue
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
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.lblYearlyInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.AutoSize = true;
            this.lblMonthlyInvestment.Enabled = false;
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(12, 52);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(102, 13);
            this.lblMonthlyInvestment.TabIndex = 0;
            this.lblMonthlyInvestment.Text = "Monthly Investment:";
            // 
            // lblYearlyInterestRate
            // 
            this.lblYearlyInterestRate.AutoSize = true;
            this.lblYearlyInterestRate.Enabled = false;
            this.lblYearlyInterestRate.Location = new System.Drawing.Point(12, 79);
            this.lblYearlyInterestRate.Name = "lblYearlyInterestRate";
            this.lblYearlyInterestRate.Size = new System.Drawing.Size(103, 13);
            this.lblYearlyInterestRate.TabIndex = 1;
            this.lblYearlyInterestRate.Text = "Yearly Interest Rate:";
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Enabled = false;
            this.lblNumberOfYears.Location = new System.Drawing.Point(12, 106);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(89, 13);
            this.lblNumberOfYears.TabIndex = 2;
            this.lblNumberOfYears.Text = "Number of Years:";
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.AutoSize = true;
            this.lblFutureValue.Enabled = false;
            this.lblFutureValue.Location = new System.Drawing.Point(12, 161);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(70, 13);
            this.lblFutureValue.TabIndex = 3;
            this.lblFutureValue.Text = "Future Value:";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Enabled = false;
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(137, 49);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyInvestment.TabIndex = 4;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Enabled = false;
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(137, 76);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtYearlyInterestRate.TabIndex = 5;
            this.txtYearlyInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtYears
            // 
            this.txtYears.Enabled = false;
            this.txtYears.Location = new System.Drawing.Point(137, 103);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 20);
            this.txtYears.TabIndex = 6;
            this.txtYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Enabled = false;
            this.txtFutureValue.Location = new System.Drawing.Point(137, 158);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 20);
            this.txtFutureValue.TabIndex = 7;
            this.txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(162, 129);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(162, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(12, 12);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(75, 23);
            this.btnEnterData.TabIndex = 10;
            this.btnEnterData.Text = "Enter Data";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // frmFutureValue
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(255, 214);
            this.Controls.Add(this.btnEnterData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.lblYearlyInterestRate);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.Name = "frmFutureValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlyInvestment;
        private System.Windows.Forms.Label lblYearlyInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnterData;
    }
}

