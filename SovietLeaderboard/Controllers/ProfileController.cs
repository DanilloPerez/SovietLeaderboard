using Interfaces.LogicInterfaces;
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
        public IActionResult GetProfileView()
        {
            ProfileModel profilemodel = profileManager.GetProfile();
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

    }
}
