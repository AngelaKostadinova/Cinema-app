using Microsoft.AspNetCore.Mvc;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.Web.Models;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEAVUS.Movie.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index(string searchTerm)
        {
            HomeViewModel homeModel = new HomeViewModel();
            homeModel.LoginModel = new LoginViewModel();
            homeModel.RegisterModel = new RegisterViewModel();
            ViewData["Search"] = searchTerm;

            List<MovieViewModel> movies = _movieService.SearchMovies(searchTerm).ToList();
            homeModel.MoviesModel = movies;

            return View(homeModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
