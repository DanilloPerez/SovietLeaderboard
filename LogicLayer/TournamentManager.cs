using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class TournamentManager : ITournamentManager
    {
        private readonly ITournamentDB tournamentDB = new DALFactory().tournamentDB();

        public TournamentModel CreateTournament(TournamentModel createtournamentModel)
        {
            tournamentDB.CreateTournaments(createtournamentModel);
            return createtournamentModel;
        }
        public List<TournamentModel> GetTournaments()
        {
            return tournamentDB.GetTournaments();
        }
        public bool SubscribeTournament(TournamentModel model)
        {
            tournamentDB.SubscribeTournament(model);
            return (true);
        }

        public bool SubscribeTournament()
        {
            throw new NotImplementedException();
        }
        public int CalculateRounds(int TeamCount)
        {
            if (TeamCount %2 == 0)
            {
                for (int i = 1; i<=5; i++)
                {
                    if(TeamCount <= Math.Pow(2, i)) { return  i+1; }
                }
                throw new Exception("Tournament already filled");
            }          
                throw new Exception("Teamcount must be even");
            
        }       
    }
}
