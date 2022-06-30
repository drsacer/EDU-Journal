using System.ComponentModel.DataAnnotations;

namespace EDU_Journal.Server.Entities
{
    public class User
    {
        [Key] //atributes
        public int Id { get; set; }

        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string? Password { get; set; }
        [Required]
        public bool IsAdmin { get; set; }

    }
}
