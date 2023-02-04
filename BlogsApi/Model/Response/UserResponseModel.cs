﻿namespace BlogsApi.Models.Response
{
    public class UserResponseModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public string ProfileImage { get; set; }
        public string ProfileImageDisplayName { get; set; }
       
    }
}
