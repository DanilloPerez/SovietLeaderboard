using DataAccessLayer;
using Models;




namespace LogicLayer
{
    public class LeaderboardManager
    {
       public LeaderboardModel InsertLeaderBoard(LeaderboardModel leaderboardModel)
        {         
            LeaderboardDB leaderBoardDB = new LeaderboardDB();
            leaderBoardDB.AddLeaderBoard(leaderboardModel);
            return leaderboardModel;
        }
    }
}
