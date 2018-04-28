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
    /// This class is simple a place holder for the mastermind form, this is done by opening this form but not showing it and
    /// closing and reseting the mastermind form so that the whole program isnt disturbed
    /// </summary>
    public partial class frm_NewGame : Form
    {   
        /// <summary>
        /// This method is called to intialize and start a new instance of our game
        /// </summary>
        public frm_NewGame()
        {
            InitializeComponent();
            this.Hide();
            frm_Mastermind newGame = new frm_Mastermind();
            newGame.Show();
        }

        /// <summary>
        /// This is a override for the "X" buttton on the form so when it clicked it closes all forms and stops the program
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }
    }
}
