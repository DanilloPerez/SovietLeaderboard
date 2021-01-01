using Models;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ITournamentDB
    {
        bool CreateTournaments(TournamentModel model);
        List<TournamentModel> GetTournaments();
        bool SubscribeTournament(TournamentModel model);
    }
}