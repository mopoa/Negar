using System;


namespace Negar.Domain
{
    public class Administrator
    {
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }
    }
}