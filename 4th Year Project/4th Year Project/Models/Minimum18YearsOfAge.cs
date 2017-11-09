using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4th_Year_Project.Models
{
    public class Minimum18YearsOfAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (User) validationContext.ObjectInstance;

            if (user.UserTypeId == UserType.measca || user.UserTypeId == UserType.ÍocMarAThuiller)
            {
                return ValidationResult.Success;
            }
            else 
            
                return new ValidationResult("Birthdate is a requirement. Please fill in your Birthdate.");
                var age = DateTime.Today.Year - user.BirthDate.Value.Year;

                return (age >= 18)
                    ? ValidationResult.Success
                    : new ValidationResult("The user must be 18 years old to use the application.");

             
            
            
        }
    }
}