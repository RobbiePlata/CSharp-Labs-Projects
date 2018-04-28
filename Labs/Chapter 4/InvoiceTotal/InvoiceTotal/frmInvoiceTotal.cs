using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class InvoiceTotalForm : Form
    {
        public InvoiceTotalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int numberOfInvoices = 0;
        decimal smallestInvoice = 0;
        decimal largestInvoice = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
                if (subtotal > 0)
                {
                    decimal discountPercent = .25m;
                    decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
                    decimal invoiceTotal = subtotal - discountAmount;


                    txtSubtotal.Text = subtotal.ToString("c");
                    txtDiscountPercent.Text = discountPercent.ToString("p1");
                    txtDiscountAmount.Text = discountAmount.ToString("c");
                    txtTotal.Text = invoiceTotal.ToString("c");

                    numberOfInvoices++;
                    totalOfInvoices += invoiceTotal;
                    invoiceAverage = totalOfInvoices / numberOfInvoices;
                    if (invoiceTotal > largestInvoice)
                    {
                        largestInvoice = invoiceTotal;
                    }
                    if (invoiceTotal < smallestInvoice || smallestInvoice == 0)
                    {
                        smallestInvoice = invoiceTotal;
                    }

                    txtNumberOfInvoices.Text = numberOfInvoices.ToString();
                    txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
                    txtInvoiceAverage.Text = invoiceAverage.ToString("c");
                    txtLargestInvoice.Text = largestInvoice.ToString("c");
                    txtSmallestInvoice.Text = smallestInvoice.ToString("c");

                    txtEnterSubtotal.Text = "";
                    txtEnterSubtotal.Focus();
                }
                else
                {
                   DialogResult dialogresult = MessageBox.Show(userName + ", Please enter a positive value");
                }
            }catch
            {
                DialogResult dialogresult = MessageBox.Show(userName+", Please re-enter your data");
                txtEnterSubtotal.Focus();
            }

        

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubtotal.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        string userName = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnterName.Text))
            {
                DialogResult dialogresult = MessageBox.Show("Cannot have a blank name");
                txtEnterName.Focus();
            }
            else
            {
                userName = txtEnterName.Text;
                txtEnterSubtotal.Enabled = true;
                lblEnterSubtotal.Enabled = true;
            }

        }

        private void txtEnterSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalOfInvoices_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInvoiceAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSmallestInvoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSmallestInvoice_Click(object sender, EventArgs e)
        {

        }

        private void lblLargestInvoice_Click(object sender, EventArgs e)
        {

        }

        private void lblInvoiceAverage_Click(object sender, EventArgs e)
        {

        }

        private void lblNumberOfInvoices_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
