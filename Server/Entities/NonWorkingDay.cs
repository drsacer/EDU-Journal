using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("NonWorkingDays")]
    public class NonWorkingDay
    {
        [Key]
        public int Id { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual SickLeave SickLeave { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? Note { get; set; }

        

    }
}
