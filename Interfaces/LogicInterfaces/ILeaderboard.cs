namespace LogicLayer.LeaderBoard
{
    public interface ILeaderboard
    {
        string LeaderBoardDescription { get; set; }
        string LeaderboardID { get; set; }
        string LeaderBoardName { get; set; }
        string UserID { get; set; }
    }
}