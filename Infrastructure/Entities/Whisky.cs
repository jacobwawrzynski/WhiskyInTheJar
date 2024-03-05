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
        [Column(TypeName = "varchar(9)")]
        public OverallRating Rating { get; set; } = OverallRating.Average;

        [Column(TypeName = "nvarchar(100)")]
        public Category Category { get; set; } = Category.Other;

        public int? AvgPriceUSD { get; set; } = null;

        [Required]
        public string Country { get; set; }

        [Required]
        public string Taste { get; set; }

        public int? Age { get; set; } = null;
        public string? ImageUrl { get; set; } = null;
    }
}
