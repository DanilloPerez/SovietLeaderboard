using Interfaces.LogicInterfaces;
using Models;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class Tournament : ITournament
    {
        public string TournamentID { get; set; }
        public string TournamentName { get; set; }
        public int TournamentSize { get; set; }
        public List<TeamModel> TeamIDs { get; set; }
        public string TeamID { get; set; }

        public Tournament()
        {

        }
        public Tournament(TournamentModel tournamentModel)
        {
            TournamentID = tournamentModel.TournamentID;
            TournamentName = tournamentModel.TournamentName;
            TournamentSize = tournamentModel.TournamentSize;
            TeamIDs = tournamentModel.TeamIDs;
            TeamID = tournamentModel.TeamID;
        }
        public int CalculateRounds(int TeamCount)
        {
            
            if(TeamCount <= 0 ) {throw new ArgumentException("Teams have to be submitted");}
            if (TeamCount % 2 == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (TeamCount <= Math.Pow(2, i)) 
                    { 
                        return i + 1;
                    }
                }
                throw new Exception("Tournament already filled");
            }
            throw new Exception("Teamcount must be even");
        }
    }
    
}
