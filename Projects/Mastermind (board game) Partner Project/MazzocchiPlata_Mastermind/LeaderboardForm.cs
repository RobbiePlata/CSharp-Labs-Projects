using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazzocchiPlata_Mastermind
{
    /// Robert Plata & Brett Mazzocchi
    /// Date Created: 04/11/2018
    /// <summary>
    /// This form displays the leaderboard difficulties, scores, and time for those who won their games.
    /// </summary>
    public partial class LeaderboardForm : Form
    {
        /// <summary>
        /// Constructor that takes in a string which is then displayed in the txtList component.
        /// The string is aligned properly before it is parsed to this form
        /// </summary>
        /// <param name="s"></param>
        public LeaderboardForm(string s)
        {
            InitializeComponent(); // Required method for designer
            txtList.Text = s; // Assign textbox the formatted text parsed to this form
            txtList.Enabled = false; // Disable leaderboard for text input
        }
        
    }
}
