using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using LogicLayer;
using SovietLeaderboard.Models;
using ModelsDTO;

namespace SovietLeaderboard.Controllers
{
    public class TournamentController : Controller
    {
        TournamentManager tournamentmanager = new TournamentManager();
       


        [HttpGet]
        public IActionResult TournamentView()

        {

            List<TeamModel> teamlist = new List<TeamModel>();
            for (int i = 0; i < 8; i++)
            {
                TeamModel team = new TeamModel(i.ToString(), "goodest team"+i.ToString(), "ForfeitPLS"+i.ToString(), "1"+i.ToString(), new List<string>());
                teamlist.Add(team);
            }
            TournamentViewModel tournamentViewModel = new TournamentViewModel();
            


            tournamentViewModel.teams = teamlist;
            tournamentViewModel.rounds = tournamentmanager.CalculateRounds(teamlist.Count);
            tournamentViewModel.POSmodels = tournamentmanager.GetTeamPosition("1");
            return View(tournamentViewModel);            
        }

    }
}      
                        
    

