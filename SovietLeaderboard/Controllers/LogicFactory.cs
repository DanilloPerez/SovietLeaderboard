using Interfaces;
using Interfaces.LogicInterfaces;
using LogicLayer;
using LogicLayer.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Controllers
{
    public class LogicFactory
    {
        
        public ILeaderboardManager LeaderboardManager()
        {
            return new LeaderboardManager();
        }
        public ITeamManager TeamManager()
        {
            return new TeamManager();
        }
        public IProfileManager ProfileManager()
        {
            return new ProfileManager();
        }
    }
}
