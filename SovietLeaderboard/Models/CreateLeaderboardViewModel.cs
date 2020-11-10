using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Models.LeaderboardModel;

namespace SovietLeaderboard.Models
{
    public class CreateLeaderboardViewModel
    {
        [Required]
        public string LeaderboardID { get; set; }
        [Required]
        public string LeaderBoardName { get; set; }
        [Required]
        public string LeaderBoardDescription { get; set; } 
        [Required]
        public string UserID { get; set; }
        [Required]
        public LeaderboardType leaderboardType{ get; set; }
    }
    
}
