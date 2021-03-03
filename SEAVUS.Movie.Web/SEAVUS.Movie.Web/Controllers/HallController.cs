using Microsoft.AspNetCore.Mvc;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEAVUS.Movie.Web.Controllers
{
    public class HallController : Controller
    {
        private readonly IHallService _hallService;

        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hall(int id)
        {
            HallViewModel hall = _hallService.GetHallById(id);

            return View(hall);
        }
    }
}
