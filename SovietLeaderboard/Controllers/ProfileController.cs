using Interfaces.LogicInterfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovietLeaderboard.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileManager profileManager = new LogicFactory().ProfileManager();
        [HttpGet]
        public IActionResult GetProfileView(string UserID)
        {
            string userID = User.Identity.GetUserId();
            ProfileModel profilemodel = profileManager.GetProfile(userID);
            return View(profilemodel);
        }

        public IActionResult CreateProfileView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProfileView(ProfileModel model)
        {
            profileManager.CreateProfile(model);
            //ProfileView("1");
            return Redirect("CreateProfileView");
        }     
        [HttpGet]
        public IActionResult DeleteProfile()
        {
            string userID = User.Identity.GetUserId();
            profileManager.DeleteProfile(userID);
            return Redirect("CreateProfileView");
        }

    }
}
