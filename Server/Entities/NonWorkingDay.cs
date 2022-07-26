using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("NonWorkingDays")]
    public class NonWorkingDay : Entity
    {
        public int UserId { get; set; } //FK
        public virtual User User { get; set; }

        public int SickLeaveId { get; set; } // FK
        public virtual SickLeave SickLeave { get; set; }

        [NotMapped]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        
        [NotMapped]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [MaxLength(300)]
        public string? Note { get; set; }
    }
}
