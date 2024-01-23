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

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public double LowestPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public double HighestPrice { get;set; }
    }
}
