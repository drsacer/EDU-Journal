using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("NonWorkingDays")]
    public class NonWorkingDay
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; } //FK

        public int SickLeaveId { get; set; } // FK

        public virtual User User { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        public virtual SickLeave SickLeave { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? Note { get; set; }

        

    }
}
