using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("Vacations")]
    public class Vacation : Entity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        [Required]
        public byte TotalDays { get; set; }

        [MaxLength(30)]
        [Unicode]
        public string? Note { get; set; }
    }
}
