using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SovietLeaderboard.Models
{
    public class CreateTournamentViewModel
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
