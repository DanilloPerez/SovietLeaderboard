using DataAccessLayer;
using Models;




namespace LogicLayer
{
    public class LeaderboardManager
    {
       public LeaderboardModel InsertLeaderBoard()
        {
            LeaderboardModel leaderboardModel = new LeaderboardModel();
            LeaderboardDB leaderBoardDB = new LeaderboardDB();
            return leaderboardModel;
        }
    }
}
