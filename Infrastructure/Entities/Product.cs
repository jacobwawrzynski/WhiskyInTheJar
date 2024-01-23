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
    public class Product : BaseEntity
    {
        [Column(TypeName = "varchar(20)")]
        public FoodCategory FoodCategory { get; set; } = FoodCategory.Others;

        [Column(TypeName = "varchar(7)")]
        public HealthRating HealthRating { get; set; } = HealthRating.Good;

        // Ralationship
        public NutritionFacts NutritionFacts { get; set; } = null!;
    }
}
