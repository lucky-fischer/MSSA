using Microsoft.AspNetCore.Identity;

namespace PCAD7_Assignment12_1.Models
{
    public class User:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
