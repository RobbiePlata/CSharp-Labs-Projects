namespace Bingo
{
    partial class frmBingo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBingo));
            this.lblWelcomeToBingo = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblAreYouReadyToPlay = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.txtNumberCalled = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcomeToBingo
            // 
            this.lblWelcomeToBingo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcomeToBingo.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToBingo.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeToBingo.Name = "lblWelcomeToBingo";
            this.lblWelcomeToBingo.Size = new System.Drawing.Size(692, 861);
            this.lblWelcomeToBingo.TabIndex = 0;
            this.lblWelcomeToBingo.Text = "Welcome To Bingo";
            this.lblWelcomeToBingo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(159, 78);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 1;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(41, 81);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(66, 13);
            this.lblEnterName.TabIndex = 2;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // lblAreYouReadyToPlay
            // 
            this.lblAreYouReadyToPlay.AutoSize = true;
            this.lblAreYouReadyToPlay.Location = new System.Drawing.Point(41, 118);
            this.lblAreYouReadyToPlay.Name = "lblAreYouReadyToPlay";
            this.lblAreYouReadyToPlay.Size = new System.Drawing.Size(112, 13);
            this.lblAreYouReadyToPlay.TabIndex = 3;
            this.lblAreYouReadyToPlay.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.Enabled = false;
            this.btnYes.ForeColor = System.Drawing.Color.Green;
            this.btnYes.Location = new System.Drawing.Point(159, 113);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(240, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No (Exit)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Enabled = false;
            this.lblDirections.Location = new System.Drawing.Point(41, 155);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(342, 39);
            this.lblDirections.TabIndex = 6;
            this.lblDirections.Text = resources.GetString("lblDirections.Text");
            this.lblDirections.Visible = false; 
            // 
            // txtNumberCalled
            // 
            this.txtNumberCalled.Enabled = false;
            this.txtNumberCalled.Location = new System.Drawing.Point(562, 127);
            this.txtNumberCalled.Multiline = true;
            this.txtNumberCalled.Name = "txtNumberCalled";
            this.txtNumberCalled.Size = new System.Drawing.Size(82, 38);
            this.txtNumberCalled.TabIndex = 7;
            this.txtNumberCalled.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Enabled = false;
            this.btnDontHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDontHave.Location = new System.Drawing.Point(562, 171);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(82, 23);
            this.btnDontHave.TabIndex = 8;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Enabled = false;
            this.pnlCard.Location = new System.Drawing.Point(44, 227);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 600);
            this.pnlCard.TabIndex = 10;
            this.pnlCard.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(692, 861);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtNumberCalled);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblAreYouReadyToPlay);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblWelcomeToBingo);
            this.Name = "Form1";
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeToBingo;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblAreYouReadyToPlay;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.TextBox txtNumberCalled;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Panel pnlCard;
    }
}

