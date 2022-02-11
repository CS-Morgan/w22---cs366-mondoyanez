using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW3Project.Models;

namespace HW3Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult FilmLibrary()
        {
            return View();
        }
        public ViewResult MyLibrary()
        {
            return View();
        }
    }
}
