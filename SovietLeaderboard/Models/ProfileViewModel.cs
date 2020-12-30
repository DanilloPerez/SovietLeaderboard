using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Models
{
    public class ProfileViewModel
    {
        [Required]
        public string UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Darkmode { get; set; }
        [Required]
        public string Age{ get; set; }
        [Required]
        public string Avatar { get; set; }
    }
}
