using DataAccessLayer;
using Models;
using ModelsDTO;
using System.Collections.Generic;

namespace LogicLayer
{
    public class LeaderboardManager
    {
        private readonly LeaderboardDB leaderBoardDB = new LeaderboardDB();
        public LeaderboardModel InsertLeaderBoard(LeaderboardModel leaderboardModel)
        {
            
            leaderBoardDB.AddLeaderBoard(leaderboardModel);
            return leaderboardModel;
        }
        public LeaderboardModel EditLeaderBoard(LeaderboardModel leaderboardModel)
        {
           
            leaderBoardDB.EditLeaderBoard(leaderboardModel);
            return leaderboardModel;
        }
        public List<LeaderBoardEntryModel> GetLeaderBoardEntries(string LeaderBoardID)
        {
           return leaderBoardDB.GetLeaderBoardEntries(LeaderBoardID);          
        }
        
    }
}
