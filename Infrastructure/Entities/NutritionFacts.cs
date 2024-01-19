using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class NutritionFacts
    {
        // Provide grams to ounces func in API
        public int Kcal { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double? SaturatedFat { get; set; }
        public double? PolyunsaturatedFats { get; set; }
        public double? MonounsaturatedFats { get; set; }
        public double Carbohydrates { get; set; }
        public double? Sugars { get; set; }
        public double? Fiber { get; set; }
    }
}
