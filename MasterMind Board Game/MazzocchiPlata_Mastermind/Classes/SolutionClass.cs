using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazzocchiPlata_Mastermind
{
    /// Robert Plata & Brett Mazzocchi
    /// Date Created: 04/11/2018
    /// <summary>
    /// This is the class that handles everything with the internal solution
    /// </summary>
    class SolutionClass
    {
        public int[] solutionArray;// the int array that the current game's solution is stored in
        public HintGenerator hint;// a hintGenerator object that is declared but not instaitated untill "isMatch" is called and wriiten over everytime "isMatch" is called
        
        /// <summary>
        /// This method is the constructor of this class and it is used to call the "createRandomSolution" method to fill the "solutionArray" with a solution
        /// </summary>
        public SolutionClass()
        {
            createRandomSolution();
        }

        /// <summary>
        /// This method is used to create a random number generator that fills "solutionArray" with random ints between 0 and 5
        /// </summary>
        private void createRandomSolution()
        {
            solutionArray = new int[4];
            Random randomNumber = new Random();
            for (int i = 0; i < 4; i++)
            {
                solutionArray[i] = randomNumber.Next(0, 6);
            }
        }

        /// <summary>
        /// This method is the algorithm method for checking the users current guess against the solution. It does this by creating a list of ints 
        /// that represent indexs that have been marked a full match meaning same color and position. Then, with for loops increments throught the 
        /// two int lists(guess and solution). If a full match is found it blacklists that index in both list so not to over count pin. After it 
        /// checks for black pins it stores the current values in the now instantiated "hintGenerator" class which checks if a winner is found if not
        /// it moves on to counting white pin skipping indexes that have had full matches and finally setting the final pin count.
        /// </summary>
        /// <param name="guess"> the current guess received by user</param>
        /// <returns> returns true if winer is found false if not </returns>
        public bool isMatch(List<int> guess) 
        {
            int blackPinCount = 0;
            int whitePinCount = 0;
            List<int> correctIndex = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == solutionArray[i])
                {
                    blackPinCount++;
                    correctIndex.Add(i);
                }
            }

            hint = new HintGenerator(blackPinCount, whitePinCount);
            
            if(blackPinCount == 4)
            {

                return hint.isWinner();
            }
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (correctIndex.Contains(j))
                    {
                        continue;
                    }
                    if (j != i)
                    {
                        if (guess[i] ==  solutionArray[j])
                        {
                            correctIndex.Add(j);
                            whitePinCount++;
                            continue;
                        }
                    }
                }
            }
            
            hint = new HintGenerator(blackPinCount, whitePinCount); 
            
            return hint.isWinner();
        }


    }
}
