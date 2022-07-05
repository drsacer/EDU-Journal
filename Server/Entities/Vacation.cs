using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("Vacation")]
    public class Vacation
    {
        [Key]
        public int Id { get; set; }

        public virtual User User { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        [Required]
        public byte TotalDays { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? Note { get; set; }

    }
}
