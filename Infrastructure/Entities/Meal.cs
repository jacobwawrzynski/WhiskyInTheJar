using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Meal : BaseEntity
    {
        [Required]
        public IEnumerable<string> Ingredients { get; set; } = null!;
        public string? Preparing { get; set; }

        [Column(TypeName = "varchar(7)")]
        public HealthRating HealthRating { get; set; } = HealthRating.Good;

        [Column(TypeName = "varchar(9)")]
        public OverallRating Rating { get; set; } = OverallRating.Average;
    }
}
