using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDU_Journal.Server.Entities
{
    [Table("Users")]
    public class User : Entity
    {
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(12)]
        public string? Password { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        // povezivanje entiteta User s WorkingDay (User ima listu working daya)
        // to je isto napravljeno u klasi WorkingDay - tako da ne moramo povezivati unutar DbContexta
        // bitan je tip podataka virtual
        public virtual ICollection<WorkingDay> WorkingDays { get; set; } 
        public virtual ICollection<NonWorkingDay> NonWorkingDays { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; }

    }
}
