using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class IncomeTaxCalculator : Form
    {
        // IncomeTaxCalculator Constructor Initialization
        public IncomeTaxCalculator()
        {
            InitializeComponent();
        }

        // Exit button closes program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tax table decided, taxOwed calculated based on where taxableIncome falls
        private decimal taxTableLookup(decimal taxableIncome)
        {
            decimal taxOwed = 0;

            if (taxableIncome > 0 && taxableIncome <= 9225)
            {
                taxOwed = 0 + (taxableIncome * .10m);
            }
            else if (taxableIncome > 9225 && taxableIncome <= 37450)
            {
                taxOwed = 922.50m + (taxableIncome * .15m);
            }
            else if (taxableIncome > 37450 && taxableIncome <= 90750)
            {
                taxOwed = 5156.25m + (taxableIncome * .25m);
            }
            else if (taxableIncome > 90750 && taxableIncome <= 189300)
            {
                taxOwed = 18481.25m + (taxableIncome * .28m);
            }
            else if (taxableIncome > 189300 && taxableIncome <= 411500)
            {
                taxOwed = 46075.25m + (taxableIncome * .33m);
            }
            else if (taxableIncome > 411500 && taxableIncome <= 413200)
            {
                taxOwed = 119401.25m + (taxableIncome * .35m);
            }
            else if (taxableIncome > 413200)
            {
                taxOwed = 119996.25m + (taxableIncome * .396m);
            }
            return taxOwed;

        }

        // Validates Taxable Income decimal object greater than zero
        private bool validateTaxableIncome(decimal taxableIncome)
        {
            bool valid = false;
            if (taxableIncome > 0)
            {
                valid = true;
            }
            else
            {
                valid = false; ;
            }    
            return valid;
        }

        // Calculate button uses validates taxable income which is then passed through the tax table method
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal taxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);
            if(validateTaxableIncome(taxableIncome) == true)
            {
                decimal taxOwed = taxTableLookup(taxableIncome);
                txtIncomeTaxOwed.Text = Decimal.Round(taxOwed, 2).ToString();  // Rounded to two decimals
            }
            else
            {
                MessageBox.Show("Please enter a value greater than 0");
            }
        }
    }
}
