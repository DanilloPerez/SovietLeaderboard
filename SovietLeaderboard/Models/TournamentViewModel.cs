using ModelsDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Models
{
    public class TournamentViewModel
    {

        public List<TeamModel> teams = new List<TeamModel>();
        public int rounds { get; set; }
       
    }
}
