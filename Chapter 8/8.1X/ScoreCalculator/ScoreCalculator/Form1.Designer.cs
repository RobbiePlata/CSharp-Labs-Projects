namespace ScoreCalculator
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(81, 25);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(32, 20);
            this.txtScore.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(37, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(14, 62);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(61, 13);
            this.lblScoreTotal.TabIndex = 2;
            this.lblScoreTotal.Text = "Score total:";
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtScoreTotal.Location = new System.Drawing.Point(81, 59);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.Size = new System.Drawing.Size(32, 20);
            this.txtScoreTotal.TabIndex = 3;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(7, 96);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(68, 13);
            this.lblScoreCount.TabIndex = 4;
            this.lblScoreCount.Text = "Score count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(25, 127);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average:";
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtScoreCount.Location = new System.Drawing.Point(81, 93);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.Size = new System.Drawing.Size(32, 20);
            this.txtScoreCount.TabIndex = 6;
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.SystemColors.Control;
            this.txtAverage.Location = new System.Drawing.Point(81, 127);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(32, 20);
            this.txtAverage.TabIndex = 7;
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(119, 161);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(75, 23);
            this.btnClearScores.TabIndex = 8;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(119, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Location = new System.Drawing.Point(27, 161);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(86, 23);
            this.btnDisplayScores.TabIndex = 11;
            this.btnDisplayScores.Text = "Display Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = true;
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(214, 226);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplayScores;
    }
}

