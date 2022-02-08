using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public ViewResult RsvpForm()
        // {
        //     return View();
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [HttpGet]
        // public ViewResult RsvpForm()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public ViewResult RsvpForm(GuestResponse guestResponse) {
        //     // TODO: store response from guest
        //     return View();
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [HttpGet]
        // public ViewResult RsvpForm()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public ViewResult RsvpForm(GuestResponse guestResponse) {
        //     Repository.AddResponse(guestResponse);
        //     return View("Thanks", guestResponse);
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [HttpGet]
        // public ViewResult RsvpForm()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public ViewResult RsvpForm(GuestResponse guestResponse) {
        //     Repository.AddResponse(guestResponse);
        //     return View("Thanks", guestResponse);
        // }

        // public ViewResult ListResponses() {
        //     return View(Repository.Responses.Where(r => r.WillAttend == true));
        // }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else {
                return View();
            }
        }

        public ViewResult ListResponses() {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
