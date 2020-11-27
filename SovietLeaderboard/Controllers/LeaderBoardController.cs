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

        public IActionResult EditLeaderboardView()
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
        /*[HttpPost]
        public IActionResult CreateLeaderBoardView(CreateLeaderboardViewModel createLeaderboardViewModel)
        {
            LeaderboardEntryModel leaderboardModel = new LeaderboardEntryModel();
            leaderboardModel.LeaderBoardDescription = createLeaderboardViewModel.LeaderBoardDescription;
            leaderboardModel.LeaderboardID = createLeaderboardViewModel.LeaderboardID;
            leaderboardModel.LeaderBoardName = createLeaderboardViewModel.LeaderBoardName;
            leaderboardModel.leaderboardType = createLeaderboardViewModel.leaderboardType;
            leaderboardModel.UserID = createLeaderboardViewModel.UserID;
            LeaderboardManager leaderBoardManager = new LeaderboardManager();
            leaderBoardManager.InsertLeaderBoard(leaderboardModel);
            return View();

        }*/
       
        [HttpPost]
        public IActionResult LeaderBoardView(CreateLeaderboardViewModel CreateleaderboardViewModel)
        {
            /*LeaderBoardEntryModel leaderboardentryModel = new LeaderBoardEntryModel();
            
            leaderboardentryModel.LeaderBoardID = CreateleaderboardViewModel.LeaderboardID;
            leaderboardentryModel.LeaderBoardScore = CreateleaderboardViewModel.LeaderBoardScore;
            leaderboardentryModel.UserID = CreateleaderboardViewModel.UserID;
            LeaderboardManager leaderBoardManager = new LeaderboardManager();
            leaderBoardManager.EditLeaderBoard(leaderboardentryModel);*/
            return View();
        }
        [HttpGet]
        public  IActionResult LeaderBoardView(string LeaderBoardID)
        {
            
            List<LeaderBoardEntryModel> LBEM = leaderboardManager.GetLeaderBoardEntries(LeaderBoardID);
            return View(LBEM);
        }
        [HttpGet]
        public IActionResult TestView()
        {
           

            List<LeaderboardModel> leaderboardViewModels = GetLeaderBoards();
            /*CreateLeaderboardViewModel CLVM = new CreateLeaderboardViewModel();
            CLVM.LeaderBoardDescription = ("TestLeaderBoard");
            CLVM.LeaderboardID = ("1");
            CLVM.LeaderBoardName = ("TestLeaderBoard");
            CLVM.leaderboardType = LeaderboardType.Laptimes;
            leaderboardViewModels.Add(CLVM);*/

            return View(leaderboardViewModels);
        }
        //[HttpGet]
        public List<LeaderboardModel> GetLeaderBoards()
        {
           
            return leaderboardManager.GetLeaderBoards();
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
        [HttpPost]
        public IActionResult EditLeaderboardView(LeaderboardModel leaderboardmodel)
        {
            leaderboardManager.EditLeaderBoard(leaderboardmodel);
            return View();
        }

    }
}
