using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class HomeViewModel
    {
        public List<MovieViewModel> MoviesModel { get; set; }
        public LoginViewModel LoginModel { get; set; }
        public RegisterViewModel RegisterModel { get; set; }
    }
}
