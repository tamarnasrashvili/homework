using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TSUViewEngine.Models;
using static TSUViewEngine.Models.MovieRepository;

namespace TSUViewEngine.Controllers
{
    public class ManageController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        public ManageController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public IActionResult Movie()
        {
            MovieVM model = new MovieVM();
            model.Movies = _movieRepository.Movies;


            return View(model);
        }

        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            _movieRepository.Create(movie);
            return RedirectToAction("Movie");
        }
        public IActionResult Edit(int? Id)
        {
            var movie = _movieRepository.Movies.Where(x => x.Id == Id).FirstOrDefault();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie editedMovie)
        {
            var movie = _movieRepository.Movies.Where(x => x.Id == editedMovie.Id).FirstOrDefault();
            movie.Title = editedMovie.Title;
            movie.Thumb = editedMovie.Thumb;
            return RedirectToAction(nameof(Movie));
        }

        public IActionResult Search(string searchString)
        {
            var movie = _movieRepository.Movies.Where(x => x.Title.Contains(searchString, StringComparison.InvariantCultureIgnoreCase));
            return View(movie);
        }
    }
}