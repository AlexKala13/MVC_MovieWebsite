using Microsoft.AspNetCore.Identity;

namespace MovixWebsiteProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
