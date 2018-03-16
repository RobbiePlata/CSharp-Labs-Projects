namespace Project_II_BookStore
{
    partial class EmployeePinEntryForm
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
            this.lblBookStore = new System.Windows.Forms.Label();
            this.lblPinEntry = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookStore
            // 
            this.lblBookStore.AutoSize = true;
            this.lblBookStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStore.Location = new System.Drawing.Point(117, 9);
            this.lblBookStore.Name = "lblBookStore";
            this.lblBookStore.Size = new System.Drawing.Size(145, 20);
            this.lblBookStore.TabIndex = 0;
            this.lblBookStore.Text = "Plata Book Store";
            // 
            // lblPinEntry
            // 
            this.lblPinEntry.AutoSize = true;
            this.lblPinEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinEntry.Location = new System.Drawing.Point(135, 29);
            this.lblPinEntry.Name = "lblPinEntry";
            this.lblPinEntry.Size = new System.Drawing.Size(113, 20);
            this.lblPinEntry.TabIndex = 1;
            this.lblPinEntry.Text = "Pin Entry Form";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(60, 69);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(152, 13);
            this.lblDirections.TabIndex = 2;
            this.lblDirections.Text = "Enter Pin and Press OK...";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(77, 93);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(110, 13);
            this.lblPin.TabIndex = 3;
            this.lblPin.Text = "Pin (a 4 Digit Number)";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(193, 90);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOK.Location = new System.Drawing.Point(218, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EmployeePinEntryForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblPinEntry);
            this.Controls.Add(this.lblBookStore);
            this.Name = "EmployeePinEntryForm";
            this.Text = "EmployeePinEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookStore;
        private System.Windows.Forms.Label lblPinEntry;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnOK;
    }
}