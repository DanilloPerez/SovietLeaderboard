using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SovietLeaderboard.Controllers
{
    public class LeaderBoardController : Controller
    {
        public IActionResult LeaderboardView()
        {
            return View();
        }
        public IActionResult LaptimeView()
        {
            return View();
        }
        public IActionResult TallySheetView()
        {
            return View();
        }
        public IActionResult CreateLeaderBoardView()
        {
            return View();
        }
    }
}
