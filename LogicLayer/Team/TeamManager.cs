using DataAccessLayer;
using Interfaces;
using Models;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;


namespace LogicLayer.Team
{
    public class TeamManager : ITeamManager
    {
        private readonly ITeamManagerDB teamManagerDB = new DALFactory().teamDB();

        public TeamModel CreateTeam(TeamModel createteamModel)
        {
            
            teamManagerDB.CreateTeam(createteamModel);
            Team team = new Team(createteamModel);           
            return createteamModel;
        }
        public TeamModel EditTeam(TeamModel teamModel)
        {
            teamManagerDB.EditTeam(teamModel);
            return teamModel;
        }
        public List<TeamModel> GetTeams()
        {
            return teamManagerDB.GetTeams();
        }
        public void DeleteTeams(string teamID)
        {
            teamManagerDB.DeleteTeams(teamID);
        }
        public ITeam GetTeamByID(string TeamID)
        {
            TeamModel teamModel = teamManagerDB.FindTeamByID(TeamID);
            if(teamModel == null)
            {
                return null;
            }
            Team team = new Team(teamModel);
            return team;
        }
        

        
    }
}
