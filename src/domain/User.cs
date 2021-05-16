using System;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public long NationalId { get; set; }
        public string Address { get; set; }
        public long PostalCode { get; set; }

        public IFormFile UserPicture { get; set; }

    }
}