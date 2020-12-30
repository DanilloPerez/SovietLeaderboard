using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Interfaces.DALInterfaces;

namespace LogicLayer
{
    public class DALFactory
    {
        public IFriendsDB FriendsDB()
        {
            return new FriendsDB();
        }
        public ILeaderboardDB leaderboardDB()
        {
            return new LeaderboardDB();
        }
        public ITeamDB teamDB()
        {
            return new TeamDB();
        }
        public IProfileDB profileDB()
        {
            return new ProfileDB();
        }
              
    }  
}
