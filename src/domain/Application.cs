using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Define an instrument")]
        public string Instruments { get; set; }
        [Required]
        [MaxLength(500, ErrorMessage = "less than 500 characters")]
        public string Description { get; set; }

        public IFormFile Image { get; set; }
        public virtual Artist Artist { get; set; }

       
    }
}