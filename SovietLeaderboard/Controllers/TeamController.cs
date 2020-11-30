using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Models;
using ModelsDTO;
using SovietLeaderboard.Models;

namespace SovietLeaderboard.Controllers
{
    public class TeamController : Controller
    {
        private readonly TeamManager teamManager = new TeamManager();
        [HttpGet]
        public IActionResult TeamView(string TeamID)
        {
            List<TeamModel> teammodel = teamManager.GetTeams();
            return View(teammodel);
        }
        [HttpGet]
        public IActionResult TeamsView()
        {
            List<TeamModel> TeamModels = teamManager.GetTeams();
            return View(TeamModels);
        }
        [HttpGet]
        public IActionResult CreateTeamView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeamView(TeamModel model)
        {
            teamManager.CreateTeam(model);
            TeamsView();
            return Redirect("TeamsView");
        }
        [HttpGet]
        public IActionResult DeleteTeamView(string TeamID)
        {
            teamManager.DeleteTeams(TeamID);
           
            return Redirect("TeamsView");
        }
        [HttpPost]
        public IActionResult EditTeamView(TeamModel model)
        {
            teamManager.EditTeam(model);
            TeamsView();
            return Redirect("TeamsView");
        }
        [HttpGet]
        public IActionResult EditTeamView()
        {
            return View();
        }
        
    }
}
