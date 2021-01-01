using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class TournamentDB : ITournamentDB
    {
        private ISqlConnection sqlConnection = new ConnectionFactory().SqlConnection();
        public bool CreateTournament(TournamentModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@TournamentID",model.TournamentID },
                new string[] {"@TeamID",model.TeamID },
                new string[] {"@TournamentName",model.TournamentName},
                new string[] {"@TournamentSize",model.TournamentSize.ToString()},

            };
            sqlConnection.ExecuteNonSearchQueryParameters("INSERT INTO Tournaments(`TournamentID`,`TeamID`,`TournamentName`,`TournamentSize`) VALUES( @TournamentID , @TeamID , @TournamentName , @TournamentSize)", param);
            return true;
        }

        public bool CreateTournaments(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<TournamentModel> GetTournaments()
        {
            List<TournamentModel> Tournaments = new List<TournamentModel>();
            List<string[]> result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM Tournaments", new List<string[]>());
            foreach (string[] row in result)
            {
                TournamentModel tournaments = new TournamentModel();
                tournaments.TournamentID = row[0].ToString();
                tournaments.TeamID = row[1].ToString();
                tournaments.TournamentName = row[2].ToString();
                tournaments.TournamentSize = (Convert.ToInt32(row[3]));

                Tournaments.Add(tournaments);
            }

            return Tournaments;
        }
        public bool SubscribeTournament(TournamentModel model)
        {
            List<string[]> param = new List<string[]>()
            {

                new string[] {"@TeamID",model.TeamID },


            };
            sqlConnection.ExecuteNonSearchQueryParameters("INSERT INTO Tournament(`TeamID`,) VALUES( @TeamID )", param);
            return true;
        }
    }


}
