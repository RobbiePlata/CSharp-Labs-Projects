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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
            MessageBox.Show("If you want another calculation press Enter Data button.", "Re-run!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearForm();
        }

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


            btnCalculate.Enabled = false;
            txtMonthlyInvestment.Focus();

        }

        private void txtYears_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
        }
    }
}
