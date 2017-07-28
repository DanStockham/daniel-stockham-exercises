using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Critter.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"/[a-zA-Z0-9!@#$]/", ErrorMessage = "The password entered doesn't meet the password rules")]
        [Display(Name = "New Password:")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [Compare("NewPassword", ErrorMessage ="Passwords do not match")]
        [Display(Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }
    }
}