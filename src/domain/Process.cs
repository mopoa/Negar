using System;


namespace Negar.Domain
{
    public class Process
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public DateTime CreateTime { get; set; }
        public virtual Payment Payment { get; set; }
    }
}