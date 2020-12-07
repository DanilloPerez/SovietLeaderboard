using Interfaces;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Controllers
{
    public class LogicFactory
    {
        public IFriendsManager FriendsManager()
        {
            return new FriendsManager();
        }
        public ILeaderboardManager LeaderboardManager()
        {
            return new LeaderboardManager();
        }
        public ITeamManager TeamManager()
        {
            return new TeamManager();
        }
    }
}
