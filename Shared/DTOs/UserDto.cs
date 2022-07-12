using System.ComponentModel.DataAnnotations;

namespace EDU_Journal.Shared.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
