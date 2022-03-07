using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class CampController : Controller
    {
        [HttpGet]
        public IActionResult GenerateMadLibs()
        {

            return View("GenerateMadLibs");
        }

        [HttpGet]
        public IActionResult DisplayMadLibs()
        {
            return View("DisplayMadLibs");
        }

        // [HttpPost]
        // public IActionResult DisplayMadLibs(RoadTripMadLib roadTrip)
        // {
        //     return View("DisplayMadLibs", roadTrip);
        // }
    }
}