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
    public class MadLibController : Controller
    {

        [HttpGet]
        public IActionResult GenerateMadLibs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayMadLibs()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult DisplayMadLibs()
        // {
        //     return View();
        // }
    }
}