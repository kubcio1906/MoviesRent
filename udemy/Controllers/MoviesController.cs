using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using udemy.Models;
using udemy.ViewModels;

namespace udemy.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name="Piła"};
       

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                
            };
            return View(viewModel);
        }
        public IActionResult Edit(int id) { 
        
            return Content("id "+ id);
        }
        public IActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        [Route ("/movies/released/{year}/{month}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+month);
        }


    }
}
