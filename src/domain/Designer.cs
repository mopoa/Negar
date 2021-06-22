using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Designer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual ICollection<Application>  Applications { get; set; }
        public virtual ICollection<Art> Arts { get; set; }
        public virtual Employee Employee { get; set; }

    }
}