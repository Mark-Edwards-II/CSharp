using System.ComponentModel.DataAnnotations;
using System;

namespace ValidatingForm.Models
{
    public class User
    {
        [Required(ErrorMessage="First name is required")]
        [MinLength(4,ErrorMessage="First name needs to be at least 4 characters.")]
        [Display(Name="First name")]
        public string FName {get;set;}
        
        [Required(ErrorMessage="Last name is required")]
        [MinLength(4,ErrorMessage="Last name needs to be at least 4 characters.")]
        [Display(Name="Last name")]
        public string LName {get;set;}

        [Required(ErrorMessage="Age is Required.")]
        [Range(0,110)]
        [Display(Name="Age")]
        public int Age {get;set;}


        
        [Required(ErrorMessage="Email is Required.")]
        [DataType(DataType.EmailAddress,ErrorMessage="Please enter a valid email address.")]
        [Display(Name="Email")]
        public string Email {get;set;}

        
        [Required(ErrorMessage="Password is Required.")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password {get;set;}

    }
}