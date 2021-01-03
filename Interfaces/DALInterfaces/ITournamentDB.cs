using Models;
using ModelsDTO;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ITournamentDB
    {
        bool CreateTournaments(TournamentModel model);
        List<TournamentModel> GetTournaments();
        bool SubscribeTournament(TournamentModel model);
        List<PositionModel> GetTeamPosition(string TournamentID);
    }
}