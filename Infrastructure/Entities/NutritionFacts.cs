using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class NutritionFacts
    {
        [Key]
        public Guid Id { get; set; }
        public int Kcal { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double? SaturatedFat { get; set; }
        public double? PolyunsaturatedFats { get; set; }
        public double? MonounsaturatedFats { get; set; }
        public double Carbohydrates { get; set; }
        public double? Sugars { get; set; }
        public double? Fiber { get; set; }

        // Relationship
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
