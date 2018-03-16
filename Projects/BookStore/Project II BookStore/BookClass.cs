// Class: BookClass
// Class Description: To store book related information as an object to be written to updatedBookFile object
// This class includes all relevant attributes of a book and confirms ISBN in class
// Robert Plata 
// 3/10/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II_BookStore
{
    class BookClass
    {
        string hiddenISBN; // 3 digits, a hyphen, and 3 more digits: no spaces
        string hiddenTitle; // Title of book
        string hiddenAuthor; // Author of book
        decimal hiddenPrice; // Price of book
        int hiddenNumberOnHand; // Number of books in inventory
        DateTime hiddenLastTransactionDate; // Last transaction

        int validISBNLength = 7; // Allowed Length for ISBN

        string bookDataString; // String containing the 6 attributes in this class used for display

        
        // Creates an object using attributes obtained from currentBookFile Object
        // ISBN TITLE AUTHOR PRICE NUMBERONHAND TRANSACTIONDATE
        public Boolean createBookObject
            (string s)  // IN: string from the Book Text File
        {
            BookClass thisBook = this;
            string[] bookString = s.Split('*'); // Seperate strings using asterisk seperator
            bookString[0] = bookString[0].Trim(); // Trim starting and trailing whitespaces from ISBN
            bookString[3] = bookString[3].Trim(); // Trim starting and trailing whitespaces from Price
            bookString[4] = bookString[4].Trim(); // Trim starting and trailing whitespaces from NumberOnHand

            int bookStringSize = bookString.GetLength(0);
            
            // Check that ISBN is of required length
            hiddenISBN = bookString[0];
            if (bookString[0].Length != validISBNLength)
            {
                MessageBox.Show(bookString[0]
                    + ": ISBN string is not exactly 7 characters. Book File Corrupt. Execution Terminated.",
                      "ISBN in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false; // ISBN not of required length retun false
            }

            // Check that Title is not blank
            hiddenTitle = bookString[1];
            if (hiddenTitle == " " || hiddenTitle == "")
            {
                MessageBox.Show(hiddenTitle
                    + ": Title string is empty or Blank. Book File Corrupt. Execution Terminated.",
                      "Title in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false; // Title blank return false
            }

            // Check that Author is not blank
            hiddenAuthor = bookString[2];
            if (hiddenAuthor == " " || hiddenAuthor == "")
            {
                MessageBox.Show(hiddenAuthor
                    + ": Author string is empty or Blank. Book File Corrupt. Execution Terminated.",
                      "Author in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false; // Author blank return false
            }

            // Check that string of price converted to decimal greater than zero
            try
            {
                hiddenPrice = decimal.Parse(bookString[3].Replace(",", "").Replace("$", ""));
                if(hiddenPrice < 0.00m)
                {
                    MessageBox.Show(bookString[3]
                    + ": Price cannot be less than zero. Book File Corrupt.  Execution Terminated.",
                      "Price in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false; // price less than zero return false
                }
            }
            catch
            {
                MessageBox.Show(bookString[3]
                    + ": Price string is empty or Blank. Book File Corrupt.  Execution Terminated.",
                      "Price in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false; // price invalid format return false
            }

            // Convert number on hand to integer number stored as hiddenNumberOnHand
            try
            {
                hiddenNumberOnHand = Convert.ToInt32(bookString[4]);
            }
            catch
            {
                MessageBox.Show(bookString[4]
                    + ": Number on hand string is not a valid integer. Book File Corrupt. Execution Terminated.",
                      "Number on hand in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false; // Not a valid integer return false
            }
            
            // Convert last Date of Access to a date stored as hiddenLastTransactionDate
            try
            {
                hiddenLastTransactionDate = DateTime.Parse(bookString[5]);
            }
            catch
            {
                MessageBox.Show(bookString[5]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false; // invalid date format return false
            }

            // All data valid
            return (true);
        }  // end createEmployeeObject

        // Check if ISBN given by the user matches object ISBN
        public Boolean bookMatch(string ISBN)
        {
            if(hiddenISBN == ISBN)
            {
                return true; // ISBN Match
            }
            return false; // ISBN does not match
        }
        
        // Display the book's relevant information to user
        public void displayBookRecord()
        {
            string dataStr = createStringToDisplay(); // Create messagebox display string
            MessageBox.Show(dataStr); // Display created string with message
        }

        // Getter for bookDataString
        // Creates string to be written out to updatedFileClass
        // returning string
        public string getBookDataString()
        { // Set the bookDataString in object
            this.bookDataString = hiddenISBN + " * " + hiddenTitle + " * " + hiddenAuthor +
                " * $" + hiddenPrice + " * " + hiddenNumberOnHand + " * " + hiddenLastTransactionDate.ToShortDateString();
            return bookDataString; // Return data string
        }

        // Converts Book attributes to a string suitable for MessageBox Display 
        // returning string
        public string createStringToDisplay()
        {
            string str = "ISBN: " + hiddenISBN + "\nTitle: " + hiddenTitle + "\nAuthor: " + hiddenAuthor+ "\nPrice: " 
                + hiddenPrice + " \nNumber On Hand: " + hiddenNumberOnHand + "\n Last Transaction: " + hiddenLastTransactionDate.ToShortDateString();
            return str; // return newly created string
        }

        // Updates the last date of access for a book to the current DateTime
        public void updateBookTransactionDate()
        {
            this.hiddenLastTransactionDate = DateTime.Now; // DateTime updated to current DateTime using getter
        }

        // Getter for ISBN
        public string getISBN()
        {
            return hiddenISBN;
        }

        // Getter for title
        public string getTitle()
        {
            return hiddenTitle;
        }

        // Getter for author
        public string getAuthor()
        {
            return hiddenAuthor;
        }

        // Getter for price
        public decimal getPrice()
        {
            return hiddenPrice;
        }

        // Getter for number on hand
        public int getNumberOnHand()
        {
            return hiddenNumberOnHand;
        }

        // Getter for last transaction date 
        public string getLastTransactionDate()
        {
            return hiddenLastTransactionDate.ToShortDateString();
        }

    }
}
