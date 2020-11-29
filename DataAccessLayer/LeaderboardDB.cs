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
        public bool AddLeaderBoard(LeaderboardModel model)
        {

            List<string[]> param = new List<string[]>()
            {
                new string[] {"@LeaderBoardID",model.LeaderboardID },
                new string[] {"@OwnerID",model.UserID},
                new string[] {"@leaderboardType", ((int)model.leaderboardType).ToString() },
                new string[] {"@LeaderBoardName",model.LeaderBoardName},
                new string[] {"@LeaderBoardDescription",model.LeaderBoardDescription }
            };
            sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO LeaderBoards (`LeaderBoardID`,`OwnerID`,`LeaderBoardType`,`LeaderBoardName`,`LeaderBoardDescription`) VALUES ( @LeaderboardID , @OwnerID , @LeaderboardType, @LeaderBoardName, @LeaderBoardDescription )", param);
            return true;
        }

        public bool EditLeaderBoard(LeaderboardModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] { "@LeaderBoardID", model.LeaderboardID },
                new string[] { "@OwnerID", model.UserID },
                new string[] { "@leaderboardType", ((int)model.leaderboardType).ToString() },
                new string[] { "@LeaderBoardName", model.LeaderBoardName },
                new string[] { "@LeaderBoardDescription", model.LeaderBoardDescription }
             };
            sqlConnection.ExecuteNonSearchQueryParameters(" UPDATE LeaderBoards SET `LeaderBoardID` = @LeaderboardID,`OwnerID`= @OwnerID ,`LeaderBoardType` = @LeaderboardType ,`LeaderBoardName` =  @LeaderBoardName ,`LeaderBoardDescription` = @LeaderBoardDescription WHERE `LeaderBoardID` = @LeaderBoardID", param);
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
        public void DeleteLeaderBoard(string leaderboardID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] { "@LeaderBoardID", leaderboardID },
             };
            sqlConnection.ExecuteNonSearchQueryParameters("DELETE FROM LeaderBoards WHERE `LeaderBoardID` = @LeaderBoardID", param);       
        }
    }

}

