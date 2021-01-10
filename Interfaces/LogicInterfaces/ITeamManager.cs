using ModelsDTO;
using System.Collections.Generic;


namespace Interfaces
{
    public interface ITeamManager
    {
        TeamModel CreateTeam(TeamModel createteamModel);
        void DeleteTeams(string teamID);
        TeamModel EditTeam(TeamModel teamModel);
        List<TeamModel> GetTeams();

        ITeam GetTeamByID(string TeamID);
       
    }
}