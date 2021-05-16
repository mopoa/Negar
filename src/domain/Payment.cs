using System;


namespace Negar.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public bool IsDone { get; set; }
        public DateTime OperationMoment { get; set; }
        public virtual Order Order { get; set; }
        public virtual Process Process { get; set; }
    }
}