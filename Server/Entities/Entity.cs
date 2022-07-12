using System.ComponentModel.DataAnnotations;

namespace EDU_Journal.Server.Entities
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
