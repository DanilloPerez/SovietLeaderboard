using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Models
{
    public class TournamentViewModel
    {
        
            [Required]
            public string TournamentID { get; set; }
            [Required]
            public string TournamentName { get; set; }
            [Required]
            public string TournamentDescription { get; set; }
            [Required]
            public string UserID { get; set; }


        
    }
}
