using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        // futureValue treated as a reference argument in order to update futureValue variable in reference method
        private void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        // Calculate button initializes variables used for calculation of future value
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);
            int months = years * 12;
            decimal futureValue = 0m;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            this.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        // Button closes program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clears form at loading of form
        private void Form1_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        // Sets future value txt box to blank
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        // Clears all data and sets btnCalculate button to false
        private void clearForm()
        {
            btnCalculate.Enabled = false;
            txtFutureValue.Text = "";
            txtMonthlyInvestment.Text = "";
            txtYearlyInterestRate.Text = "";
            txtYears.Text = "";
            txtFutureValue.Enabled = false;
            txtMonthlyInvestment.Enabled = false;
            txtYearlyInterestRate.Enabled = false;
            txtYears.Enabled = false;
            lblFutureValue.Enabled = false;
            lblMonthlyInvestment.Enabled = false;
            lblNumberOfYears.Enabled = false;
            lblYearlyInterestRate.Enabled = false;
        }

        // Enter Data button enables buttons, labels, and sets focus
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            btnEnterData.Enabled = true;

            lblFutureValue.Enabled = true;
            lblMonthlyInvestment.Enabled = true;
            lblNumberOfYears.Enabled = true;
            lblYearlyInterestRate.Enabled = true;

            txtFutureValue.Enabled = true;
            txtFutureValue.Text = "";

            txtMonthlyInvestment.Enabled = true;
            txtMonthlyInvestment.Text = "";

            txtYearlyInterestRate.Enabled = true;
            txtYearlyInterestRate.Text = "";

            txtYears.Enabled = true;
            txtYears.Text = "";


            btnCalculate.Enabled = true;
            txtMonthlyInvestment.Focus();

        }

        // Text changed enables btnCalculate button
        private void txtYears_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
        }
    }
}
