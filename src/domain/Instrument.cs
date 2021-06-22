using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class Instrument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        
        public string Title { get; set; }
        [Required]
        public ulong RemainderCount { get; set; }
        [Required]
        [MaxLength(500,ErrorMessage ="less than 500 characters")]
        public string Description { get; set; }
        [Required]
        public int Fee { get; set; }
        public IFormFile Picture { get; set; }
        
    }
}