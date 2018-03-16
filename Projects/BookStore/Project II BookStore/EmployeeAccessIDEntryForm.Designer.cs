namespace Project_II_BookStore
{
    partial class EmployeeAccessIDEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAccessIDEntryForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnterAccessID = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnFindMe = new System.Windows.Forms.Button();
            this.picLibrary = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(284, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Plata Book Store";
            // 
            // lblEnterAccessID
            // 
            this.lblEnterAccessID.AutoSize = true;
            this.lblEnterAccessID.Location = new System.Drawing.Point(12, 225);
            this.lblEnterAccessID.Name = "lblEnterAccessID";
            this.lblEnterAccessID.Size = new System.Drawing.Size(359, 13);
            this.lblEnterAccessID.TabIndex = 1;
            this.lblEnterAccessID.Text = "Enter your FIVE DIGIT Access ID in the Box Below. Then click on Find Me";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(54, 254);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(100, 20);
            this.txtEntry.TabIndex = 2;
            // 
            // btnFindMe
            // 
            this.btnFindMe.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFindMe.Location = new System.Drawing.Point(240, 252);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(75, 23);
            this.btnFindMe.TabIndex = 3;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = false;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // picLibrary
            // 
            this.picLibrary.Image = ((System.Drawing.Image)(resources.GetObject("picLibrary.Image")));
            this.picLibrary.Location = new System.Drawing.Point(44, 43);
            this.picLibrary.Name = "picLibrary";
            this.picLibrary.Size = new System.Drawing.Size(296, 166);
            this.picLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLibrary.TabIndex = 4;
            this.picLibrary.TabStop = false;
            // 
            // EmployeeAccessIDEntryForm
            // 
            this.AcceptButton = this.btnFindMe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.picLibrary);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblEnterAccessID);
            this.Controls.Add(this.lblWelcome);
            this.Name = "EmployeeAccessIDEntryForm";
            this.Text = "EmployeeAccessIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.picLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnterAccessID;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnFindMe;
        private System.Windows.Forms.PictureBox picLibrary;
    }
}

