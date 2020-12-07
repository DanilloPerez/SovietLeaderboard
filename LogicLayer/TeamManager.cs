using DataAccessLayer;
using Models;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class TeamManager : ITeamManager
    {
        private readonly ITeamDB teamDB = new DALFactory().teamDB();

        public TeamModel CreateTeam(TeamModel createteamModel)
        {
            teamDB.CreateTeam(createteamModel);
            return createteamModel;
        }
        public TeamModel EditTeam(TeamModel teamModel)
        {
            teamDB.EditTeam(teamModel);
            return teamModel;
        }
        public List<TeamModel> GetTeams()
        {
            return teamDB.GetTeams();
        }
        public void DeleteTeams(string teamID)
        {
            teamDB.DeleteTeams(teamID);
        }
    }
}
