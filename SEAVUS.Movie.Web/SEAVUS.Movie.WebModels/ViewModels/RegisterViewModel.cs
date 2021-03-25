using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please insert first name!")]
        [StringLength(255, ErrorMessage = "First name must between 3 and maximum 255 characters", MinimumLength = 3)]
        [Display(Name = "Enter first name:")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please insert last name!")]
        [StringLength(255, ErrorMessage = "Last name must between 3 and maximum 255 characters", MinimumLength = 3)]
        [Display(Name = "Enter last name:")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please insert username!")]
        [StringLength(16, ErrorMessage = "Username must be between 3 and 16 characters", MinimumLength = 3)]
        [Display(Name = "Enter username:")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please insert email address!")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        [Display(Name = "Enter email address:")]
        public string Email { get; set; }

        [Display(Name = "Enter your birthdate:")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Please insert password!")]
        [StringLength(255, ErrorMessage = "Password must be between 5 and 255 characters", MinimumLength = 5)]
        [Display(Name = "Enter password:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        [StringLength(255, ErrorMessage = "Password must be between 5 and 255 characters", MinimumLength = 5)]
        [Display(Name = "Confirm password:")]
        public string ConfirmPassword { get; set; }


    }
}

