﻿//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
namespace PCAD7_Assignment12_1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Please enter user name")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Please enter password")]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
