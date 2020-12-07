using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class TournamentDB
    {
        private ISqlConnection sqlConnection = new SqlConnection();
        //public bool AddTournament(TournamentModel model)
        //{

        //    List<string[]> param = new List<string[]>()
        //    {
        //        new string[] {"@TournamentID",model.TournamentID },
        //        new string[] {"@UserID",model.UserID},
        //        new string[] {"@TournamentType", model.TournamentType.ToString() }
        //    };
        //    sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO Tournament (`TournamentID`,`UserID`,`TournamentType`) VALUES ( @TournamentID , @UserID , @TournamentType )", param);
        //    return true;
        //}
    }
}
