using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Models;
using ModelsDTO;
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
        [HttpPost]
        public IActionResult EditLeaderBoardView(LeaderboardViewModel leaderboardViewModel)
        {
            LeaderboardModel leaderboardModel = new LeaderboardModel();
            leaderboardModel.LeaderBoardDescription = leaderboardViewModel.LeaderBoardDescription;
            leaderboardModel.LeaderboardID = leaderboardViewModel.LeaderboardID;
            leaderboardModel.LeaderBoardName = leaderboardViewModel.LeaderBoardName;
            leaderboardModel.UserID = leaderboardViewModel.UserID;
            LeaderboardManager leaderBoardManager = new LeaderboardManager();
            leaderBoardManager.EditLeaderBoard(leaderboardModel);
            return View();
        }
        [HttpGet]
        public  IActionResult EditLeaderBoardView()
        {
            LeaderboardManager leaderBoardManager = new LeaderboardManager();
           
            List <LeaderBoardEntryModel> LBEM = leaderBoardManager.GetLeaderBoardEntries("1");
            return View(LBEM);
        }
        public IActionResult TestView()
        {
           
            return View();
        }
       
    }
}
