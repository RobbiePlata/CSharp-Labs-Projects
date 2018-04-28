using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazzocchiPlata_Mastermind
{
    /// Robert Plata & Brett Mazzocchi
    /// Date Created: 04/11/2018
    /// <summary>
    /// Contains leaderboard list in which new and existing player objects are stored
    /// Existing players are obtained by getExistingPlayers() method
    /// New winning players are added to the list from the form class using addPlayer() method from this class
    /// Contains method to display leaderboardform with current information. 
    /// New information on players will be saved as well.
    /// </summary>
    class LeaderboardClass
    {

        List<Player> leaderboard = new List<Player>(); // Leaderboard list of player objects obtained by reading from file, creating objects, then storing here
        string leaderboardStr = ""; // Leaderboard string containing the properly formatted leaderboard 

        /// <summary>
        /// This method is the constructor of this class and it is used to create leaderboard
        /// </summary>
        public LeaderboardClass()
        {
            getExistingPlayers();
        }

        /// <summary>
        /// This method is used to Add players that currently exist in currentFileClass object
        /// </summary>
        public void getExistingPlayers()
        {
            var file = new System.IO.StreamReader("leaderboard.txt"); // Read leaderboard using StreamReader
            string line = "";
            while ((line = file.ReadLine()) != null) // While still lines in file
            {
                Player player = new Player();
                if (player.createPlayerObject(line)) // Player object successfully created
                {   
                    //MessageBox.Show(leaderboard.Count().ToString());
                    addPlayer(player);
                }
                else // Player object not formatted correctly in text file due to score tampering
                {
                    MessageBox.Show("Player object failed to be created");
                }
            }
            file.Close(); // Close file (saves)
        }

        /// <summary>
        /// This method is used to add new players to leaderboard
        /// </summary>
        /// <param name="player"></param>
        public void addPlayer(Player player)
        {
            leaderboard.Add(player);
        }

        /// <summary>
        /// This method is used to writes out the player list (leaderboard)
        /// </summary>
        public void writeLeaderboard()
        {
            var file = new System.IO.StreamWriter("Leaderboard.txt"); // Overwrite existing leaderboard text file using StreamWriter
            foreach (Player player in leaderboard) // Write out all of the player objects
            {
                file.WriteLine(player.getPlayerString()); // Write line out to file
            }
            file.Close(); // Close the file
        }

        /// <summary>
        /// This method is called when the user presses the button in form and it prints out the current leaderboard to the leaderboard form
        /// </summary>
        public void displayLeaderboard()
        {
            this.leaderboardStr = ""; // Leaderboard string for current object
            StringBuilder sb = new StringBuilder(); // String builder for string alignment
            foreach(Player player in leaderboard)
            {
                // Append formatted string with spacing values to string builder
                sb.Append(string.Format("{0, -13}{1, -16}{2, -15}{3, 0}", player.getName(), player.getDifficulty(), player.getAttempts(), player.getTime())+"\r\n");
                this.leaderboardStr = sb.ToString(); // Append stringbuilder to string
            }
            LeaderboardForm leaderboardForm = new LeaderboardForm(leaderboardStr); // Pass leaderboardstr to create new leaderboard form
            leaderboardForm.Show(); // Show new leaderboard
        }
    }
}
