using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Interfaces.DALInterfaces;

namespace Factories

{
    public class DALFactory
    {
       
        public ILeaderboardManagerDB leaderboardDB()
        {
            return new LeaderboardDB();
        }
        public ITeamManagerDB teamDB()
        {
            return new TeamDB();
        }
        public IProfileManagerDB profileDB()
        {
            return new ProfileDB();
        }
        public ITournamentManagerDB tournamentDB()
        {
            return new TournamentDB();
        }
              
    }  
}
