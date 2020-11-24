using System;
using System.Collections.Generic;
using System.Text;
using Models;
using ModelsDTO;
using static ModelsDTO.LeaderboardModel;

namespace DataAccessLayer
{
    public class LeaderboardDB
    {
        private SqlConnection sqlConnection = new SqlConnection();
        /*public bool AddLeaderBoard(LeaderboardModel model)
        {

            List<string[]> param = new List<string[]>()
            {
                new string[] {"@LeaderBoardID",model.LeaderBoardID },
                new string[] {"@UserID",model.UserID},
                new string[] {"@leaderboardType", model.LeaderBoardScore }
            };
            sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO LeaderBoard (`LeaderBoardID`,`UserID`,`LeaderboardType`) VALUES ( @LeaderboardID , @UserID , @LeaderboardType )", param);
            return true;
        }*/

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
        public List<LeaderboardModel> GetLeaderBoards()
        {
            List<LeaderboardModel> Leaderboards = new List<LeaderboardModel>();
            List<string[]> result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM LeaderBoards", new List<string[]>());
            foreach (string[] row in result)
            {
                LeaderboardModel leaderboards = new LeaderboardModel();
                leaderboards.LeaderboardID = row[0].ToString();
                leaderboards.UserID = row[1].ToString();
                leaderboards.leaderboardType = (LeaderboardType)Int32.Parse(row[2]);
                leaderboards.LeaderBoardDescription = row[3].ToString();
                leaderboards.LeaderBoardName = row[4].ToString();

                Leaderboards.Add(leaderboards);
            }

            return Leaderboards;
        }

    }
}
