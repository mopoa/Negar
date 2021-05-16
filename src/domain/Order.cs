using System;


namespace Negar.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string  Address { get; set; }
        public string  Status { get; set; }
        public int TotalPrice { get; set; }

        public virtual Cart Cart { get; set; }
    }
}