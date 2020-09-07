using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TournamentModel
    {
        public string TournamentID { get; set; }
        public string TournamentName { get; set; }
        public string Users { get; set; }
        public string Teams { get; set; }
        public TableformTeams tableformteams { get; set; }
        public TableformPlayers tableformplayers { get; set; }
        public enum TableformTeams // tournament tree
        {
            EightTeams = 1,
            SixteenTeams = 2,
            ThirtytwoTeams = 3,
        }
        public enum TableformPlayers // tournament tree
        {
            FourPlayers = 1,
            EightPlayers = 2,
            SixteenPlayers = 3,
            ThirtytwoPlayers = 4,
        }
        public TournamentModel(string TournamentID, string TournamentName, string Users, string Teams, TableformPlayers tableformplayers, TableformTeams tableformteams)
        {
            this.TournamentID = TournamentID;
            this.TournamentName = TournamentName;
            this.Users = Users;
            this.Teams = Teams;
            this.tableformplayers = tableformplayers;
            this.tableformteams = tableformteams;
        }
    }
}

