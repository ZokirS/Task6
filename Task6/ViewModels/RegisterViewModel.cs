﻿using System.ComponentModel.DataAnnotations;

namespace Task6.ViewModels
{

    public class RegisterViewModel
    {
        [Required] 
        [Display(Name = "FirstName")] 
        public string? FirstName { get; init; }
        
        [Required] 
        [Display(Name = "LastName")] 
        public string? LastName { get; init; }
        
        [Required] 
        [Display(Name = "Email")] 
        public string? Email { get; init; }
        
        [Required] 
        [Display(Name = "Age")] 
        public int Age { get; init; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; init; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords doesn't match!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string? PasswordConfirm { get; init; }
    }
}