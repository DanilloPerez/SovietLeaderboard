using ModelsDTO;
using System.Collections.Generic;

namespace LogicLayer
{
    public interface ITeamManager
    {
        TeamModel CreateTeam(TeamModel createteamModel);
        void DeleteTeams(string teamID);
        TeamModel EditTeam(TeamModel teamModel);
        List<TeamModel> GetTeams();
    }
}