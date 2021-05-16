using System;


namespace Negar.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public virtual Art Art { get; set; }
        public virtual Instrument Instrument { get; set; }
    }
}