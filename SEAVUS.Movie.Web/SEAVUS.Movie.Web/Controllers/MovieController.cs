using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEAVUS.Movie.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Movies(string searchTerm)
        {
            ViewData["Search"] = searchTerm;

            List<MovieViewModel> movies = _movieService.SearchMovies(searchTerm).ToList();

            return View(movies);
        }

        public IActionResult Details(int id)
        {
            MovieViewModel movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        public IActionResult MoviePanel()
        {
            List<MovieViewModel> movies = _movieService.GetAllMovies().ToList();
            return View(movies);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _movieService.Delete(id);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                ViewBag.Message = message;
            }
            
            return RedirectToAction("MoviePanel");
        }

        [HttpGet]
        public IActionResult Add()
        {
            MovieViewModel movie = new MovieViewModel
            {
                Actors = new List<MovieCastViewModel>()
            };
            int actors = 2;
            for(int i = 0; i < actors; i++)
            {
                movie.Actors.Add(new MovieCastViewModel());
            }
            
            return View(movie);
        }

        [HttpPost]
        public IActionResult Add(MovieViewModel model, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _movieService.UploadImage(model, image);
                    _movieService.AddNewMovie(model);
                    return RedirectToAction("MoviePanel", "Movie");
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;

                ViewBag.Message = message;
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            MovieViewModel model = _movieService.GetMovieById(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MovieViewModel model, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (image != null)
                    {
                        _movieService.UploadImage(model, image);
                    }
                    _movieService.EditMovie(model);
                    return RedirectToAction("MoviePanel", "Movie");
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                ViewBag.Message = message;
            }
           

            return View(model);
        }

    }
}
