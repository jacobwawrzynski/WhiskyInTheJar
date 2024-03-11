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
    public class Whisky : BaseEntity
    {
        [Column(TypeName = "varchar")]
        public OverallRating Rating { get; set; } = OverallRating.Average;

        public int? AvgPriceUSD { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Country { get; set; }

        [Range(0, 100)]
        public double AlcoholVol { get; set; }

        [Required]
        public string Taste { get; set; }

        [Required]
        public string Aroma { get; set; }

        [Required]
        public string Aftertaste { get; set; }

        public int? Age { get; set; }
        
        public string? ImageUrl { get; set; }
    }
}
