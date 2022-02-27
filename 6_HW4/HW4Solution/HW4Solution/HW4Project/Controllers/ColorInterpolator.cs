using HW4Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW4Project.Controllers
{
    public class ColorInterpolator : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ColorInterpolation c)
        {
            if (ModelState.IsValid)
            {
                return View("Create", c);
            }
            else
            {
                return View("Create", c);
            }
        }
    }
}
