using DataAccessLayer;
using ModelsDTO;
using System.Collections.Generic;

namespace LogicLayer
{
    public class LeaderboardManager : ILeaderboardManager
    {
        private readonly ILeaderboardDB leaderBoardDB = new LeaderboardDB();


        public LeaderboardModel AddLeaderBoard(LeaderboardModel leaderboardModel)
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

        public List<LeaderboardModel> GetLeaderBoards()
        {
            return leaderBoardDB.GetLeaderBoards();
        }
        public void DeleteLeaderBoard(string leaderboardID)
        {
            leaderBoardDB.DeleteLeaderBoard(leaderboardID);
        }

    }
}
