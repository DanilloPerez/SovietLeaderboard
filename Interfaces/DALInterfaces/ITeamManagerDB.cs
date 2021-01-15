using ModelsDTO;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ITeamManagerDB
    {
        bool CreateTeam(TeamModel model);
        void DeleteTeams(string teamID);
        List<TeamModel> GetTeams();
        TeamModel FindTeamByID(string teamID);
    }
}