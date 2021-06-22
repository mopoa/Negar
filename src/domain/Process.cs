using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Process
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        
        public virtual Payment Payment { get; set; }
    }
}