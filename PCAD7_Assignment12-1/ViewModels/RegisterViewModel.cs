﻿using System.ComponentModel.DataAnnotations;
namespace PCAD7_Assignment12_1.ViewModels
{
    public class RegisterViewModel:LoginViewModel
    {
        [Required(ErrorMessage ="Enter first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Enter first name")]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
