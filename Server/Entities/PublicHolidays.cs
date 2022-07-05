using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("PublicHolidays")]
    public class PublicHolidays
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }
    }
}
