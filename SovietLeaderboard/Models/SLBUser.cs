using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;


namespace SovietLeaderboard.Models
{
    public class SLBUser : IdentityUser
    {
        public Languages languages { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        public string biography { get; set; }
    }
    public enum Countries
    {
        UnitedKingdom = 1,
        UnitedStates = 2,
        Canada = 3,
        Netherlands = 4,
        Belgium = 5,
        France = 6,
        Germany = 7,
        Japan = 8,
        China = 9
    }

    public enum Languages
    {
        English = 1,
        Dutch = 2,
        French = 3,
        German = 4,
        Japanese = 5,
        Chinees = 6
    }
    public enum Games
    {
        Shooters = 1,
        RaceGames = 2,
        Other = 3,

    }
    public enum LeaderboardTypes
    {
        TallyList = 1,
        LaptimeLeaderboard = 2,
        Leaderboard = 3,
    }
}
