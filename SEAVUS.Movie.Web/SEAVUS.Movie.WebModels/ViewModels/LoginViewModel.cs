using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please insert username!")]
        [StringLength(16, ErrorMessage = "Username must be between 3 and 16 characters", MinimumLength = 3)]
        public string Username { get; set; }

        [StringLength(255, ErrorMessage = "Password must be between 5 and 255 characters", MinimumLength = 5)]

        [Required(ErrorMessage = "Please insert password!")]
        public string Password { get; set; }
    }
}
