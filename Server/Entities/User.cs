using System.ComponentModel.DataAnnotations;

namespace EDU_Journal.Server.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
