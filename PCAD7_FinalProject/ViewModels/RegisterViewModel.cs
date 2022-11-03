using System.ComponentModel.DataAnnotations;
namespace PCAD7_Project_MVC.ViewModels
{
    public class RegisterViewModel:LoginViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Enter first name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter last name")]
        public string? LastName { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
    }
}
