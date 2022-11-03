using System.ComponentModel.DataAnnotations;
namespace PCAD7_Project_MVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Please enter user name")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Please enter password")]
        public string? Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
