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
        [HttpGet]
        public ViewResult FilmLibrary()
        {
            MovieList moviesAvailable = new MovieList();
            return View("FilmLibrary", moviesAvailable);
        }
        public ViewResult MyLibrary(int movieId)
        {
            MovieList moviesAvaible = new MovieList();
            UserLibrary movieAdded = new UserLibrary();

            foreach(var m in moviesAvaible.films)
            {
                if (m.MovieId == movieId) 
                {
                    movieAdded.MovieId = m.MovieId;
                    movieAdded.MovieTitle = m.MovieTitle;
                }
            }

            return View(movieAdded);
        }
    }
}
