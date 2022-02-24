using HW4Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW4Project.Controllers
{
    public class ColorInterpolator : Controller
    {
        //[HttpPost]
        //public IActionResult Create(ColorInterpolation c)
        //{
        //    return View("Create", c);
        //}

        public IActionResult Create()
        {
            return View();
        }
    }
}
