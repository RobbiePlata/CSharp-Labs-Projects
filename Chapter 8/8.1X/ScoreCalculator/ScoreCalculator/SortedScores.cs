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
    public partial class SortedScores : Form
    {
        List<int> myData;

        // Sorted List constructor for Form
        public SortedScores(List<int> obj)
        {
            InitializeComponent();
            this.myData = obj;
            // Add elements to list object through iteration
            foreach (int element in myData)
            {
                if (element != 0)
                {
                    listSortedScores.Items.Add(element.ToString());
                }
            }
            // Set count in txtCount
            txtCount.Text = obj.Count.ToString();
            
        }
    }
}
