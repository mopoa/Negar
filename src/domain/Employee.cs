using System;


namespace Negar.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public int PersonalId{ get; set; }
        public int Salary { get; set; }
        public virtual User User { get; set; }
    }
}