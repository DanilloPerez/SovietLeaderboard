using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SovietLeaderboard.Models
{

    public class LeaderboardViewModel
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
        public string LeaderBoardScore { get; set; }

    }

}
