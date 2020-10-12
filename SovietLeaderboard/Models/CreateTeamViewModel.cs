using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Models
{
    public class CreateTeamViewModel
    {       
        public string TeamDescription { get; set; }
        [Required]
        public string TeamName { get; set; }
    }
    
}
