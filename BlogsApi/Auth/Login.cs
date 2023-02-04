using System.ComponentModel.DataAnnotations;

namespace BlogsApi.Auth
{
    public class Login
    {

        [Required(ErrorMessage = "User is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
