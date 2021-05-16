using System;
using System.Collections.Generic;

namespace Negar.Domain
{
    public class Packager
    {
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Process> Processes { get; set; }

    }
}