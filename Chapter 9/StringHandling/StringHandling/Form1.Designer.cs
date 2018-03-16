namespace StringHandling
{
    partial class Form1
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditPhoneNumber = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEnterPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(12, 15);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(64, 13);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter name:";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(81, 12);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(187, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(187, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditPhoneNumber
            // 
            this.btnEditPhoneNumber.Location = new System.Drawing.Point(154, 39);
            this.btnEditPhoneNumber.Name = "btnEditPhoneNumber";
            this.btnEditPhoneNumber.Size = new System.Drawing.Size(108, 23);
            this.btnEditPhoneNumber.TabIndex = 8;
            this.btnEditPhoneNumber.Text = "Edit Phone Number";
            this.btnEditPhoneNumber.UseVisualStyleBackColor = true;
            this.btnEditPhoneNumber.Click += new System.EventHandler(this.btnEditPhoneNumber_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(81, 41);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(67, 20);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // lblEnterPhone
            // 
            this.lblEnterPhone.AutoSize = true;
            this.lblEnterPhone.Location = new System.Drawing.Point(12, 44);
            this.lblEnterPhone.Name = "lblEnterPhone";
            this.lblEnterPhone.Size = new System.Drawing.Size(68, 13);
            this.lblEnterPhone.TabIndex = 10;
            this.lblEnterPhone.Text = "Enter phone:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(278, 102);
            this.Controls.Add(this.lblEnterPhone);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnEditPhoneNumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterName);
            this.Name = "Form1";
            this.Text = "Parse Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEnterPhone;
    }
}

