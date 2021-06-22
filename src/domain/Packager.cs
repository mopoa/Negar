using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Packager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Process> Processes { get; set; }

    }
}