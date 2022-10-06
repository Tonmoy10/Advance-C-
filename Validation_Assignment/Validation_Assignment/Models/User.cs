using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation_Assignment.Models
{
    public class User
    {
        [Required(ErrorMessage = "You must enter your ID!")]
        [RegularExpression("[0-9]{2}-[0-9]{5}-[1-3]{1}", ErrorMessage = "Your ID format is incorrect!")]
        public string Id { get; set; }

        [Required(ErrorMessage = "You must enter your name!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Your name length is out of range!")]
        [RegularExpression("^[A-Za-z][A-Za-z_. ,]{2,49}$", ErrorMessage = "Please enter a valid name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must confirm your gender!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "You must enter your email!")]
        [EmailValidation]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter your password!")]
        [RegularExpression(".*(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$ %^&*~><.,:;]).*",
            ErrorMessage = "Password format is incorrect!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must confirm your password!")]
        [Compare("Password", ErrorMessage = "The password does not match!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "You must specify your date of birth!")]
        [DobValidation]
        public DateTime Dob { get; set; }
    }
}