// EmployeePinEntryForm
// Description: To ensure a valid input of text whose characters are all numeric-
// -Not Blank, and length of 4. Three Attempts can be made before termination of program.
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
    public partial class EmployeePinEntryForm : Form
    {
        int pinAttempts = 0; // Amount of times the user has attempted a pin entry (incremented by btnOK)

        public EmployeePinEntryForm()
        {
            InitializeComponent();
        }

        // OK button event handler to initiate the structural verification of employee object
        // Safe entry verifying the validity of the inputted data (Length 4 entry only digits) (only 3 attempts on Pin)
        // Structural verification of object with AccessID matching the Pin
        private void btnOK_Click(object sender, EventArgs e)
        {
            pinAttempts++; // Attempt incremented
            if (safePinEntry()) // Entry fulfilled requirements
            {
                int intPinEntry = Convert.ToInt32(txtPin.Text);
                if (Globals.BookStore.EmployeeList.verifyPin(intPinEntry)) // Employee Pin Match
                {
                    MessageBox.Show("Welcome " + Globals.BookStore.EmployeeList.getName()); // Welcome user with their name

                    Globals.BookStore.writeEntireEmployeeList(); // Write out all of the records and display the records of the InternalList

                    TransactionSelectForm transactionSelectFrm = new TransactionSelectForm(); // New form object created
                    transactionSelectFrm.Show(); // Reveal Form
                    this.Hide(); // Hide current form
                }
                else if (pinAttempts == 3) // Pin attempts equals 3
                {
                    MessageBox.Show("You have passed the three try limit. Program will now terminate.");
                    Application.Exit(); // Termination
                }
                else // Pin entry did not verify (match the object pin)
                {
                    MessageBox.Show("Pin does not match. This attempt " + pinAttempts + " out of 3");
                    txtPin.Text = "";
                }
            }
            else if (pinAttempts == 3) // Pin attempts equals 3
            {
                MessageBox.Show("You have passed the three try limit. Program will now terminate.");
                Application.Exit(); // Termination
            }
        }

        // Method used in safePinEntry() to Verify that input from txtEntry is a number and return boolean operators
        private Boolean isNumeric()
        {
            string Str = txtPin.Text; // String value
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
        // 3. Length of 4
        // Inform user of invalid inputs
        private Boolean safePinEntry()
        {
            if (String.IsNullOrEmpty(txtPin.Text) == false) // User's input is not blank
            {
                if (isNumeric() == true) // User's entry verified as a number
                {
                    if (txtPin.Text.Length == 4) // User's pin contained exactly 4 digits
                    {
                        return true;
                    }
                    else // User's Entry did not contain 5 digits
                    {
                        MessageBox.Show("Please enter exactly 4 digits\nThis is attempt " + pinAttempts + " out of 3");
                        txtPin.Text = "";
                        txtPin.Focus();
                        return false;
                    }
                }
                else // User's entry contained a non-number character
                {
                    MessageBox.Show("Please use numbers\nThis is attempt " + pinAttempts + " out of 3");
                    txtPin.Text = "";
                    txtPin.Focus();
                    return false;
                }
            }
            else // User's Entry was a blank input
            {
                MessageBox.Show("AccessID cannot be blank\nThis is attempt " + pinAttempts + " out of 3");
                txtPin.Text = "";
                txtPin.Focus();
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
