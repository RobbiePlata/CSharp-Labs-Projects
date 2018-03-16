// Class: BookStoreClass
// Class Description: Includes all of the required static file instances used to write out information to the file
// Includes useful methods to find Employee and Book objects to be compared.
// Book object is stored here and used just as the default code implied
// Includes methods to write data to updatedFileClass types
// Check duplicate record class not required due to the add button being disabled upon a matching ISBN
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
    class BookStoreClass
    {
        // Books and the EmployeeList and all the text files belong to the Bookstore
        public BookClass Book = new BookClass();
        public EmployeeListClass EmployeeList = new EmployeeListClass();

        // The Files the Bookstore Owns
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";

        public static currentFileClass currentBookFile = new currentFileClass(currentBookFilePath);
        public static updatedFileClass updatedBookFile = new updatedFileClass(updatedBookFilePath);
        public static currentFileClass currentEmployeeFile = new currentFileClass(currentEmployeeFilePath);
        public static updatedFileClass updatedEmployeeFile = new updatedFileClass(updatedEmployeeFilePath);

        // Bookstore parameters (Named constants defined by the Bookstore)
        private int hiddenAccessIDLength = 5;   // Length of AccessNet ID
        private int hiddenISBNLeftLength = 3;   // Length of left part of ISBN
        private int hiddenISBNRightLength = 3;  // Length of right part of ISBN
        // Number of attempts BookStore allows a user before terminating an inventory 
        //    update session
        private int hiddenTryCountMax = 3;
        
        // Close all external files currently open
        public void closeFiles()
        {
            currentBookFile.closeFile();
            currentEmployeeFile.closeFile();
            updatedBookFile.closeFile();
            updatedEmployeeFile.closeFile();
        }
        
        // Iteration through every employee which has not been written to updatedEmployeeFile yet
        // (Employee who logged in was printed first)
        public void copyRemainingRecords(string previouslyWrittenEmployee)
        {
            foreach (EmployeeClass employee in Globals.BookStore.EmployeeList.InternalList) // Write out the rest
            {
                if(employee.getEmployeeDataString() != previouslyWrittenEmployee) // data string of employee has not been written yet
                {
                    updatedEmployeeFile.writeNextRecord(employee.getEmployeeDataString()); // Write Record of employee data string to updatedEmployeefile
                }
            }
            updatedEmployeeFile.closeFile(); // Close file
        }

        // Given a Book ISBN (entered by the user) and a book record (read from currentBookFile) 
        // checks to see if the user ISBN matches the record ISBN (the first field of the record). 
        // If there is a match, this method splits the record into its 6 component parts and saves them. 
        // Every Record that does not match the ISBN entered by the user will be written to updatedBookFile
        public Boolean findAndSaveBook(string ISBN)
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            Boolean found = false;

            nextRecord = BookStoreClass.currentBookFile.getNextRecord(ref isEndOfFile); // Get the first record
            while (!isEndOfFile)
            {
                BookClass newBook = new BookClass(); // Object declared and referenced
                success = newBook.createBookObject(nextRecord); // Create a new book object with the attributes assigned

                if (success == true) // Book object not successfully created
                {
                    if (newBook.bookMatch(ISBN) == true) // Comparing Book hiddenISBN to user's inputted ISBN
                    {
                        this.Book = newBook; // Book assigned to this BookStoreClass object
                        MessageBox.Show("Book Found!\n" + Book.createStringToDisplay()); // Display the book
                        found = true; // (Book found)
                    }
                    else // Book doesn't match ISBN
                    {
                        updatedBookFile.writeNextRecord(newBook.getBookDataString()); // Write out book that didn't match ISBN to updatedBookFile
                    }
                    nextRecord = BookStoreClass.currentBookFile.getNextRecord(ref isEndOfFile); // Get the next record to analyze
                }
            }
            return found;
        }
        
        
        // Find Employee in Employee List
        // Returns a reference to the employee found and (through an argument) returns
        //     true or false
        public EmployeeClass findEmployee
            (int ID,              // IN: employee ID to be found   
             out Boolean found)   // OUT: flag indicating if Employee ID found in current
                                  //      Employee object
        {
            EmployeeClass emp;    // reference to current Employee being checked for ID

            if ((emp = EmployeeList.findEmployeeInList(ID)) != null)
            {
                found = true;
            }
            else
                found = false;
            return emp;
        }  // end findEmployee
        
        // Displays the list of the employees (After they were written to the Employee File)
        public void writeEntireEmployeeList()
        {
            EmployeeList.writeEntireList(updatedEmployeeFile); // Write out entire list to updatedEmployeeFile
            // EmployeeList.displayEntireList(); // Display the contents in employee list through message boxes
        }   // end writeEntireEmployeeList

        // Write the entire contents of one Book record to updatedBookFile
        public void writeOneRecord(string str)
        {
           updatedBookFile.writeNextRecord(str);; // Write data string out to updatedBookFile
        }
        
    }
}
