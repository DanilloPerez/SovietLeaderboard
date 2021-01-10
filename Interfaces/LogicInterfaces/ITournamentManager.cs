using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ITournamentManager
    {
        TournamentModel CreateTournament(TournamentModel createtournamentModel);
        List<TournamentModel> GetTournaments();
    }
}