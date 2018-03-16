namespace StringHandling
{
    partial class ParseName
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDisplayedFirstName = new System.Windows.Forms.Label();
            this.lblDisplayedMiddleName = new System.Windows.Forms.Label();
            this.lblDisplayedLastName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 54);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(70, 13);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 18);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First name:";
            // 
            // lblDisplayedFirstName
            // 
            this.lblDisplayedFirstName.AutoSize = true;
            this.lblDisplayedFirstName.Location = new System.Drawing.Point(122, 18);
            this.lblDisplayedFirstName.Name = "lblDisplayedFirstName";
            this.lblDisplayedFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayedFirstName.TabIndex = 6;
            // 
            // lblDisplayedMiddleName
            // 
            this.lblDisplayedMiddleName.AutoSize = true;
            this.lblDisplayedMiddleName.Location = new System.Drawing.Point(122, 54);
            this.lblDisplayedMiddleName.Name = "lblDisplayedMiddleName";
            this.lblDisplayedMiddleName.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayedMiddleName.TabIndex = 7;
            // 
            // lblDisplayedLastName
            // 
            this.lblDisplayedLastName.AutoSize = true;
            this.lblDisplayedLastName.Location = new System.Drawing.Point(122, 90);
            this.lblDisplayedLastName.Name = "lblDisplayedLastName";
            this.lblDisplayedLastName.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayedLastName.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(98, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ParseName
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 156);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDisplayedLastName);
            this.Controls.Add(this.lblDisplayedMiddleName);
            this.Controls.Add(this.lblDisplayedFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "ParseName";
            this.Text = "ParseName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDisplayedFirstName;
        private System.Windows.Forms.Label lblDisplayedMiddleName;
        private System.Windows.Forms.Label lblDisplayedLastName;
        private System.Windows.Forms.Button btnExit;
    }
}