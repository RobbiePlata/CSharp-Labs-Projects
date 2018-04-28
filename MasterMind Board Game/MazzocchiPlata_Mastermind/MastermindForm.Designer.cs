namespace MazzocchiPlata_Mastermind
{
    partial class frm_Mastermind
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
            this.components = new System.ComponentModel.Container();
            this.tlp_Guesses = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ColorRed = new System.Windows.Forms.Button();
            this.btn_ColorOrange = new System.Windows.Forms.Button();
            this.btn_ColorYellow = new System.Windows.Forms.Button();
            this.btn_ColorGreen = new System.Windows.Forms.Button();
            this.btn_ColorBlue = new System.Windows.Forms.Button();
            this.btn_ColorPurple = new System.Windows.Forms.Button();
            this.pnl_Board = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.tlp_Solution = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Pins = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Hard = new System.Windows.Forms.Button();
            this.btn_Medium = new System.Windows.Forms.Button();
            this.btn_Easy = new System.Windows.Forms.Button();
            this.btn_Instructions = new System.Windows.Forms.Button();
            this.btn_Leaderboard = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tmr_GameTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Theme = new System.Windows.Forms.Button();
            this.pnl_Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Guesses
            // 
            this.tlp_Guesses.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Guesses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tlp_Guesses.ColumnCount = 11;
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Guesses.Location = new System.Drawing.Point(18, 111);
            this.tlp_Guesses.Name = "tlp_Guesses";
            this.tlp_Guesses.RowCount = 4;
            this.tlp_Guesses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Guesses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Guesses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Guesses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Guesses.Size = new System.Drawing.Size(678, 300);
            this.tlp_Guesses.TabIndex = 0;
            // 
            // btn_ColorRed
            // 
            this.btn_ColorRed.BackColor = System.Drawing.Color.Red;
            this.btn_ColorRed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColorRed.ForeColor = System.Drawing.Color.Black;
            this.btn_ColorRed.Location = new System.Drawing.Point(23, 420);
            this.btn_ColorRed.Name = "btn_ColorRed";
            this.btn_ColorRed.Size = new System.Drawing.Size(45, 45);
            this.btn_ColorRed.TabIndex = 1;
            this.btn_ColorRed.UseVisualStyleBackColor = false;
            this.btn_ColorRed.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_ColorOrange
            // 
            this.btn_ColorOrange.BackColor = System.Drawing.Color.Orange;
            this.btn_ColorOrange.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColorOrange.ForeColor = System.Drawing.Color.Black;
            this.btn_ColorOrange.Location = new System.Drawing.Point(74, 420);
            this.btn_ColorOrange.Name = "btn_ColorOrange";
            this.btn_ColorOrange.Size = new System.Drawing.Size(45, 45);
            this.btn_ColorOrange.TabIndex = 2;
            this.btn_ColorOrange.UseVisualStyleBackColor = false;
            this.btn_ColorOrange.Click += new System.EventHandler(this.btn_Orange_Click);
            // 
            // btn_ColorYellow
            // 
            this.btn_ColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_ColorYellow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColorYellow.ForeColor = System.Drawing.Color.Black;
            this.btn_ColorYellow.Location = new System.Drawing.Point(125, 420);
            this.btn_ColorYellow.Name = "btn_ColorYellow";
            this.btn_ColorYellow.Size = new System.Drawing.Size(45, 45);
            this.btn_ColorYellow.TabIndex = 3;
            this.btn_ColorYellow.UseVisualStyleBackColor = false;
            this.btn_ColorYellow.Click += new System.EventHandler(this.btn_Yellow_Click);
            // 
            // btn_ColorGreen
            // 
            this.btn_ColorGreen.BackColor = System.Drawing.Color.Lime;
            this.btn_ColorGreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColorGreen.ForeColor = System.Drawing.Color.Black;
            this.btn_ColorGreen.Location = new System.Drawing.Point(176, 420);
            this.btn_ColorGreen.Name = "btn_ColorGreen";
            this.btn_ColorGreen.Size = new System.Drawing.Size(45, 45);
            this.btn_ColorGreen.TabIndex = 4;
            this.btn_ColorGreen.UseVisualStyleBackColor = false;
            this.btn_ColorGreen.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_ColorBlue
            // 
            this.btn_ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.btn_ColorBlue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColorBlue.ForeColor = System.Drawing.Color.Black;
            this.btn_ColorBlue.Location = new System.Drawing.Point(227, 420);
            this.btn_ColorBlue.Name = "btn_ColorBlue";
            this.btn_ColorBlue.Size = new System.Drawing.Size(45, 45);
            this.btn_ColorBlue.TabIndex = 6;
            this.btn_ColorBlue.UseVisualStyleBackColor = false;
            this.btn_ColorBlue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_ColorPurple
            // 
            this.btn_ColorPurple.BackColor = System.Drawing.Color.Purple;
            this.btn_ColorPurple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColorPurple.ForeColor = System.Drawing.Color.Black;
            this.btn_ColorPurple.Location = new System.Drawing.Point(278, 420);
            this.btn_ColorPurple.Name = "btn_ColorPurple";
            this.btn_ColorPurple.Size = new System.Drawing.Size(45, 45);
            this.btn_ColorPurple.TabIndex = 7;
            this.btn_ColorPurple.UseVisualStyleBackColor = false;
            this.btn_ColorPurple.Click += new System.EventHandler(this.btn_Purple_Click);
            // 
            // pnl_Board
            // 
            this.pnl_Board.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Board.Controls.Add(this.btn_Check);
            this.pnl_Board.Controls.Add(this.tlp_Solution);
            this.pnl_Board.Controls.Add(this.tlp_Pins);
            this.pnl_Board.Controls.Add(this.tlp_Guesses);
            this.pnl_Board.Controls.Add(this.btn_ColorPurple);
            this.pnl_Board.Controls.Add(this.btn_ColorRed);
            this.pnl_Board.Controls.Add(this.btn_ColorBlue);
            this.pnl_Board.Controls.Add(this.btn_ColorOrange);
            this.pnl_Board.Controls.Add(this.btn_ColorYellow);
            this.pnl_Board.Controls.Add(this.btn_ColorGreen);
            this.pnl_Board.ForeColor = System.Drawing.Color.White;
            this.pnl_Board.Location = new System.Drawing.Point(43, 153);
            this.pnl_Board.Name = "pnl_Board";
            this.pnl_Board.Size = new System.Drawing.Size(784, 483);
            this.pnl_Board.TabIndex = 9;
            this.pnl_Board.Visible = false;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(122)))), ((int)(((byte)(101)))));
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.Color.Black;
            this.btn_Check.Location = new System.Drawing.Point(336, 425);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(108, 40);
            this.btn_Check.TabIndex = 17;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // tlp_Solution
            // 
            this.tlp_Solution.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Solution.ColumnCount = 1;
            this.tlp_Solution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Solution.Location = new System.Drawing.Point(695, 111);
            this.tlp_Solution.Name = "tlp_Solution";
            this.tlp_Solution.RowCount = 4;
            this.tlp_Solution.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Solution.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Solution.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Solution.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Solution.Size = new System.Drawing.Size(61, 300);
            this.tlp_Solution.TabIndex = 0;
            this.tlp_Solution.Visible = false;
            // 
            // tlp_Pins
            // 
            this.tlp_Pins.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Pins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tlp_Pins.ColumnCount = 20;
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Pins.Enabled = false;
            this.tlp_Pins.Location = new System.Drawing.Point(18, 43);
            this.tlp_Pins.Name = "tlp_Pins";
            this.tlp_Pins.RowCount = 2;
            this.tlp_Pins.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Pins.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Pins.Size = new System.Drawing.Size(678, 62);
            this.tlp_Pins.TabIndex = 14;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(218, 14);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(584, 33);
            this.lbl_Welcome.TabIndex = 10;
            this.lbl_Welcome.Text = "Welcome To The Game Of Mastermind";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(218, 60);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(281, 32);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Please Enter Name: ";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(490, 60);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(250, 33);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(119)))));
            this.btn_OK.Enabled = false;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Location = new System.Drawing.Point(746, 60);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(57, 33);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Hard
            // 
            this.btn_Hard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.btn_Hard.FlatAppearance.BorderSize = 0;
            this.btn_Hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hard.ForeColor = System.Drawing.Color.Black;
            this.btn_Hard.Location = new System.Drawing.Point(595, 114);
            this.btn_Hard.Name = "btn_Hard";
            this.btn_Hard.Size = new System.Drawing.Size(99, 33);
            this.btn_Hard.TabIndex = 14;
            this.btn_Hard.Text = "Hard";
            this.btn_Hard.UseVisualStyleBackColor = false;
            this.btn_Hard.Visible = false;
            this.btn_Hard.Click += new System.EventHandler(this.btn_Hard_Click);
            // 
            // btn_Medium
            // 
            this.btn_Medium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(199)))), ((int)(((byte)(16)))));
            this.btn_Medium.FlatAppearance.BorderSize = 0;
            this.btn_Medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medium.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medium.ForeColor = System.Drawing.Color.Black;
            this.btn_Medium.Location = new System.Drawing.Point(371, 114);
            this.btn_Medium.Name = "btn_Medium";
            this.btn_Medium.Size = new System.Drawing.Size(99, 33);
            this.btn_Medium.TabIndex = 15;
            this.btn_Medium.Text = "Medium";
            this.btn_Medium.UseVisualStyleBackColor = false;
            this.btn_Medium.Visible = false;
            this.btn_Medium.Click += new System.EventHandler(this.btn_Intermediate_Click);
            // 
            // btn_Easy
            // 
            this.btn_Easy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(119)))));
            this.btn_Easy.FlatAppearance.BorderSize = 0;
            this.btn_Easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Easy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Easy.ForeColor = System.Drawing.Color.Black;
            this.btn_Easy.Location = new System.Drawing.Point(153, 114);
            this.btn_Easy.Name = "btn_Easy";
            this.btn_Easy.Size = new System.Drawing.Size(99, 33);
            this.btn_Easy.TabIndex = 16;
            this.btn_Easy.Text = "Easy";
            this.btn_Easy.UseVisualStyleBackColor = false;
            this.btn_Easy.Visible = false;
            this.btn_Easy.Click += new System.EventHandler(this.btn_Easy_Click);
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.btn_Instructions.FlatAppearance.BorderSize = 0;
            this.btn_Instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instructions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instructions.ForeColor = System.Drawing.Color.Black;
            this.btn_Instructions.Location = new System.Drawing.Point(26, 12);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.Size = new System.Drawing.Size(154, 40);
            this.btn_Instructions.TabIndex = 18;
            this.btn_Instructions.Text = "Instructions";
            this.btn_Instructions.UseVisualStyleBackColor = false;
            this.btn_Instructions.Click += new System.EventHandler(this.btn_Rules_Click);
            // 
            // btn_Leaderboard
            // 
            this.btn_Leaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.btn_Leaderboard.FlatAppearance.BorderSize = 0;
            this.btn_Leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Leaderboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Leaderboard.ForeColor = System.Drawing.Color.Black;
            this.btn_Leaderboard.Location = new System.Drawing.Point(26, 58);
            this.btn_Leaderboard.Name = "btn_Leaderboard";
            this.btn_Leaderboard.Size = new System.Drawing.Size(154, 40);
            this.btn_Leaderboard.TabIndex = 18;
            this.btn_Leaderboard.Text = "Leaderboard";
            this.btn_Leaderboard.UseVisualStyleBackColor = false;
            this.btn_Leaderboard.Click += new System.EventHandler(this.btn_Leaderboard_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(719, 629);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(108, 40);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tmr_GameTimer
            // 
            this.tmr_GameTimer.Interval = 1000;
            this.tmr_GameTimer.Tick += new System.EventHandler(this.tmr_GameTimer_Tick);
            // 
            // btn_Theme
            // 
            this.btn_Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btn_Theme.FlatAppearance.BorderSize = 0;
            this.btn_Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Theme.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Theme.ForeColor = System.Drawing.Color.Black;
            this.btn_Theme.Location = new System.Drawing.Point(595, 629);
            this.btn_Theme.Name = "btn_Theme";
            this.btn_Theme.Size = new System.Drawing.Size(108, 40);
            this.btn_Theme.TabIndex = 20;
            this.btn_Theme.Text = "Dark";
            this.btn_Theme.UseVisualStyleBackColor = false;
            this.btn_Theme.Click += new System.EventHandler(this.btn_Theme_Click);
            // 
            // frm_Mastermind
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(839, 675);
            this.Controls.Add(this.btn_Theme);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Instructions);
            this.Controls.Add(this.btn_Leaderboard);
            this.Controls.Add(this.btn_Easy);
            this.Controls.Add(this.btn_Medium);
            this.Controls.Add(this.btn_Hard);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pnl_Board);
            this.Name = "frm_Mastermind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mastermind";
            this.pnl_Board.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Guesses;
        private System.Windows.Forms.Button btn_ColorRed;
        private System.Windows.Forms.Button btn_ColorOrange;
        private System.Windows.Forms.Button btn_ColorYellow;
        private System.Windows.Forms.Button btn_ColorGreen;
        private System.Windows.Forms.Button btn_ColorBlue;
        private System.Windows.Forms.Button btn_ColorPurple;
        private System.Windows.Forms.Panel pnl_Board;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TableLayoutPanel tlp_Pins;
        private System.Windows.Forms.Button btn_Hard;
        private System.Windows.Forms.Button btn_Medium;
        private System.Windows.Forms.Button btn_Easy;
        private System.Windows.Forms.TableLayoutPanel tlp_Solution;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Instructions;
        private System.Windows.Forms.Button btn_Leaderboard;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Timer tmr_GameTimer;
        private System.Windows.Forms.Button btn_Theme;
    }
}

