using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Range(0, 9999999999, ErrorMessage = "Personal ID must be 10 digits")]

        public ulong PersonalId { get; set; }
        [Required]
        public Decimal Salary { get; set; }
        public virtual User User { get; set; }
    }
}