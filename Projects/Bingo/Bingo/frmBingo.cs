﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class frmBingo : Form
    {
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;
        private string userName;  // Name of user to be used in messageboxes

        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        // for first number it was set to 1
        int countOfCalledNumbers = 1;
        char nextCalledLetter;
        int nextCalledNumber;

        private InternalCardType2DimArray internalCardRep2DArray = new InternalCardType2DimArray(BINGOCARDSIZE);
        private RNGType RNGObj = new RNGType();

        private string bingoLetters = "BINGO";

        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(btnCell_Clicked);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar

        private int convertCharToInt(char character)
        {
            double temp = Char.GetNumericValue(character);
            int result = Convert.ToInt32(temp);
            return result;
        }

        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void btnCell_Clicked(object sender, EventArgs e)
        {
            int bingoCount2D;
            int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            if(rowID == 2 && colID == 2)
            {
                MessageBox.Show("That is already a Free Space");
                return;
            }
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                internalCardRep2DArray.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                // Check for winner
                // Go here if player found the number called in his or her card
                // Check for winner for either internal representation
                bingoCount2D = internalCardRep2DArray.isWinner(rowID, colID);
                if ((bingoCount2D > 0))
                {
                    MessageBox.Show("Congratulations " + userName + "! " + "You are a Winner!", "Winner Found! \n"
                        + "Bingos count = " + (bingoCount2D) + ". Game over!");
                    Close();
                }  // end inner if

                playTheGame();
            }
            else
            {
                MessageBox.Show("Called number does not match the one in the box you selected."
                          + "Try again!", "Numbers Do Not Match");
            } // end outer if
            btnDontHave.Focus();
        } // end button clickhandler 

        // Method called to get the next bingo number and add previous numbers to the count
        void playTheGame()
        {
            if (countOfCalledNumbers < MAXBINGONUMBER)
            {
                countOfCalledNumbers++;
                nextCalledNumber = RNGObj.getNextUniqueRandomValue(1, MAXBINGONUMBER);
                nextCalledLetter = bingoLetters[(nextCalledNumber - 1) / NUMBERSPERCOLUMN];
                txtNumberCalled.Text = nextCalledLetter + " " + nextCalledNumber.ToString();
            }
            else
            {
                MessageBox.Show(userName + ", All numbers have been called. You lose");
                this.Close();
            }
        }

        // Constructor to create card panel using method
        public frmBingo()
        {
            InitializeComponent();
            createCard();
        }
        
        // Button with method to close the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button which calls method to get new bingo number
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            // set number to true in usedNumbers in SelectedNumbersListType
            playTheGame();
        }

        // Button which sets object visibility and enabled properties to true
        private void btnYes_Click(object sender, EventArgs e)
        {
            // if user name in txtbox is blank{ "enter name message"
            string userName = txtEnterName.Text;
            this.userName = userName;
            lblDirections.Enabled = true;
            lblDirections.Visible = true;
            txtNumberCalled.Enabled = true;
            txtNumberCalled.Visible = true;
            btnDontHave.Enabled = true;
            btnDontHave.Visible = true;
            txtNumberCalled.Enabled = true;
            txtNumberCalled.Visible = true;
            pnlCard.Enabled = true;
            pnlCard.Visible = true;
            playTheGame();
            btnDontHave.Focus();
        }

        // Event handler which enables Yes button if text is entered
        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            btnYes.Enabled = true;
        }
        
    }
}
