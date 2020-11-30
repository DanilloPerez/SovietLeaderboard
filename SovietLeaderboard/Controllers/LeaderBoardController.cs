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
        private readonly LeaderboardManager leaderboardManager = new LeaderboardManager();

        [HttpGet]
        public IActionResult LeaderBoardView(string LeaderBoardID)
        {

            List<LeaderBoardEntryModel> LBEM = leaderboardManager.GetLeaderBoardEntries(LeaderBoardID);
            return View(LBEM);
        }
        [HttpGet]
        public IActionResult LeaderBoardsView()
        {


            List<LeaderboardModel> leaderboardViewModels = leaderboardManager.GetLeaderBoards();
            return View(leaderboardViewModels);
        }

        [HttpGet]
        public IActionResult CreateLeaderBoardView()
        {

            return View();

        }
        [HttpPost]
        public IActionResult CreateLeaderBoardView(LeaderboardModel leaderboardmodel)
        {
            leaderboardManager.AddLeaderBoard(leaderboardmodel);
            return View();
        }
        [HttpGet]
        public IActionResult EditLeaderboardView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditLeaderboardView(LeaderboardModel leaderboardmodel)
        {
            leaderboardManager.EditLeaderBoard(leaderboardmodel);
            return View();
        }
        [HttpGet]
        public ActionResult DeleteLeaderboardView(string leaderboardID)
        {
            leaderboardManager.DeleteLeaderBoard(leaderboardID);
            //LeaderBoardsView();
            return Redirect("TestView");
        }
    }
}
