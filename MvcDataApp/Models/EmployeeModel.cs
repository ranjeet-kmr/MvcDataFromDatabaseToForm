using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDataApp.Models
{
    public class EmployeeModel
    {
        [Required]
        [Display(Name ="Employee ID")]
        [Range(10000,99999,ErrorMessage ="Enter a Valid Employee Id")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="First Name Can't be blank")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Can't be blank")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter a valid Email")]
        [Display(Name = "Email Address")]
        public string  EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress",ErrorMessage ="Email & Confirm email didn't match")]
        public string  ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password can't be left blank")]
        [StringLength(100,MinimumLength =7, ErrorMessage = "Password Length can't be less than 7 characters in length.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password & Confirm Password didn't match")]
        public string  ConfirmPassword { get; set; }
    }
}