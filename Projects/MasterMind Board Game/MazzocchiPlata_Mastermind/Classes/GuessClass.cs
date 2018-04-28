using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MazzocchiPlata_Mastermind
{
    /// Robert Plata & Brett Mazzocchi
    /// Date Created: 04/11/2018
    /// <summary>
    /// This is the class that holds and formats the current users guess
    /// </summary>
    class GuessClass
    {
        public List<int> intGuessList = new List<int>();// this is the list of ints that has been translated by this class from strings of button colors to ints

        /// <summary>
        /// This method is the constructor of the class that takes in the users guess and securely passes it to the private function 
        /// that translates it to ints below in this class this is done this way to prevent data leakage into other classes
        /// </summary>
        /// <param name="guess"> this is the list of color that the user guessed that is later translated to ints </param>
        public GuessClass(List<string> guess)
        {
            createGuessList(guess);
        }

        /// <summary>
        /// This method called everytime the user makes a guess and it works by the taking the users guess that they entered
        /// by clicking the colors for there guess it is stored into a list of strings of the buttons colors. then, Translates
        /// those color int to a int list that can be understood by the program and later checked for correctness 
        /// </summary>
        /// <param name="guess">this is the list of color that the user guessed that is translated to ints</param>
        private void createGuessList(List<string> guess)
        {
            for (int i = 0; i < 4; i++)
            {
                int buttonValue = 6;
                switch (guess[i])
                {
                    case "Color [Red]":
                        buttonValue = 0;
                        break;
                    case "Color [Orange]":
                        buttonValue = 1;
                        break;
                    case "Color [Yellow]":
                        buttonValue = 2;
                        break;
                    case "Color [Lime]":
                        buttonValue = 3;
                        break;
                    case "Color [Blue]":
                        buttonValue = 4;
                        break;
                    case "Color [Purple]":
                        buttonValue = 5;
                        break;

                }

                intGuessList.Add(buttonValue);
            }
        }

    }
}
