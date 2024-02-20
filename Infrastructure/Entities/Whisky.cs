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

        [Column(TypeName = "nvarchar(50)")]
        public Category Category { get; set; } = Category.Unknown;

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public double AveragePrice { get; set; }
    }
}
