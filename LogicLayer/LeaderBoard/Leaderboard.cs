using DataAccessLayer;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.LeaderBoard
{
    public class Leaderboard : ILeaderboard
    {
        ILeaderboardManagerDB leaderboardDB = new LeaderboardDB();

        public string LeaderboardID { get; set; }

        public string LeaderBoardName { get; set; }

        public string LeaderBoardDescription { get; set; }

        public string UserID { get; set; }


        public Leaderboard(LeaderboardModel leaderboardModel)
        {
            LeaderboardID = leaderboardModel.LeaderboardID;
            LeaderBoardName = leaderboardModel.LeaderBoardName;
            LeaderBoardDescription = leaderboardModel.LeaderBoardDescription;
            UserID = leaderboardModel.UserID;

        }

        public Leaderboard()
        {

        }
    }
    


   

}
