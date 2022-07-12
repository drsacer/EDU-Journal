using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("SickLeaves")]
    public class SickLeave : Entity
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
