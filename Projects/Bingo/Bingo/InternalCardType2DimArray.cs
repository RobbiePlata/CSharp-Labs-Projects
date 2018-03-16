using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    class InternalCardType2DimArray
    {
        int BINGOCARDSIZE = 0;
        char[,] board;

        // Class constructor setting Bingo card size
        public InternalCardType2DimArray(int BINGOCARDSIZE)
        {
            this.BINGOCARDSIZE = BINGOCARDSIZE;
            board = new char[BINGOCARDSIZE, BINGOCARDSIZE];
            setBoardBlank();
        }

        // Set board to blank except for free space
        public void setBoardBlank()
        {
            for (int row = 0; row < BINGOCARDSIZE-1; row++)
            {
                for (int col = 0; col < BINGOCARDSIZE-1; col++)
                {
                    board[row, col] = 'B';
                }
            }
            board[2, 2] = 'M';
        }

        // Method to mark called number at [row, col] in 2D array
         public void recordCalledNumber(int rowID, int colID)
        {
            board[rowID, colID] = 'M';
        }

        // Determine if player has bingo configuration
        public int isWinner(int rowID, int colID)
        {
            if (checkVertical() == true || checkHorizontal() == true || checkDiagonal() == true || checkForwardDiagonal() == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Check all columns for vertical alignment
        private bool checkVertical()
        {
            bool bingo = false;
            int numMarked = 0;
            for(int col = 0; col < BINGOCARDSIZE; col++)
            {
                for(int row = 0; row < BINGOCARDSIZE; row++)
                {
                    if(board[row, col] == 'M')
                    {
                        numMarked++;
                        if(numMarked == BINGOCARDSIZE)
                        {
                            bingo = true;
                            return bingo;
                        }
                    }
                }
                numMarked = 0;
            }
            return bingo;
        }

        // Check all rows for horizonal alignment
        private bool checkHorizontal()
        {
            bool bingo = false;
            int numMarked = 0;
            for (int col = 0; col < BINGOCARDSIZE; col++)
            {
                for (int row = 0; row < BINGOCARDSIZE; row++)
                {
                    if (board[col, row] == 'M')
                    {
                        numMarked++;
                        if (numMarked == BINGOCARDSIZE)
                        {
                            bingo = true;
                            return bingo;
                        }
                    }
                }
                numMarked = 0;
            }
            return bingo;
        }

        // Uses single for loop to check diagonal alignment
        private bool checkDiagonal()
        {
            bool bingo = false;
            int numMarked = 0;
            for(int i = 0; i < BINGOCARDSIZE; i++)
            {
                if (board[i,i] == 'M')
                {
                    numMarked++;
                }
                if(numMarked == BINGOCARDSIZE)
                {
                    bingo = true;
                    return bingo;
                }
            }
            return bingo;
        }

        // Checks forward diagonal alignment using for loop
        private bool checkForwardDiagonal()
        {
            bool bingo = false;
            int numMarked = 0;
            int row = BINGOCARDSIZE-1;
            for (int col = 0; col < BINGOCARDSIZE; col++)
            {
                if (board[row, col] == 'M')
                {
                    row --;
                    numMarked++;
                    if (numMarked == BINGOCARDSIZE)
                    {
                        bingo = true;
                        return bingo;
                    }
                }
            }
            return bingo;
        }

    }
}
