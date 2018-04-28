using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace MazzocchiPlata_Mastermind
{
    /// Robert Plata & Brett Mazzocchi
    /// Date Created: 04/11/2018
    /// <summary>
    ///  This is the main form for our game this is where the game is played by and interacts with the user
    /// </summary>
    public partial class frm_Mastermind : Form
    {
        private Button selectedButton; // a button is used to change properties of colored button thats is selected and pates them to guess when button is clicked
        private int difficulty; //int representation of max difficulty changed by difficulty
        private SolutionClass solution;
        private int guessCount = 0; // keeps count of guesses for telling program when to end 
        private int index = 0; // this is used to find the current index of the pins in the current scope
        private string[] colors = {"Red", "Orange", "Yellow", "Green", "Blue", "Purple"}; // list of colors for selected color button marking
        private LeaderboardClass leaderboard = new LeaderboardClass(); 
        private int secondsPlayed = 0; // count of seconds played that is incremented by timer
        private Color defaultColor = System.Drawing.Color.Silver; // shortcut for defualt board ball colors
        private Color darkTheme = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));// Shortcut for dark theme color 
        private Color lightTheme = System.Drawing.Color.Gainsboro; // Shortcut for light theme color 


        /// <summary>
        /// This event handler initializes the components, creates the default properties of the "selectButton" and creates a new instance of a solution that is used throughout game 
        /// </summary>
        public frm_Mastermind()
        {
            InitializeComponent();
            selectedButton = new Button();
            selectedButton.BackColor = defaultColor;
            solution = new SolutionClass();
        }

        /// <summary>
        /// This is the click event handler for all the Guess buttons and when clicked it sets the guess button clicked back color
        /// to the selected buttons back color
        /// </summary>
        void guess_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.BackColor = selectedButton.BackColor;
        }

        /// <summary>
        /// THis method dynamically creates the playable board the user will interact with please look inside for breakdown 
        /// description comments
        /// </summary>
        private void createBoard()
        {
            // This is the code to give the color choices their circular shape
            GraphicsPath circle1 = new GraphicsPath();
            circle1.AddEllipse(4, 4, btn_ColorRed.Width - 8, btn_ColorRed.Height - 8);//creates shape
            btn_ColorRed.Region = new Region(circle1);// creates clickable region

            GraphicsPath circle2 = new GraphicsPath();
            circle2.AddEllipse(4, 4, btn_ColorOrange.Width - 8, btn_ColorOrange.Height - 8);
            btn_ColorOrange.Region = new Region(circle2);

            GraphicsPath circle3 = new GraphicsPath();
            circle3.AddEllipse(4, 4, btn_ColorYellow.Width - 8, btn_ColorYellow.Height - 8);
            btn_ColorYellow.Region = new Region(circle3);

            GraphicsPath circle4 = new GraphicsPath();
            circle4.AddEllipse(4, 4, btn_ColorGreen.Width - 8, btn_ColorGreen.Height - 8);
            btn_ColorGreen.Region = new Region(circle4);

            GraphicsPath circle5 = new GraphicsPath();
            circle5.AddEllipse(4, 4, btn_ColorBlue.Width - 8, btn_ColorBlue.Height - 8);
            btn_ColorBlue.Region = new Region(circle5);

            GraphicsPath circle6 = new GraphicsPath();
            circle6.AddEllipse(4, 4, btn_ColorPurple.Width - 8, btn_ColorPurple.Height - 8);
            btn_ColorPurple.Region = new Region(circle6);

            // This is to set the row and column size variable for the guesses, solution and pins
            // board and pins are set dynamically so they change when the difficulty is changed
            var guessRowCount = 4;
            var guessColumnCount = difficulty;
            var pinRowCount = 2;
            var pinColumnCount = difficulty * 2;
            var solutionRowCount = 4;
            var solutionColumnCount = 1;

            // This sets the row and column in the guesses, solution and pins table layout panel
            this.tlp_Guesses.ColumnCount = guessColumnCount;
            this.tlp_Guesses.RowCount = guessRowCount;
            this.tlp_Pins.ColumnCount = pinColumnCount;
            this.tlp_Pins.RowCount = pinRowCount;
            this.tlp_Solution.ColumnCount = solutionColumnCount;
            this.tlp_Solution.RowCount = solutionRowCount;

            //THis clears the style and prepares it for the next block of code to style
            this.tlp_Guesses.ColumnStyles.Clear();
            this.tlp_Guesses.RowStyles.Clear();
            this.tlp_Pins.ColumnStyles.Clear();
            this.tlp_Pins.RowStyles.Clear();
            this.tlp_Solution.ColumnStyles.Clear();
            this.tlp_Solution.RowStyles.Clear();
             
            // Dynamically styles the size of each block in the table layout panels so they are evenly sized
            for (int i = 0; i < guessColumnCount; i++)
            {
                this.tlp_Guesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / guessColumnCount));
            }
            for (int i = 0; i < guessRowCount; i++)
            {
                this.tlp_Guesses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / guessRowCount));
            }
            for (int i = 0; i < pinColumnCount; i++)
            {
                this.tlp_Pins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / pinColumnCount));
            }
            for (int i = 0; i < pinRowCount; i++)
            {
                this.tlp_Pins.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / pinRowCount));
            }
            for (int i = 0; i < solutionColumnCount; i++)
            {
                this.tlp_Solution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / solutionColumnCount));
            }
            for (int i = 0; i < solutionRowCount; i++)
            {
                this.tlp_Solution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / solutionRowCount));
            }

            // This dynamically creates the button that is put inside each table layout panel block for the guesses
            for (int i = 0; i < guessRowCount * guessColumnCount; i++)
            {
                var guess = new Button();
                guess.Enabled = false;
                guess.Name = string.Format("btn_Guess" + i);
                guess.Click += guess_Click;
                guess.Dock = DockStyle.Fill;
                guess.BackColor = defaultColor;
                GraphicsPath circle = new GraphicsPath();
                guess.Width = 45;
                guess.Height = 45;
                circle.AddEllipse(4, 4, guess.Width - 8, guess.Height - 8);
                guess.Region = new Region(circle);
                if (i % difficulty == 0)// ALgorithm so the first row is only enabled
                {
                    guess.Enabled = true;
                }
                this.tlp_Guesses.Controls.Add(guess);
            }

            // This dynamically creates the button that is put inside each table layout panel block for the pins
            for (int i = 0; i < pinRowCount * pinColumnCount; i++)
            {
                var pin = new Button();
                pin.Enabled = false;
                pin.Name = string.Format("btn_Pin" + i);
                pin.Dock = DockStyle.Fill;
                pin.BackColor = defaultColor;
                GraphicsPath circle = new GraphicsPath();
                pin.Width = 18;
                pin.Height = 18;
                circle.AddEllipse(4, 4, pin.Width - 8, pin.Height - 8);
                pin.Region = new Region(circle);
                this.tlp_Pins.Controls.Add(pin);
            }

            // This dynamically creates the button that is put inside each table layout panel block for the solution
            for (int i = 0; i < solutionRowCount; i++)
            {
                var solutionBall = new Button();
                solutionBall.Enabled = false;
                solutionBall.Name = string.Format("btn_Solution" + i);
                solutionBall.Dock = DockStyle.Fill;
                setColor(solution.solutionArray[i], solutionBall);
                GraphicsPath circle = new GraphicsPath();
                solutionBall.Width = 45;
                solutionBall.Height = 45;
                circle.AddEllipse(4, 4, solutionBall.Width - 8, solutionBall.Height - 8);
                solutionBall.Region = new Region(circle);
                this.tlp_Solution.Controls.Add(solutionBall);
            }
        }

        /// <summary>
        /// This is text change event handler for the txt_name that disables and enables the "OK" button depending on if the 
        /// textbox is empty or not
        /// </summary>
        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                btn_OK.Enabled = false;
            }
            else
            {
                btn_OK.Enabled = true;
            }
        }

        /// <summary>
        /// This is the click event handler for the "OK" button and when clicked it makes all the difficulty select buttons visible and disables the name textbox and
        /// "OK" button so they can not be changed
        /// </summary>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_Hard.Visible = true;
            btn_Medium.Visible = true;
            btn_Easy.Visible = true;
            txt_Name.Enabled = false;
            btn_OK.Enabled = false;
        }

        /// <summary>
        /// This is the click event handler for the "Hard" button this sets the the board guesses to 8 disables the "Easy",
        /// "Medium" and "Hard" buttons. Also creates the board by calling the createBoard Method and making it visible
        /// </summary>
        private void btn_Hard_Click(object sender, EventArgs e)
        {
            difficulty = 8;
            btn_Hard.Enabled = false;
            btn_Medium.Enabled = false;
            btn_Easy.Enabled = false;
            createBoard();
            pnl_Board.Visible = true;
            tmr_GameTimer.Start();
            btn_Hard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /// <summary>
        /// This is the click event handler for the "Medium" button this sets the the board guesses to 10 disables the "Easy",
        /// "Medium" and "Hard" buttons. Also creates the board by calling the createBoard Method and making it visible
        /// </summary>
        private void btn_Intermediate_Click(object sender, EventArgs e)
        {
            difficulty = 10;
            btn_Hard.Enabled = false;
            btn_Medium.Enabled = false;
            btn_Easy.Enabled = false;
            createBoard();
            pnl_Board.Visible = true;
            tmr_GameTimer.Start();
            btn_Medium.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /// <summary>
        /// This is the click event handler for the "Easy" button this sets the the board guesses to 12 disables the "Easy",
        /// "Medium" and "Hard" buttons. Also creates the board by calling the createBoard Method and making it visible
        /// </summary>
        private void btn_Easy_Click(object sender, EventArgs e)
        {
            difficulty = 12;
            btn_Hard.Enabled = false;
            btn_Medium.Enabled = false;
            btn_Easy.Enabled = false;
            createBoard();
            pnl_Board.Visible = true;
            tmr_GameTimer.Start();
            btn_Easy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /// <summary>
        /// This is the click event handler for the "purple" button and when it is clicked it sets the selected button equal to the "purple" button and marks the 
        /// purple button by calling markSelectedButton with the arguement being a string of the color selected
        /// </summary>
        private void btn_Purple_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = btn_ColorPurple.BackColor;
            markSelectedButton("Purple");
        }

        /// <summary>
        /// This is the click event handler for the "red" button and when it is clicked it sets the selected button equal to the "red" button and marks the 
        /// red button by calling markSelectedButton with the arguement being a string of the color selected
        /// </summary>
        private void btn_Red_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = btn_ColorRed.BackColor;
            markSelectedButton("Red");
        }

        /// <summary>
        /// This is the click event handler for the "blue" button and when it is clicked it sets the selected button equal to the "blue" button and marks the 
        /// blue button by calling markSelectedButton with the arguement being a string of the color selected
        /// </summary>
        private void btn_Blue_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = btn_ColorBlue.BackColor;
            markSelectedButton("Blue");
        }

        /// <summary>
        /// This is the click event handler for the "orange" button and when it is clicked it sets the selected button equal to the "orange" button and marks the 
        /// orange button by calling markSelectedButton with the arguement being a string of the color selected
        /// </summary>
        private void btn_Orange_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = btn_ColorOrange.BackColor;
            markSelectedButton("Orange");
        }

        /// <summary>
        /// This is the click event handler for the "yellow" button and when it is clicked it sets the selected button equal to the "yellow" button and marks the 
        /// yellow button by calling markSelectedButton with the arguement being a string of the color selected
        /// </summary>
        private void btn_Yellow_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = btn_ColorYellow.BackColor;
            markSelectedButton("Yellow");
        }

        /// <summary>
        /// This is the click event handler for the "green" button and when it is clicked it sets the selected button equal to the "green" button and marks the 
        /// green button by calling markSelectedButton with the arguement being a string of the color selected
        /// </summary>
        private void btn_Green_Click(object sender, EventArgs e)
        {
            selectedButton.BackColor = btn_ColorGreen.BackColor;
            markSelectedButton("Green");
        }

        /// <summary>
        /// This is the ckick event handler for the "Check" button when clicked it checks if there are any empty guesses. If guesses are filled it creates a 
        /// new guess list full of strings equal to guess buttons back color. then passes the "guesses" list to guess class. It then calls the draw pins class
        /// which works out the physical reprsentation of the pins and finally enables the next row of guess buttons
        /// </summary>
        private void btn_Check_Click(object sender, EventArgs e)
        {
            List<string> guesses = new List<string>();
            for (int i = guessCount; i < 4 * difficulty; i += difficulty)//checks for empty guesses
            {
                string buttonName = "btn_Guess" + i;
                if(tlp_Guesses.Controls[buttonName].BackColor == defaultColor)
                {
                    MessageBox.Show("Please make sure that every guess has been used.");
                    return;
                }
            }

            for (int i = guessCount; i < 4 * difficulty; i += difficulty) //add each guess ball into the "guesses" List
            {
                string buttonName = "btn_Guess" + i;
                guesses.Add(tlp_Guesses.Controls[buttonName].BackColor.ToString());
                tlp_Guesses.Controls[buttonName].Enabled = false;
            }

            GuessClass guess = new GuessClass(guesses);
            drawPins(guess);            

            guessCount++;

            for (int i = guessCount; i < 4 * difficulty; i += difficulty)
            {
                string buttonName = "btn_Guess" + i;
                tlp_Guesses.Controls[buttonName].Enabled = true;
            }
        }

        /// <summary>
        /// This event handlers creates a message box with the rules of the game of mastermind when "Rules" button is clicked
        /// </summary>
        private void btn_Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The goal of the user is to guess the solution set of four colored balls in the proper order." +
                " Depending on the difficulty the user gets 8, 10 or 12 changes to guess the matching combination to a hidden set." +
                " Hints are displayed above the user’s previous selection to indicate how close they are to solving the hidden set." +
                " If the user has a correct color in the wrong position, it will be indicated with a white pin. If the user has" +
                " no correct colors, no pins will be displayed, but if the user guesses the right color and position, that will be" +
                " indicated with a black pin. The locations of the white and black pins have no relation to the balls." +
                " If the user guesses the combination within the guess limit, the user wins. If the user cannot guess the combination with " +
                "the guesses they were given, the user has lost the game. " +
                "\n\nIMPORTANT! " +
                "\nUser must select a color then pick the loaction they want that color, a color cannot be changed until you have selected a " +
                "new color from one of the six color balls underneath the board. Finally, the game starts with the left most column and you " +
                "play to the right and to make your guess final you must click the 'Check' button to submit.");
        }

        /// <summary>
        /// This method is called to change every color button's text to blank, except for the button being selected that button gets its text set 
        /// to capital O. This is done by passin in the color being selected and comparing it to a array of all color if the color matches the passed color 
        /// it makes that matching color button the marked one and the others blank
        /// </summary>
        /// <param name="color"> color is used as arguement for if stament to determine action</param>
        private void markSelectedButton(string color)
                {
                    int selectedColor = Array.IndexOf(colors, color);
                    for(int i = 0; i < 6; i++)
                    {
                        if(i == selectedColor)
                        {
                            string buttonName = "btn_Color" + colors[i];
                            pnl_Board.Controls[buttonName].Text = "O";
                        }
                        else
                        {
                            string buttonName = "btn_Color" + colors[i];
                            pnl_Board.Controls[buttonName].Text = "";
                        }
                    }
                }

        /// <summary>
        /// This method is used to change the color of the buttons in the solution to the proper color by taking a list of ints 
        /// and changing that int to the color it represents
        /// </summary>
        /// <param name="colorCode"> this is the number that is going to be changed to color</param>
        /// <param name="button"> this is the button that is going to have its color changed</param>
        private void setColor(int colorCode, Button button)
        {
            switch (colorCode)
            {
                case 0:
                    button.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    button.BackColor = System.Drawing.Color.Orange;
                    break;
                case 2:
                    button.BackColor = System.Drawing.Color.Yellow;
                    break;
                case 3:
                    button.BackColor = System.Drawing.Color.Lime;
                    break;
                case 4:
                    button.BackColor = System.Drawing.Color.Blue;
                    break;
                case 5:
                    button.BackColor = System.Drawing.Color.Purple;
                    break;
            }
        }

        /// <summary>
        /// This is the click event for the leaderboard button that brings up the current leader board
        /// </summary>
        private void btn_Leaderboard_Click(object sender, EventArgs e)
        {
            leaderboard.displayLeaderboard();
        }

        /// <summary>
        /// This event handler writes the updated leadboard to the new leaderboard file so at start of next run leaderboard file is update 
        /// also exits the application
        /// </summary>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            leaderboard.writeLeaderboard();
            Application.Exit();
        }                   

        /// <summary>
        /// This method takes the int version of diffulty and returns the string version of the diffculty for writing to the leaderboard
        /// </summary>
        /// <returns> string of the difficulty level</returns>
        private string difficultyToString()
        {
            string difficultyString = "";
            switch (difficulty)
            {
                case 8:
                    difficultyString = "Hard";
                    break;
                case 10:
                    difficultyString = "Medium";
                    break;
                case 12:
                    difficultyString = "Easy";
                    break;
            }

            return difficultyString;
        }

        /// <summary>
        /// This event handler makes the time increment by one second at a time or 1000 ms
        /// </summary>
        private void tmr_GameTimer_Tick(object sender, EventArgs e)
        {
            secondsPlayed++;
        }

        /// <summary>
        /// This method is used to interpret the count of black and white pins from solution to the visual version that the user will see. It also
        /// checks for winner as well, if a winner is found it opens a new form if the user wants to play again and the new form calls a new instance 
        /// of the game. 
        /// </summary>
        /// <param name="guess"> this is the current user guess </param>
        private void drawPins(GuessClass guess)
        {
            if (solution.isMatch(guess.intGuessList) == true)
            {
                string buttonName = "btn_Pin" + index;
                tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                buttonName = "btn_Pin" + (index + 1);
                tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                buttonName = "btn_Pin" + (index + difficulty * 2);
                tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                buttonName = "btn_Pin" + (index + difficulty * 2 + 1);
                tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                tlp_Solution.Visible = true;
                tmr_GameTimer.Stop();
                Player player = new Player(txt_Name.Text, difficultyToString(), guessCount, secondsPlayed.ToString());
                leaderboard.addPlayer(player);
                DialogResult dialogResult = MessageBox.Show("You have Won the Game, Would you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    leaderboard.writeLeaderboard();
                    this.Hide();
                    frm_NewGame newGame = new frm_NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {
                    leaderboard.writeLeaderboard();
                    Application.Exit();
                }
            }
            else
            {
                if (guessCount + 1 != difficulty)
                {
                    MessageBox.Show("No Good Try again.");
                }
                else
                {
                    tlp_Solution.Visible = true;
                    DialogResult dialogResult = MessageBox.Show("You have lost the Game, Would you like to play again?", "Game Over", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Hide();
                        frm_NewGame newGame = new frm_NewGame();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }

            int count = 0;
            if (solution.hint.getBlackPegCount() != 0)
            {
                for (int i = 0; i < solution.hint.getBlackPegCount(); i++)
                {
                    if (i == 0)
                    {
                        string buttonName = "btn_Pin" + index;
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                    }
                    else if (i == 1)
                    {
                        string buttonName = "btn_Pin" + (index + 1);
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                    }
                    else if (i == 2)
                    {
                        string buttonName = "btn_Pin" + (index + difficulty * 2);
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                    }
                    else if (i == 3)
                    {
                        string buttonName = "btn_Pin" + (index + difficulty * 2 + 1);
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.Black;
                    }
                    count = solution.hint.getBlackPegCount();
                }
            }

            if (solution.hint.getWhitePegCount() != 0)
            {
                for (int j = count; j < count + solution.hint.getWhitePegCount(); j++)
                {
                    if (j == 0)
                    {
                        string buttonName = "btn_Pin" + index;
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.White;
                    }
                    else if (j == 1)
                    {
                        string buttonName = "btn_Pin" + (index + 1);
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.White;
                    }
                    else if (j == 2)
                    {
                        string buttonName = "btn_Pin" + (index + difficulty * 2);
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.White;
                    }
                    else if (j == 3)
                    {
                        string buttonName = "btn_Pin" + (index + difficulty * 2 + 1);
                        tlp_Pins.Controls[buttonName].BackColor = System.Drawing.Color.White;
                    }
                }
            }

            index += 2; 
        }

        /// <summary>
        /// This is a override for the "X" buttton on the form so when it clicked it closes all forms and stops the program
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        /// <summary>
        /// This click event is for the switch back and forth to dark and light theme
        /// </summary>
        private void btn_Theme_Click(object sender, EventArgs e)
        {   
            if(btn_Theme.Text == "Dark")
            {
                btn_Theme.Text = "Light";
                this.BackColor = darkTheme;
                btn_Theme.BackColor = lightTheme;
            }else 
            {
                btn_Theme.Text = "Dark";
                this.BackColor = lightTheme;
                btn_Theme.BackColor = darkTheme;
            }
        }
    }
}
