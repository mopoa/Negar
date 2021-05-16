using System;
using System.Collections.Generic;

namespace Negar.Domain
{
    public class Cart
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int TotalPrice { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}