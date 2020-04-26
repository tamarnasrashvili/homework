using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TSUViewEngine.Models;
using static TSUViewEngine.Models.MovieRepository;

namespace TSUViewEngine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            MovieVM model = new MovieVM();
            model.Movies = _movieRepository.Movies;

            ViewBag.Name = "nika";

            return View(model);
        }

       


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
