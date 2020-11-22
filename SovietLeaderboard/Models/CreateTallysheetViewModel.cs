using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Models
{
    public class CreateTallySheetViewModel
    {
            [Required]
            public string TallySheetID { get; set; }
            [Required]
            public string TallySheetName { get; set; }
            [Required]
            public string TallySheetDescription { get; set; }
           
            
        
           
        
    }
}
