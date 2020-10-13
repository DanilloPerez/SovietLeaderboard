using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DataAccessLayer
{
    class LeaderboardDB
    {
        private SqlConnection sqlConnection = new SqlConnection();
        public bool AddLeaderBoard(LeaderboardModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@LeaderBoardID",model.LeaderBoardID },
                new string[] {"@UserID",model.UserID},
                new string[] {"@leaderboardType", model.leaderboardtype.ToString() }
            };
            sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO LeaderBoard ('LeaderBoardID','UserID','LeaderboardType') VALUES ( @LeaderboardID , @UserID , @LeaderboardType)", param);
            return true;
        }
    }
}

