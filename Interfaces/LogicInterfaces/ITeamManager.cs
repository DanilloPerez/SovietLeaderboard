using ModelsDTO;
using System.Collections.Generic;


namespace Interfaces
{
    public interface ITeamManager
    {
        TeamModel CreateTeam(TeamModel createteamModel);
        void DeleteTeams(string teamID);
        List<TeamModel> GetTeams();

        ITeam GetTeamByID(string TeamID);
       
    }
}