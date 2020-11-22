using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using LogicLayer;
using SovietLeaderboard.Models;

namespace SovietLeaderboard.Controllers
{
    public class TournamentController : Controller
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
            //public IActionResult CreateTournamentView(TournamentViewModel TournamentViewModel)
            //{
            //    TournamentModel tournamentModel = new TournamentModel();
            //    tournamentModel.TournamentDescription = createTournamentViewModel.TournamentDescription;
            //    tournamentModel.TournamentID = createTournamentViewModel.LeaderboardID;
            //    tournamentModel.TournamentName = createTournamentViewModel.LeaderBoardName;
            //    tournamentModel.TournamentType = createTournamentViewModel.leaderboardType;
            //    tournamentModel.UserID = createTournamentViewModel.UserID;
            //    TournamentManager tournamentManager = new TournamentManager();
            //    tournamentManager.InsertTournament(tournamentModel);
            //    return View();

            //}
            //[HttpGet]
            //public IActionResult CreateLeaderBoardView()
            //{
            //    return View();
            //}
            public IActionResult TestView()
            {

                return View();
            }

        }
    }
}
