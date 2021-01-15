using DataAccessLayer;
using Interfaces;
using Interfaces.DALInterfaces;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Team
{
    public class Team : ITeam
    {
        ITeamDB teamDB = new TeamDB();

        public string TeamID { get; set; }
        public string TeamDescription { get; set; }
        public string TeamName { get; set; }
        public string OwnerID { get; set; }

        public Team(TeamModel teamModel)
        {
            TeamID = teamModel.TeamID;
            TeamDescription = teamModel.TeamDescription;
            TeamName = teamModel.TeamName;
            OwnerID = teamModel.OwnerID;
        }
        public Team()
        {

        }
        public bool AddPlayers(string UserID)
        {
            return teamDB.AddPlayerToTeam(UserID, this.TeamID);
        }
        public bool Update()
        {
            return teamDB.EditTeam(CreateModel());
        }
        private TeamModel CreateModel()
        {
            TeamModel model = new TeamModel()
            {
                TeamID = this.TeamID,
                TeamDescription = this.TeamDescription,
                TeamName = this.TeamName,
                OwnerID = this.OwnerID,
            };
            return model;
        }
    }
}
