using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class SelectedNumbersListType
    {
        // Array of numbers used previously including 0 to start
        bool[] usedNumbers =  new bool[75];
        
        // Set bool array to false to indicate numbers have not been used yet
        public SelectedNumbersListType()
        {
            for(int i = 0; i < usedNumbers.Length; i++)
            {
                usedNumbers[i] = false;
            }
            usedNumbers[0] = true;
        }

        // Set selected number to true to indicate that number has been used
        public void setUsedNumber(int selectedNumber)
        {
            usedNumbers[selectedNumber] = true;
        }

        // Reset usedNumbers to false to reset bool array
        public void reset()
        {
            for(int i = 1; i < usedNumbers.Length; i++)
            {
                usedNumbers[i] = false;
            }
        }

        // Return bool value of whether number has been used
        public bool isNumberUsed(int rn)
        {
            if (usedNumbers[rn] != true)
            {
                return false;
            }
            else {
                return true;
            }       
        }

    }
}
