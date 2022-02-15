using System;
using Microsoft.AspNetCore.Mvc;
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
                if (m.movieId == movieId) 
                {
                    movieAdded.movieId = m.movieId;
                    movieAdded.movieTitle = m.movieTitle;
                    movieAdded.dueDate = DateTime.Now.AddDays(14).ToString();
                }
            }

            return View(movieAdded);
        }
    }
}
