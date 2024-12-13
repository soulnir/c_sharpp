using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace cs_prak_3.Models
{
    public class Villa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}