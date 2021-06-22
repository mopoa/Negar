using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Artist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Decimal Credit { get; set; }
        public virtual Cart Cart { get; set; }

        public virtual  ICollection<Order> Orders { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Art> Arts { get; set; }
        public virtual User User { get; set; }
    }
}