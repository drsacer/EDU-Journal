using EDU_Journal.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("WorkingDays")]
    public class WorkingDay
    {
        
        [Key]
        public int Id { get; set; }

       
        public int UserId { get; set; }  // vanjski ključ - koristi se samo za bazu

        [Required]
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

        [Column(TypeName = "varchar(300)")]
        public string? Note { get; set; }

    }
}
