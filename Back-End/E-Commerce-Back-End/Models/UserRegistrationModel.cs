﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Back_End
{
    public class UserRegistrationModel
    {
        [Required, MaxLength(200), MinLength(3), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(200), MinLength(3), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, MaxLength(15), MinLength(3)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required, EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required, MinLength(6), MaxLength(16)]
        [Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Compare("Password")]
        [Display(Name = "Confirm Password"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
