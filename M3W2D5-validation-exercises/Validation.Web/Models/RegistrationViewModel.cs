using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Compare("Email")]
        public string ConfirmEmail { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters long")]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [Range(1, 10)]
        public int NumberOfTickets { get; set; }
    }
}