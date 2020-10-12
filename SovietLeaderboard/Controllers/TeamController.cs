using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SovietLeaderboard.Models;

namespace SovietLeaderboard.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult TeamView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateTeamView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeamView(CreateTeamViewModel model)
        {
            return View();
        }
        
    }
}
