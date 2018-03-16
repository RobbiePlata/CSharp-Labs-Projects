/* Class: EmployeeClass
 * Class Description:
 * Used to describe employees using five unique attributes
 * Attributes of this class are compared against the users input 
 * Ensure the ID they enter matches the Pin of the same object
 * Robert Plata 
 * 3/10/2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II_BookStore
{
    class EmployeeClass
    {

        public string hiddenName; // Name of Employee (not blank)
        public int hiddenAccessID; // ID of matching hiddenName of Employee (5 digit int)
        public int hiddenPin; // Pin matching the hiddenAccessID of Employee (4 digit int)
        public decimal hiddenAnnualPay; // Annual Pay of employee used in MessageBox (decimal)
        public DateTime hiddenLastDateOfAccess; // Date of employee's last access to Book Store (DateTime)

        int validAccessIDLength = 5; // Required digit Length for AccessID
        int validPinLength = 4; // Required digit Length for Pin

        // String containing the 5 attributes in this class
        string employeeDataString;

        // Compare the Employee Access ID entered by the user to the Access ID in a list element. Return True or False Statement
        public Boolean checkEmployeeID(int accessID)
        {
            if (hiddenAccessID == accessID) 
            {
                return true; // Match
            }
            else 
            {
                return false; // No match
            }
        }

        // Takes String type from text file; Splitting it into 5 components to create an employee object to add to EmployeeListClass
        // (All 5 elements are validated here)
        public Boolean createEmployeeObject
            (string s)  // IN: string from the Employee Text File
        {

            EmployeeClass thisEmployee = this;
            string[] employeeString = s.Split('*');
            employeeString[0] = employeeString[0].Trim(); // Trim starting and trailing whitespaces from AccessID
            employeeString[2] = employeeString[2].Trim(); // Trim starting and trailing whitespaces from Pin

            int employeeStringSize = employeeString.GetLength(0);
            

            // Convert AccessID to an integer of required length
            if (employeeString[0].Length != validAccessIDLength)
            {
                MessageBox.Show(employeeString[0]
                    + ": AccessID string is not exactly 5 characters. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenAccessID = Convert.ToInt32(employeeString[0]);
            }
            catch
            {
                MessageBox.Show(employeeString[0]
                    + " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Name string to string (no conversion)
            hiddenName = employeeString[1];
            if (hiddenName == " " || hiddenName == "")
            {
                MessageBox.Show(hiddenName
                    + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                      "Name in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert Pin to an integer of required length
            if (employeeString[2].Length != validPinLength)
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenPin = Convert.ToInt32(employeeString[2]);
            }
            catch
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is empty or Blank. Employee File Corrupt.  Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert annualPay to a positive decimal
            try
            {
                hiddenAnnualPay = Convert.ToDecimal(employeeString[3].Replace(",",
                    "").Replace("$", ""));
                if(hiddenAnnualPay < 0.00m)
                {
                    MessageBox.Show(employeeString[3]
                        + ": Annual Pay must be a non negative decimal. Employee File Corrupt. Execution Terminated.",
                        "Annual pay in Employee File Invalid",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(employeeString[3]
                    + ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                      "Annual pay in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert last Date of Access to a date
            try
            {
                hiddenLastDateOfAccess = DateTime.Parse(employeeString[4]);
            }
            catch
            {
                MessageBox.Show(employeeString[4]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // All data valid
            return (true);
        }  // end createEmployeeObject


        // Converts Employee attributes to a string suitable for MessageBox Display
        public string createStringToDisplay()
        {
            string str = "Access ID: " + hiddenAccessID + "\nName: " + hiddenName
                + "\nAnnual Pay: " + hiddenAnnualPay + "\nLast Date of Access: " + hiddenLastDateOfAccess.ToShortDateString();
            return str;
        }

        // Getter for employeeDataString
        public string getEmployeeDataString()
        {
            this.employeeDataString = hiddenAccessID + " * " + hiddenName + " * " + hiddenPin + " * " + hiddenAnnualPay + " * " + hiddenLastDateOfAccess.ToShortDateString();
            return employeeDataString;
        }

        // Updates the last date of access for an employee to the current DateTime
        public void updateEmployeeTransactionDate()
        {
            this.hiddenLastDateOfAccess = DateTime.Now; // DateTime updated to current DateTime using getter
        }

        // Checks to see if Pin entered matches the corresponding to the AccessID previously entered
        public Boolean verifyPin(int PinID)
        {
            if (hiddenPin == PinID) // Object pin matches user pin
            {
                return true;
            }
            else // Object pin does not match user pin
            {
                return false;
            }
        } // end verifyPin

        // Return users Name
        public string getName()
        {
            return hiddenName;
        }
    }
}
