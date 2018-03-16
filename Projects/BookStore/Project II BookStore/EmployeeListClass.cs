/* Class: EmployeeListClass
 * Class Description: Contains an Internal List of Employee Objects
 * Contains methods to interpret data from currentEmployeeFile and adding that data into the object list
 * Ability to write out data contained in InternalList to updatedEmployeeFile
 * Robert Plata
 * 3/10/2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II_BookStore
{
    class EmployeeListClass
    {
        public ArrayList InternalList = new ArrayList(); // Array of all Employee Objects from currentEmployeeFile
        int index; // Index location where current logged employee object is stored

        
        // Display MessageBox of Employee information
        public void displayEntireList()
        {
            foreach(EmployeeClass employee in InternalList) // Every Employee in the list
            {
                MessageBox.Show(employee.createStringToDisplay()); // Create display string
            }
        }

        // Search InternalList for object with AccessID that matches ID entered by Employee (save and return index of employee)
        public EmployeeClass findEmployeeInList(int accessID)
        {
            foreach (EmployeeClass employee in InternalList) // Iteration through entire InternalList
            {
                if (employee.checkEmployeeID(accessID)) // Check if employee hiddenAccessID matches entered ID
                {
                    employee.createStringToDisplay(); // String object to dislay information created within object
                    this.index = InternalList.IndexOf(employee); // Index in class is now current index of matched employee object
                    return employee; // Object returned
                }
            }
            return null; // No employee object matched the AccessID entered by the user
        }

        // Return number of elements in InternalList object
        // return integer
        public int getCount()
        {
            return InternalList.Count; // int type attribute returned
        }

        // Read each record from currentEmployeeFile subsequently adding it to InternalList object
        public Boolean initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;

            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                EmployeeClass emp = new EmployeeClass();
                success = emp.createEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("Unable to create an Employee Object.  Employee list not created.",
                        "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                InternalList.Add(emp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            } //end While

            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        }  // end initializeEntireList


        // Update last date of access in object to todays date
        public void updateEmployeeObject()
        {
            EmployeeClass emp = (EmployeeClass)InternalList[index]; // Reference to Array object
            emp.hiddenLastDateOfAccess = DateTime.Now; // Change lastDateOfAccess to current 
        }

        // Calls verifyPin in Employee class passing the Pin
        public Boolean verifyPin(int Pin)
        {
            EmployeeClass employee = (EmployeeClass)InternalList[index]; // reference object inside of arraylist
            if (employee.verifyPin(Pin))
            {
                updateEmployeeObject(); // Update the last transaction date of Employee
                return true; // Match
            }
            return false; // No match
        }

        // Writes the contents of the entire EmployeeList object to the updatedEmployeeFile object
        // Write record (User who logged in) first
        // Write the remaining records (copyRemainingRecords(String))
        public void writeEntireList(updatedFileClass updatedEmployeeFile)
        {
            EmployeeClass thisEmployee = (EmployeeClass)InternalList[index]; // Reference object in list
            string firstRecord = thisEmployee.getEmployeeDataString(); // Record that should be written first
            updatedEmployeeFile.writeNextRecord(firstRecord); // Write out the logged in employee first
            Globals.BookStore.copyRemainingRecords(firstRecord); // Rest of the records in the list that don't include the first record
        }
        
        // Get hiddenName from EmployeeClass Object
        public string getName()
        {
            EmployeeClass emp = (EmployeeClass)InternalList[index];
            return emp.getName();
        }

    }
}
