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
    public partial class ParseName : Form
    {

        // Constructor initializes labels
        public ParseName(String firstName, String middleName, String lastName)
        {
            InitializeComponent();
            lblDisplayedFirstName.Text = firstName;
            lblDisplayedMiddleName.Text = middleName;
            lblDisplayedLastName.Text = lastName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
