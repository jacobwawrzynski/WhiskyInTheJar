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
    public class Item : BaseEntity
    {
        [Column(TypeName = "varchar(20)")]
        public FoodCategory FoodCategory { get; set; } = FoodCategory.Others;

        [Column(TypeName = "varchar(9)")]
        public OverallRating OverallRating { get; set; } = OverallRating.Good;

        // Ralationship
        public NutritionFacts NutritionFacts { get; set; } = null!;
    }
}
