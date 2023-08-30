using System.ComponentModel.DataAnnotations;

namespace MovixWebsiteProject.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}
