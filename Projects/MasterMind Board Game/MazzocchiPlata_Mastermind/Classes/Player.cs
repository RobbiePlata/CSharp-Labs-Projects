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
    /// Contains information on current player object
    /// Name, Difficulty, Attempts, Time are the main attributes defining a player
    /// String playerStr contains data that is written out to file when this player becomes a winner
    /// </summary>
    class Player
    {
        private string name = ""; // Name of user
        private string difficulty = ""; // Difficulty Easy, Medium, or Hard
        private int attempts = 0; // Attempts is the number of user attempts to win
        private string time = ""; // Time TimerObject.toString
        private string playerStr = ""; // Player string contains player data with asterisks for seperation (used for writing file out)

        /// <summary>
        /// This method is the constructor assigning values to current player object
        /// </summary>
        /// <param name="name">  Name of user</param>             
        /// <param name="difficulty"> Difficulty Easy, Medium, or Hard</param>             
        /// <param name="attempts"> Attempts is the number of user attempts to win</param> 
        /// <param name="time"> Time took to win </param>
        public Player(string name, string difficulty, int attempts, string time)
        {
            this.name = name;
            this.difficulty = difficulty;
            this.attempts = attempts;
            this.time = time;
            this.playerStr = name + " * " + difficulty + " * " + attempts + " * " + time;
        }

        /// <summary>
        /// Empty Player constructor for newly created player objects (used in LeaderboardClass class)
        /// Assigned information via createPlayerObject() method called in leaderboardclass method getExistingPlayers()
        /// </summary>
        public Player()
        {
            this.name = null;
            this.difficulty = null;
            this.attempts = 0;
            this.time = null;
            this.playerStr = null;
        }

        /// <summary>
        /// Assigns information to new player objects (returns boolean based on success)
        /// (true) if the object was created without error
        /// (false) false if the object contained wrongly formatted information
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Boolean createPlayerObject(string s)
        {
            Player thisPlayer = this;
            try
            {
                string[] playerString = s.Split('*'); // Split information around asterisks into array
                thisPlayer.name = playerString[0].Trim(); // Assign the name from array
                thisPlayer.difficulty = playerString[1].Trim(); // Assign the difficulty from array
                thisPlayer.attempts = Int32.Parse(playerString[2].Trim()); // Assign the attempts from array
                thisPlayer.time = playerString[3].Trim(); // Assign the time from array
                this.playerStr = name + " * " + difficulty + " * " + attempts + " * " + time; // Create the raw data information to be written out to file later
            } catch (Exception ex) // Player data not formatted properly
            {
                MessageBox.Show(ex.ToString()); // Exception message
                return false;
            }   
            return true; // Success
        }

        /// <summary>
        /// This method is the getter for "playerStr" 
        /// </summary>
        /// <returns> information about player using a big string </returns>
        public string getPlayerString()
        {
            return playerStr;
        }

        /// <summary>
        /// This method is the getter for "name" string
        /// </summary>
        /// <returns> name of player for use by the leaderboard </returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// This method is the getter for "difficulty" string
        /// </summary>
        /// <returns> difficulty player is on for use by the leaderboard </returns>
        public string getDifficulty()
        {
            return difficulty;
        }

        /// <summary>
        /// This method is the getter for attempts count
        /// </summary>
        /// <returns> number of attempts the user took to solve puzzle for use by the leaderboard </returns>
        public int getAttempts()
        {
            return attempts;
        }

        /// <summary>
        /// This method is the getter for "time" string
        /// </summary>
        /// <returns> time in seconds for use by the leaderboard </returns>
        public string getTime()
        {
            return time;
        }
    }
}
