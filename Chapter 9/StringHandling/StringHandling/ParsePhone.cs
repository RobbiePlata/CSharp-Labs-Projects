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
    public partial class ParsePhone : Form
    {
        String enteredNumber;
        String digitsOnly;

        // Parse number, split, replace, and properly display via form
        public ParsePhone(String phoneNumber)
        {
            this.enteredNumber = phoneNumber;
            this.digitsOnly = phoneNumber.Replace("-", " ");
            this.digitsOnly = digitsOnly.Replace(")", String.Empty);
            this.digitsOnly = digitsOnly.Replace("(", String.Empty);
            String[] digitArray = digitsOnly.Split();
            String standardFormat = "";
            for (int i = 0; i < digitArray.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    standardFormat += digitArray[i] + '-';
                }
                else if (i == 2)
                {
                    standardFormat += digitArray[i];
                }
            }
            InitializeComponent();
            this.digitsOnly = digitsOnly.Replace(" ", String.Empty);
            if (digitsOnly.Length != 10)
            {
                MessageBox.Show("Please enter a proper 10 digit number with format (XXX) XXX-XXXX");

                return;
            }
            lblDigitsOnlyNumber.Text = digitsOnly;
            lblEnteredNumber.Text = enteredNumber;
            lblStandardFormatNumber.Text = standardFormat;
            
        }

        // Exit form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
