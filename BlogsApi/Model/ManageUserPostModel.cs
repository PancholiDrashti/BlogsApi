namespace BlogsApi.Models
{
    public class ManageUserPostModel
    {
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Mobilenumber { get; set; }
        public string RoleId { get; set; }
        public string Address { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
    public class ManageUserModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Mobilenumber { get; set; }
        public string RoleId { get; set; }
        public string Address { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
}
