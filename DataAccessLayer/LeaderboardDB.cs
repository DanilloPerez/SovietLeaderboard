using System;
using System.Collections.Generic;
using System.Text;
using Models;
using ModelsDTO;

namespace DataAccessLayer
{
    public class LeaderboardDB
    {
        private SqlConnection sqlConnection = new SqlConnection();
        public bool AddLeaderBoard(LeaderboardModel model)
        {

            List<string[]> param = new List<string[]>()
            {
                new string[] {"@LeaderBoardID",model.LeaderboardID },
                new string[] {"@UserID",model.UserID},
                new string[] {"@leaderboardType", model.leaderboardType.ToString() }
            };
            sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO LeaderBoard (`LeaderBoardID`,`UserID`,`LeaderboardType`) VALUES ( @LeaderboardID , @UserID , @LeaderboardType )", param);
            return true;
        }

        public bool EditLeaderBoard(LeaderboardModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@LeaderBoardID",model.LeaderboardID },
                new string[] {"@UserID",model.UserID},
                new string[] {"@leaderboardType", model.leaderboardType.ToString() }
            };
            sqlConnection.ExecuteNonSearchQueryParameters(" UPDATE LeaderBoard (`LeaderBoardID`,`UserID`,`LeaderboardType`) VALUES ( @LeaderboardID , @UserID , @LeaderboardType )", param);
            return true;
        }
        public List<LeaderBoardEntryModel> GetLeaderBoardEntries(string LeaderboardID)
        {
            List<LeaderBoardEntryModel> leaderBoardEntries = new List<LeaderBoardEntryModel>();


            List<string[]> param = new List<string[]>()
                {
                    new string[] {"@LeaderBoardID", LeaderboardID },
                };

            List<string[]> result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM LeaderBoard WHERE LeaderBoardID = @LeaderBoardID", param);
            foreach (string[] row in result)
            {
                LeaderBoardEntryModel leaderboardentry = new LeaderBoardEntryModel();
                leaderboardentry.LeaderBoardID = row[0].ToString();
                leaderboardentry.LeaderBoardScore = row[4].ToString();
                leaderboardentry.UserID = row[1].ToString();

                leaderBoardEntries.Add(leaderboardentry);
            }

            return leaderBoardEntries;
        }


    }
}

