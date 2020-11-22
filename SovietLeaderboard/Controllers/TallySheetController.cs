using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace SovietLeaderboard.Controllers
{
    //public class TallySheetController : Controller
    //{
    //    [HttpPost]
    //    public IActionResult CreateTallySheetView(CreateTallySheetViewModel createTallySheetViewModel)
    //    {
    //        TallySheetModel tallySheetModel = new TallySheetModel();
    //        tallySheetModel.TallySheetDescription = createTallySheetViewModel.TallySheetDescription;
    //        tallySheetModel.TallySheetID = createTallySheetViewModel.TallySheetID;
    //        tallySheetModel.TallySheetName = createTallySheetViewModel.TallySheetName;
    //        tallySheetModel.TallySheetType = createTallySheetViewModel.leaderboardType;
    //        tallySheetModel.UserID = createTallySheetViewModel.UserID;
    //        TallySheetManager tallySheetManager = new TallySheetManager();
    //        tallySheetManager.InsertTallySheet(tallySheetModel);
    //        return View();

    //    }
    //    [HttpGet]
    //    public IActionResult CreateTallySheetView()
    //    {
    //        return View();
    //    }
    //    [HttpPost]
    //    public IActionResult EditTallySheetView(TallySheetViewModel tallySheetViewModel)
    //    {
    //        TallySheetModel tallySheetModel = new TallySheetModel();
    //        tallySheetModel.TallySheetDescription = tallySheetViewModel.TallySheetDescription;
    //        tallySheetModel.TallySheetID = tallySheetViewModel.TallySheetID;
    //        tallySheetModel.TallySheetName = tallySheetViewModel.TallySheetName;
    //        tallySheetModel.UserID = tallySheetViewModel.UserID;
    //        TallySheetManager tallySheetManager = new TallySheetManager();
    //        tallySheetManager.EditTallySheet(tallySheetModel);
    //        return View();
    //    }
    //    [HttpGet]
    //    public IActionResult EditTallySheetView()
    //    {
    //        return View();
    //    }
    //}
}
