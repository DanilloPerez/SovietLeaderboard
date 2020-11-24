using DataAccessLayer;
using ModelsDTO;
using System.Collections.Generic;

namespace LogicLayer
{
    public class LeaderboardManager
    {
        private readonly LeaderboardDB leaderBoardDB = new LeaderboardDB();
        public LeaderBoardEntryModel InsertLeaderBoard(LeaderBoardEntryModel LeaderboardModel)
        {
            //TODO FIX
            //leaderBoardDB.AddLeaderBoard(LeaderboardModel);
            //return LeaderboardModel;
            return null;
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

        public List<LeaderboardModel> GetLeaderBoards()
        {
            return leaderBoardDB.GetLeaderBoards();
        }

    }
}
