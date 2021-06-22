using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class Art
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =1,ErrorMessage ="Art Title must be less than 50 characters")]
        public string Title { get; set; }
        [Required]
        public IFormFile Picture { get; set; }
        [Required]
        public Decimal  Price { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [MaxLength(500, ErrorMessage = "less than 500 characters")]
        public string Description { get; set; }
        public virtual Designer Designer { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
