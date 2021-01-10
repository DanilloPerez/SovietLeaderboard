using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using LogicLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using ModelsDTO;
using SovietLeaderboard.Models;

namespace SovietLeaderboard.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamManager teamManager = new LogicFactory().TeamManager();
        private readonly UserManager<SLBUser> userManager;

        public TeamController(UserManager<SLBUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult TeamView(string TeamID)
        {
            TeamID = "3";
            var model = teamManager.GetTeamByID(TeamID);
            return View(model);
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
        public async Task<IActionResult> CreateTeamView(TeamModel model)
        {

            var currentUser = await userManager.GetUserAsync(User);
            model.OwnerID = currentUser.Id;
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
