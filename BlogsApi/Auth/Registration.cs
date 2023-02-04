using System.ComponentModel.DataAnnotations;

namespace BlogsApi.Auth
{
    public class Registration
    {
        [Required(ErrorMessage = "User is required")]
        public string? UserName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "User is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "User is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "User is required")]
        public string? MobileNumber { get; set; }
    }
}
