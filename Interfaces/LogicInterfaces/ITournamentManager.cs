using Models;
using System.Collections.Generic;

namespace LogicLayer
{
    public interface ITournamentManager
    {
        TournamentModel CreateTournament(TournamentModel createtournamentModel);
        List<TournamentModel> GetTournaments();
        bool SubscribeTournament();
    }
}