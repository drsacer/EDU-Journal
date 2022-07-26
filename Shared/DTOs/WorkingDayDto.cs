using System.ComponentModel.DataAnnotations;

namespace EDU_Journal.Shared.DTOs
{
    public class WorkingDayDto
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }  

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }

        [Required]
        public TimeOnly PauseDuration { get; set; }

        [MaxLength(30)]
        public string? Note { get; set; }
    }
}
