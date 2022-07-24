using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EDU_Journal.Shared.DTOs
{
    public class VacationDto
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        [Required]
        public byte TotalDays { get; set; }

        [MaxLength(30)]
        public string? Note { get; set; }
    }
}
