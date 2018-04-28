using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {

        String firstName;
        String middleName;
        String lastName;
        String phoneNumber;

        public Form1()
        {
            InitializeComponent();
        }

        // Exit Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open new Form that displays parsed names
        private void displayParsedName()
        {
            Form parsedNames = new ParseName(firstName, middleName, lastName);
            parsedNames.ShowDialog();
        }
        
        // Executes splitName method
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            splitName();
        }

        // Submit names button splits words into array of words for display usage
        private void splitName()
        {
            String[] fullName = txtEnterName.Text.Split();
            // Number of words name = fullName.Count
            if (fullName.Count() == 1 && txtEnterName.Text != "")
            {
                this.firstName = fullName[0];
                displayParsedName();
            }
            if (fullName.Count() == 2 && txtEnterName.Text != "")
            {
                this.firstName = fullName[0];
                this.lastName = fullName[1];
                displayParsedName();
            }
            if (fullName.Count() == 3 && txtEnterName.Text != "")
            {
                this.firstName = fullName[0];
                this.middleName = fullName[1];
                this.lastName = fullName[2];
                displayParsedName();
            }
            if (fullName.Count() > 3 || txtEnterName.Text == "")
            {
                MessageBox.Show("Re-enter your name");
            }
            txtEnterName.Text = "";
        }

        // Phone number form displayed
        private void btnEditPhoneNumber_Click(object sender, EventArgs e)
        {
            this.phoneNumber = txtPhoneNumber.Text;
            Form parsedPhone = new ParsePhone(phoneNumber);
            parsedPhone.ShowDialog();
        }
    }
}
