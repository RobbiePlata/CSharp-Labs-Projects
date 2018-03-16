// Class: TransactionSelectForm
// Description: Provides the user the ability to Add, Update and Delete books by entering an ISBN number
// Entrys of data are checked to make sure they have proper inputted values
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
    public partial class TransactionSelectForm : Form
    {

        // Boolean objects turned true when certain button is activated
        // Done button uses this information to determine what actions to take
        private Boolean add = false;
        private Boolean update = false;
        private Boolean delete = false;

        // Initialize Form Components
        public TransactionSelectForm()
        {
            InitializeComponent();
        }

        // Verification that ISBN is a safeEntry
        // ISBN becomes concatenated string object
        // Certain buttons are enabled
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (safeISBNEntry()) // txtBox Entrys are considered ok to enter
            {
                btnOK.Enabled = false; // Disable button from being pressed again
                string enteredISBN = txtEnterForBook1.Text + '-' + txtEnterForBook2.Text; // Concatenation of ISBN entered by user in txtEnterForBook1 and txtEnterForBook2
                showOptionButtons(); // Reveal hidden buttons
                // ISBN Matches 
                if (Globals.BookStore.findAndSaveBook(enteredISBN) == true)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    MessageBox.Show("Select one of the following:\nUPDATE A BOOK IN INVENTORY\nTo update an existing book\nDELETE A BOOK FROM INVENTORY\nTo delete the entered book");
                }
                else
                {
                    MessageBox.Show("No match for ISBN\nSelect ADD NEW BOOK TO INVENTORY\nThis allows information to be addded about a new book");
                    btnAdd.Enabled = true;
                }
            }
        }

        // Enable all components for the user to enter a new book
        // Validate all data
        // Write new line to updatedBookFile
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill in all of the fields to add a new book to the book file");
            // Tranaction time updated to current date
            txtTransactionDate.Text = DateTime.Now.ToShortDateString();
            // Make Visible and Enable labels and text boxes for display
            visibleInfoComponents();
            // Make option buttons un-clickable
            disableOptionButtons();
            // Tranaction time updated to current date
            txtTransactionDate.Text = DateTime.Now.ToShortDateString();
            // Disable transaction date
            txtTransactionDate.Enabled = false;
            this.add = true;
            // Fill in entered ISBN
            txtISBN.Text = txtEnterForBook1.Text + "-" + txtEnterForBook2.Text;
            txtOnHand.Text = "0";
            txtPrice.Text = "0.00";
            txtTitle.Text = "Title";
            txtAuthor.Text = "Author";
            txtTransactionDate.Text = DateTime.Now.ToShortDateString();
            txtTransactionDate.Enabled = false;
            txtISBN.Enabled = false;
        }

        // Update existing book
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The existing book has been displayed in the information below." +
                " Edit the fields you desire to change, then press the done button");
            // Make Visible and Enable labels and text boxes for display
            visibleInfoComponents();
            // Retreive information to show in the text boxes
            retreiveInformation();
            // Make option buttons un-clickable
            disableOptionButtons();
            // Tranaction time updated to current date
            txtTransactionDate.Text = DateTime.Now.ToShortDateString();
            // Disable transaction date
            txtTransactionDate.Enabled = false;
            this.update = true;
            txtISBN.Enabled = false;

            // Done button is clicked
            // New string is written in updatedBookFile
        }

        // Delete existing book
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press the Done button if you would like to delete this book");
            // Make labels and text boxes visible
            visibleInfoComponents();
            // Disable info components
            disableInfoComponents();
            // Retreive information to show in the text boxes
            retreiveInformation();
            // Make option buttons un-clickable
            disableOptionButtons();

            this.delete = true;
            
            // Done button is clicked
            // Yes and No button appear
            // Yes - String is not written
            // No - String is written

        }

        // Creates and writes entry to file based on which of the three options was activated before done was pressed
        private void btnDone_Click(object sender, EventArgs e)
        {
            Boolean finished = false;
            decimal decPrice = Convert.ToDecimal(txtPrice.Text);
            decPrice = Math.Round(decPrice, 2); // Round to two decimal places
            string strPrice = decPrice.ToString(); // String includes decimal price format
            string str = txtISBN.Text + " * " + txtTitle.Text + " * " + txtAuthor.Text 
                + " * " + decPrice + " * " + txtOnHand.Text + " * " + txtTransactionDate.Text;
            
            if (add == true) // add option chosen when done button clicked
            {
                if (properInformation()) // Information properly entered
                {
                    Globals.BookStore.writeOneRecord(str); // Write book string out
                    MessageBox.Show("Book has been added and saved to file");
                    finished = true;
                    Application.Exit(); // Exit application

                }   
            }

            if (update == true) // update option chosen when done button clicked
            {
                if (properInformation()) // Information properly entered
                {
                    Globals.BookStore.writeOneRecord(str); // Write edited book out
                    MessageBox.Show("Book has been updated and saved to file");
                    finished = true;
                }
            }
            
            if(delete == true) // delete option chosen when done button clicked
            {
                MessageBox.Show("Confirm your choice with the Yes and No buttons.\nClick Yes if you would like to delete the book displayed\n" +
                    "Click no if you do not want to delete this book");
                btnYes.Visible = true;
                btnNo.Visible = true;
                btnDone.Enabled = false;
            }
            if(finished == true) // App is finished
            {
                Globals.BookStore.closeFiles(); // Close all open external files
                Application.Exit(); // Exit application
            }
            
        }
        
        // Verification that user does want to delete a book
        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book Deleted from file");
            Application.Exit(); // Exit application
        }

        // Verification button that user does NOT want to delete a book
        private void btnNo_Click(object sender, EventArgs e)
        {
            // Write book string
            string str = txtISBN + " * " + txtAuthor + " * " + txtAuthor + " * " + txtPrice + " * " + txtOnHand + " * " + txtTransactionDate;
            Globals.BookStore.writeOneRecord(str);
            MessageBox.Show("Book not deleted from file");
            Application.Exit(); // Exit Application
        }

        // Verifies the entered string in txtEnterForBook1 and 2 are:
        // 1. Not empty
        // 2. Numeric
        // 3. Length of 3
        private Boolean safeISBNEntry()
        {
            if (String.IsNullOrEmpty(txtEnterForBook1.Text) == false || String.IsNullOrEmpty(txtEnterForBook1.Text) == false) // User's input is not blank
            {
                if (isNumeric(txtEnterForBook1.Text) && isNumeric(txtEnterForBook2.Text)) // User's input is numeric value
                {
                    if (txtEnterForBook1.Text.Length == 3 && txtEnterForBook2.Text.Length == 3) // User's input is length 3 for both boxes
                    {
                        return true;
                    }
                    else
                    {
                        txtEnterForBook1.Text = "";
                        txtEnterForBook2.Text = "";
                        MessageBox.Show("Please enter 3 digits per box"); // User input length is not 3 in both boxes
                        txtEnterForBook1.Focus();
                        return false;
                    }
                }
                else
                {
                    txtEnterForBook1.Text = "";
                    txtEnterForBook2.Text = "";
                    MessageBox.Show("Please enter numbers only"); // User input is not numbers only
                    txtEnterForBook1.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter an ISBN"); // User input is blank
                return false;
            }
        }

        // Form load utilizing method determining required components activated
        private void TransactionSelectForm_Load(object sender, EventArgs e)
        {
            startingForm();
        }
        

        // Help user move focus to next txtBox by tabbing when textbox text is length 3
        private void txtEnterForBook1_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 3)
                SendKeys.Send("{Tab}");
        }

        // Help user move focus to next button by tabbing when textbox text is length 3
        private void txtEnterForBook2_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 3)
                SendKeys.Send("{Tab}");
        }
        
        // Method determining buttons and txtboxes that should be inaccessible upon load
        private void startingForm()
        {
            this.add = false;
            this.update = false;
            this.delete = false;
            this.AcceptButton = btnOK;
            lblISBN.Visible = false;
            txtISBN.Visible = false;
            lblTitle.Visible = false;
            txtTitle.Visible = false;
            lblAuthor.Visible = false;
            txtAuthor.Visible = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;
            lblOnHand.Visible = false;
            txtOnHand.Visible = false;
            lblTransactionDate.Visible = false;
            txtTransactionDate.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblEnterDataBelow.Visible = false;
            lblControls.Visible = false;
            btnDone.Visible = false;
        }

        // Make option buttons unclickable
        private void disableOptionButtons()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Enable option buttons
        private void showOptionButtons()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        
        // Reset form after completion of option choice
        private void resetForm()
        {
            this.add = false;
            this.update = false;
            this.delete = false;
            this.AcceptButton = btnOK;
            lblISBN.Visible = false;
            txtISBN.Visible = false;
            lblTitle.Visible = false;
            txtTitle.Visible = false;
            lblAuthor.Visible = false;
            txtAuthor.Visible = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;
            lblOnHand.Visible = false;
            txtOnHand.Visible = false;
            lblTransactionDate.Visible = false;
            txtTransactionDate.Visible = false;
            btnOK.Enabled = true;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblEnterDataBelow.Visible = false;
            lblControls.Visible = false;
            btnDone.Visible = false;
            txtEnterForBook1.Text = "";
            txtEnterForBook2.Text = "";
            txtEnterForBook1.Focus();
        }

        // Make Post-Option components visible (after clicking Add/Update/Delete button controls)
        private void visibleInfoComponents()
        {
            lblISBN.Visible = true;
            txtISBN.Visible = true;
            lblTitle.Visible = true;
            txtTitle.Visible = true;
            lblAuthor.Visible = true;
            txtAuthor.Visible = true;
            lblPrice.Visible = true;
            txtPrice.Visible = true;
            lblOnHand.Visible = true;
            txtOnHand.Visible = true;
            lblTransactionDate.Visible = true;
            txtTransactionDate.Visible = true;
            lblEnterDataBelow.Visible = true;
            lblControls.Visible = true;
            btnDone.Visible = true;
        }

        // Retreive data about object and display in the text boxes
        private void retreiveInformation()
        {
            txtISBN.Text = Globals.BookStore.Book.getISBN();
            txtTitle.Text = Globals.BookStore.Book.getTitle();
            txtAuthor.Text = Globals.BookStore.Book.getAuthor();
            txtPrice.Text = Globals.BookStore.Book.getPrice().ToString();
            txtOnHand.Text = Globals.BookStore.Book.getNumberOnHand().ToString();
            txtTransactionDate.Text = Globals.BookStore.Book.getLastTransactionDate();
        }

        // Disable components because they may be deleted
        private void disableInfoComponents()
        {
            lblISBN.Enabled = false;;
            txtISBN.Enabled = false;
            lblTitle.Enabled = false;
            txtTitle.Enabled = false;
            lblAuthor.Enabled = false;
            txtAuthor.Enabled = false;
            lblPrice.Enabled = false;
            txtPrice.Enabled = false;
            lblOnHand.Enabled = false;
            txtOnHand.Enabled = false;
            lblTransactionDate.Enabled = false;
            txtTransactionDate.Enabled = false;
            lblEnterDataBelow.Enabled = true;
            lblControls.Enabled = true;
            btnDone.Enabled = true;
        }

        // Check that ISBN is length 7
        private Boolean properISBN()
        {
            if (txtISBN.Text.Length == 7)
            {
                return true;
            }
            return false;
        }

        // Method used in safePinEntry() to Verify ISBN without a hyphen is a number and return boolean operators
        private Boolean isNumeric(string str)
        {
            string Str = str.Replace("-",""); // String value
            double Num; // declare double
            bool isNum = double.TryParse(Str, out Num); // Boolean TryParse of string
            if (isNum) // If string completely converts to number then return true or else
            {
                return true; // Fully converts
            }
            else
            {
                MessageBox.Show(str + " Should be numeric in value");
                return false; // Doesn't properly convert
            }
        }

        // Checks that:
        // ISBN is length 7 and that ISBN, Price and OnHand are convertible to numbers
        // Checks that no entry is blank
        private Boolean properInformation()
        {
            if (txtISBN.Text.Length == 7)
            {
                if (isNumeric(txtISBN.Text) && isNumeric(txtPrice.Text) && isNumeric(txtOnHand.Text))
                {
                    if (!String.IsNullOrEmpty(txtISBN.Text) && !String.IsNullOrEmpty(txtTitle.Text) && !String.IsNullOrEmpty(txtAuthor.Text) &&
                    !String.IsNullOrEmpty(txtPrice.Text) && !String.IsNullOrEmpty(txtOnHand.Text) && !String.IsNullOrEmpty(txtTransactionDate.Text))
                    {
                        return true;
                    }
                    else // Not all boxes are filled
                    {
                        MessageBox.Show("Make sure that all text boxes are filled with proper information");
                        return false;
                    }
                }
                else // Not all boxes that contain numbers convert properly
                {
                    return false;
                }
            }
            else // ISBN not length 7
            {
                MessageBox.Show("Please enter make sure that ISBN is in the form XXX-XXX");
                return false;
            }
        }
        

        // Application closes if form is closed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }
        
    }
}
