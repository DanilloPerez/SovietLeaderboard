using ModelsDTO;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ITeamDB
    {
        bool CreateTeam(TeamModel model);
        void DeleteTeams(string teamID);
        bool EditTeam(TeamModel model);
        List<TeamModel> GetTeams();
    }
}