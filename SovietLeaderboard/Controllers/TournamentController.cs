using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SovietLeaderboard.Controllers
{
    public class TournamentController : Controller
    {
        public IActionResult TournamentTreeView()
        {

            return View();
        }
        public IActionResult TournamentRegisterView()
        {
            return View();
        }
        public IActionResult CreateTournamentView()
        {
            return View();
        }
    }
}
