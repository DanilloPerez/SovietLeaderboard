using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class LeaderboardModel
    {
        public string LeaderBoardID { get; set; }
        public string UserID { get; set; }
        public LeaderboardType leaderboardtype { get; set; }
    }
    public enum LeaderboardType
    {
        Laptimes = 1,
        TallyList = 2,
        Ladder = 3
    }
}






