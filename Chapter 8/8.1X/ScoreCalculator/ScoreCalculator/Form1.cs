using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        int average = 0;
        int scoreTotal = 0;
        public List<int> myData = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // Calculates and changes txtbox display
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtScore.Text != "")
            {
                int userScore = Convert.ToInt32(txtScore.Text);
                this.scoreTotal += userScore;
                this.myData.Add(userScore);
                this.average = this.scoreTotal / myData.Count;
                txtScoreTotal.Text = this.scoreTotal.ToString();
                txtScoreCount.Text = myData.Count.ToString();
                txtAverage.Text = this.average.ToString();
                txtScore.Text = "";
                
            }
        }

        // Clears variables and scores
        private void btnClearScores_Click(object sender, EventArgs e)
        {
            this.scoreTotal = 0;
            this.myData.Clear();
            txtScore.Text = "";
            txtAverage.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            txtScore.Focus();
        }

        // Exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Creates form object displaying SortedScores and count in list
        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            this.myData.Sort();
            Form sortedScores = new SortedScores(myData);
            sortedScores.ShowDialog();
        }
    }
}
