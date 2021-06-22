using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "Address could be between 20 to 200 characters")]
        public string Address { get; set; }
        public string Status { get; set; }
        [Required]
        public int TotalPrice { get; set; }

        public virtual Cart Cart { get; set; }
    }
}