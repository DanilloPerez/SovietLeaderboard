using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Models;
using SovietLeaderboard.Models;

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
        [HttpPost]
        public IActionResult CreateLeaderBoardView(CreateLeaderboardViewModel createLeaderboardViewModel)
        {
            LeaderboardManager leaderBoardManager = new LeaderboardManager();
            return View();
           
        }
        [HttpGet]
        public IActionResult CreateLeaderBoardView()
        {
            return View();
        }
        public IActionResult TestView()
        {
           
            return View();
        }
    }
}
