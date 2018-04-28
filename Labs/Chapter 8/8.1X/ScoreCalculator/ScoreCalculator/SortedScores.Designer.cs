namespace ScoreCalculator
{
    partial class SortedScores
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
            this.listSortedScores = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listSortedScores
            // 
            this.listSortedScores.FormattingEnabled = true;
            this.listSortedScores.Location = new System.Drawing.Point(0, 0);
            this.listSortedScores.Name = "listSortedScores";
            this.listSortedScores.Size = new System.Drawing.Size(284, 225);
            this.listSortedScores.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 228);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 13);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Count:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(56, 231);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(43, 20);
            this.txtCount.TabIndex = 2;
            // 
            // SortedScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.listSortedScores);
            this.Name = "SortedScores";
            this.Text = "SortedScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSortedScores;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
    }
}