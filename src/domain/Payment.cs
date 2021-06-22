using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negar.Domain
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        public bool IsDone { get; set; }
        [Required]
        public DateTime OperationMoment { get; set; }
        public virtual Order Order { get; set; }
        public virtual Process Process { get; set; }
    }
}