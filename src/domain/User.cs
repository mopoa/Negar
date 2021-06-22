using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="First name must be between 3 to 50 characters!")]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be between 3 to 50 characters!")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Username must be between 5 to 50 characters!")]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public ulong PhoneNumber { get; set; }
        public ulong NationalId { get; set; }
        public string Address { get; set; }
        public long PostalCode { get; set; }

        public IFormFile UserPicture { get; set; }

    }
}