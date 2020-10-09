using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SovietLeaderboard.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult TeamView()
        {
            return View();
        }
        public IActionResult CreateTeamView()
        {
            return View();
        }
        
    }
}
