using System;
using System.Collections.Generic;

namespace Negar.Domain
{
    public class Designer
    {
        public int Id { get; set; }
        public virtual ICollection<Application>  Applications { get; set; }
        public virtual ICollection<Art> Arts { get; set; }
        public virtual Employee Employee { get; set; }

    }
}