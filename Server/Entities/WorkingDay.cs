using EDU_Journal.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace EDU_Journal.Server.Entities
{
    public class WorkingDay
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public User User { get; set; } // je li to vanjski ključ iz tablice?
        [Required]
        public DateOnly Date { get; set; }

        public TimeOnly  StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public TimeOnly PauseDuration { get; set; }

        public string? Note { get; set; }

    }
}
