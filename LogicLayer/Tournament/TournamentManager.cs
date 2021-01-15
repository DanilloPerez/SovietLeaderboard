using DataAccessLayer;
using Factories;
using Interfaces;
using Models;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;



namespace LogicLayer
{
    public class TournamentManager : ITournamentManager
    {
        private readonly ITournamentManagerDB tournamentDB = new DALFactory().tournamentDB();

        public TournamentModel CreateTournament(TournamentModel createtournamentModel)
        {
            tournamentDB.CreateTournaments(createtournamentModel);
            return createtournamentModel;
        }
        public List<TournamentModel> GetTournaments()
        {
            return tournamentDB.GetTournaments();
        }

        public Tournament GetTournamentByID(string ID)
        {
            TournamentModel model = tournamentDB.GetTournamentByID(ID);
            return new Tournament(model);
        }
      
       
        public List<PositionModel> GetTeamPosition(string TournamentID)
        {
            return tournamentDB.GetTeamPosition(TournamentID);
        }

        public int CalculateRounds(int TeamCount)
        {
            Tournament tournament = new Tournament();          
            return tournament.CalculateRounds(TeamCount);
        }
    }
}
