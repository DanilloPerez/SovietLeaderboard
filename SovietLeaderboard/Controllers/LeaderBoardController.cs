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
            LeaderboardModel leaderboardModel = new LeaderboardModel();
            leaderboardModel.LeaderBoardDescription = createLeaderboardViewModel.LeaderBoardDescription;
            leaderboardModel.LeaderboardID = createLeaderboardViewModel.LeaderboardID;
            leaderboardModel.LeaderBoardName = createLeaderboardViewModel.LeaderBoardName;
            leaderboardModel.leaderboardType = createLeaderboardViewModel.leaderboardType;
            leaderboardModel.UserID = createLeaderboardViewModel.UserID;
            LeaderboardManager leaderBoardManager = new LeaderboardManager();
            leaderBoardManager.InsertLeaderBoard(leaderboardModel);
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
