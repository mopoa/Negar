using System;
using System.Collections.Generic;

namespace Negar.Domain
{
    public class Artist
    {
        public int Id { get; set; }
        public int Credit { get; set; }
        public virtual Cart Cart { get; set; }

        public virtual  ICollection<Order> Orders { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Art> Arts { get; set; }
        public User User { get; set; }
    }
}