namespace StringHandling
{
    partial class ParsePhone
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStandardFormatNumber = new System.Windows.Forms.Label();
            this.lblDigitsOnlyNumber = new System.Windows.Forms.Label();
            this.lblEnteredNumber = new System.Windows.Forms.Label();
            this.lblStandardFormat = new System.Windows.Forms.Label();
            this.lblDigitsOnly = new System.Windows.Forms.Label();
            this.lblEntered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(98, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStandardFormatNumber
            // 
            this.lblStandardFormatNumber.AutoSize = true;
            this.lblStandardFormatNumber.Location = new System.Drawing.Point(122, 81);
            this.lblStandardFormatNumber.Name = "lblStandardFormatNumber";
            this.lblStandardFormatNumber.Size = new System.Drawing.Size(0, 13);
            this.lblStandardFormatNumber.TabIndex = 15;
            // 
            // lblDigitsOnlyNumber
            // 
            this.lblDigitsOnlyNumber.AutoSize = true;
            this.lblDigitsOnlyNumber.Location = new System.Drawing.Point(122, 45);
            this.lblDigitsOnlyNumber.Name = "lblDigitsOnlyNumber";
            this.lblDigitsOnlyNumber.Size = new System.Drawing.Size(0, 13);
            this.lblDigitsOnlyNumber.TabIndex = 14;
            // 
            // lblEnteredNumber
            // 
            this.lblEnteredNumber.AutoSize = true;
            this.lblEnteredNumber.Location = new System.Drawing.Point(122, 9);
            this.lblEnteredNumber.Name = "lblEnteredNumber";
            this.lblEnteredNumber.Size = new System.Drawing.Size(0, 13);
            this.lblEnteredNumber.TabIndex = 13;
            // 
            // lblStandardFormat
            // 
            this.lblStandardFormat.AutoSize = true;
            this.lblStandardFormat.Location = new System.Drawing.Point(12, 81);
            this.lblStandardFormat.Name = "lblStandardFormat";
            this.lblStandardFormat.Size = new System.Drawing.Size(85, 13);
            this.lblStandardFormat.TabIndex = 12;
            this.lblStandardFormat.Text = "Standard format:";
            // 
            // lblDigitsOnly
            // 
            this.lblDigitsOnly.AutoSize = true;
            this.lblDigitsOnly.Location = new System.Drawing.Point(12, 45);
            this.lblDigitsOnly.Name = "lblDigitsOnly";
            this.lblDigitsOnly.Size = new System.Drawing.Size(58, 13);
            this.lblDigitsOnly.TabIndex = 11;
            this.lblDigitsOnly.Text = "Digits only:";
            // 
            // lblEntered
            // 
            this.lblEntered.AutoSize = true;
            this.lblEntered.Location = new System.Drawing.Point(12, 9);
            this.lblEntered.Name = "lblEntered";
            this.lblEntered.Size = new System.Drawing.Size(47, 13);
            this.lblEntered.TabIndex = 10;
            this.lblEntered.Text = "Entered:";
            // 
            // ParsePhone
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 146);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStandardFormatNumber);
            this.Controls.Add(this.lblDigitsOnlyNumber);
            this.Controls.Add(this.lblEnteredNumber);
            this.Controls.Add(this.lblStandardFormat);
            this.Controls.Add(this.lblDigitsOnly);
            this.Controls.Add(this.lblEntered);
            this.Name = "ParsePhone";
            this.Text = "Parse Phone";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStandardFormatNumber;
        private System.Windows.Forms.Label lblDigitsOnlyNumber;
        private System.Windows.Forms.Label lblEnteredNumber;
        private System.Windows.Forms.Label lblStandardFormat;
        private System.Windows.Forms.Label lblDigitsOnly;
        private System.Windows.Forms.Label lblEntered;
    }
}