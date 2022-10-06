using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation_Assignment.Models
{
    public class DobValidation : ValidationAttribute
    {
        DateTime Date = new DateTime(2022, 1, 1);
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime dob = DateTime.Parse(value.ToString());
                TimeSpan dif = (Date - dob);
                int age = dif.Days / 365;
                if (age >= 18)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("You are not 18 years old yet!");
                }
            }
            return new ValidationResult("No data found");
        }
    }
}