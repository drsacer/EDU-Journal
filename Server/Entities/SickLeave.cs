using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("SickLeave")]
    public class SickLeave
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        public virtual ICollection<WorkingDay>WorkingDays { get; set; }
    }
}
