using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazzocchiPlata_Mastermind
{
    /// Robert Plata & Brett Mazzocchi
    /// Date Created: 04/11/2018
    /// <summary>
    /// This is the class that owns and manages the blck and white peg count
    /// </summary>
    class HintGenerator
    {
        /// White pegs indicate a matching color whereas black pegs indicate a matching color that is in the right position
        int whitePegCount = 0;
        int blackPegCount = 0;

        /// <summary>
        /// This method is the constructor for this class and it also is called on to set the current guesses black and white peg count
        /// </summary>
        /// <param name="black"></param>
        /// <param name="white"></param>
        public HintGenerator(int black, int white)
        {
            this.blackPegCount = black;
            this.whitePegCount = white;

        }

        /// <summary>
        /// This method is the getter for black peg count
        /// </summary>
        /// <returns> black peg count</returns>
        public int getBlackPegCount()
        {
            return blackPegCount;
        }

        /// <summary>
        /// This method is the getter for white peg count
        /// </summary>
        /// <returns> white peg count</returns>
        public int getWhitePegCount()
        {
            return whitePegCount;
        }

        /// <summary>
        /// This method determines if user has maximum amount of black pegs(4 black pegs) and has won the game
        /// </summary>
        /// <returns> returns true if winner is found false if not </returns>
        public bool isWinner()
        {
            if (blackPegCount == 4) // Black pegs equal 4
            {
                return true;
            }
            return false; // Black pegs do not equal 4
        }

        /// <summary>
        /// This method reset the values of the black and white pegs
        /// </summary>
        public void resetPegs()
        {
            this.whitePegCount = 0;
            this.blackPegCount = 0;
        }


    }
}
