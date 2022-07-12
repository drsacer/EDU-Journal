
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("WorkingDays")]
    public class WorkingDay : Entity
    {        
        [Required]
        public int UserId { get; set; }  // FK - koristi se samo za bazu
        public virtual User User { get; set; } //veza na tablicu User - služi za povezivanje User i WorkingDay (važan tip virtual)

        [Required]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeOnly  StartTime { get; set; }
        
        [Required]
        [DataType(DataType.Time)]
        public TimeOnly EndTime { get; set; }
        
        [Required]
        [DataType(DataType.Time)]
        public TimeOnly PauseDuration { get; set; }
        
        [MaxLength(30)]
        [Unicode]
        public string? Note { get; set; }
    }
}
