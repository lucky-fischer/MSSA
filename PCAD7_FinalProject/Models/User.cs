using Microsoft.AspNetCore.Identity;

namespace PCAD7_Project_MVC.Models
{
    public class User:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
