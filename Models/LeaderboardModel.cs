using System;
using System.Collections.Generic;
using System.Text;


namespace ModelsDTO
{
    public class LeaderboardModel

    {
        public enum LeaderboardType
        {
            Laptimes = 1,
            Ladder = 2
        }
        
        public string LeaderboardID { get; set; }
       
        public string LeaderBoardName { get; set; }
       
        public string LeaderBoardDescription { get; set; }
        
        public string UserID { get; set; }
        
        public LeaderboardType leaderboardType { get; set; }
    }
}






