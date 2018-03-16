/* BOOK STORE
 * Robert Cyril Plata III
 * Dr Friedman
 * CIS 3309
 * Class: EmployeeAccessIDEntryForm
 * Description:
 * To ensure the validity the ID of an Employee is properly entered and existing within the file stored.
 * Includes necessary Methods to ensure valid text entry before validation (is a number with length of 5)
 * 3 tries
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II_BookStore
{
    public partial class EmployeeAccessIDEntryForm : Form
    {

        int accessAttempts = 0; // Amount of times the user has attempted a accessID entry (incremented by btnFindMe)

        // Constructor for EmployeeAccessIDEntryForm
        public EmployeeAccessIDEntryForm()
        {
            InitializeComponent();
            Globals.BookStore.EmployeeList.initializeEntireList(); // Add all employee objects to InternalList
            int count = Globals.BookStore.EmployeeList.InternalList.Count; // Count of records in List
            // MessageBox.Show("Records Read: " + count); // Display the number of records read
            // Globals.BookStore.EmployeeList.displayEntireList(); // Display Records in list
        }

        // Find Me button event handler to initiate verification AccessID exists in Employee Objects
        // Safe entry verifying the validity of the inputted data (Length 5 entry only digits)
        // Verification of AccessID existence within employee object
        private void btnFindMe_Click(object sender, EventArgs e)
        {
            accessAttempts++;
            if (safeAccessIDEntry()) // Entry fulfilled requirements
            {
                Boolean found;
                int intTxtEntry = Convert.ToInt32(txtEntry.Text);
                Globals.BookStore.findEmployee(intTxtEntry, out found);
                if (found == true) // Employee AccessID found
                {
                    EmployeePinEntryForm employeePinEntryForm = new EmployeePinEntryForm(); // Create pin entry form
                    employeePinEntryForm.Show(); // Reveal new form
                    this.Hide(); // Hide current form
                }
                else if (accessAttempts == 3) // AccessID attempts equals 3
                {
                    MessageBox.Show("You have passed the three try limit. Program will now terminate.");
                    Application.Exit(); // Termination
                }
                else
                {
                    txtEntry.Text = "";
                    txtEntry.Focus();
                    MessageBox.Show("Employee Not Found. This is attempt " + accessAttempts + " out of 3");
                }
            }
            else if(accessAttempts == 3) // Pin attempts equals 3
            {
                MessageBox.Show("You have passed the three try limit. Program will now terminate.");
                Application.Exit(); // Termination
            }
        }

        // Method used in safeAccessIDEntry()
        // Verifies the input from txtEntry is a number and return boolean operators
        private Boolean isNumeric()
        {
            string Str = txtEntry.Text; // String value
            double Num; // declare double
            bool isNum = double.TryParse(Str, out Num); // Boolean TryParse of string
            if (isNum) // If string completely converts to number then return true or else
            {
                return true; // Fully converts
            }
            else
            {
                return false; // Doesn't properly convert
            }
        }

        // Verifies the input for Pin is:
        // 1. Not empty
        // 2. Numeric
        // 3. Length of 5
        // Inform user of invalid inputs
        private Boolean safeAccessIDEntry()
        {
            if (String.IsNullOrEmpty(txtEntry.Text) == false) // User's input is not blank
            {
                if (isNumeric() == true) // User's entry verified as a number
                {
                    if (txtEntry.Text.Length == 5) // User's entry contained exactly 5 digits
                    {
                        return true;
                    }
                    else // User's Entry did not contain 5 digits
                    {
                        MessageBox.Show("Please enter exactly 5 digits\n This is attempt " + accessAttempts + " out of 3");
                        txtEntry.Text = "";
                        txtEntry.Focus();
                        return false;
                    }
                }
                else // User's entry contained a non-number character
                {
                    MessageBox.Show("Please use numbers\nThis is attempt " + accessAttempts + " out of 3");
                    txtEntry.Text = "";
                    txtEntry.Focus();
                    return false;
                }
            }
            else // User's Entry was a blank input
            {
                MessageBox.Show("AccessID cannot be blank\nThis is attempt " + accessAttempts + " out of 3");
                txtEntry.Text = "";
                txtEntry.Focus();
                return false;
            }
        }

        // Program closes if form is closed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

    }
}
