using Microsoft.AspNetCore.Identity;

namespace BlogsApi.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
