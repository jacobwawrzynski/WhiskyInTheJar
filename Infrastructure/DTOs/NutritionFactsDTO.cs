using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTOs
{
    public class NutritionFactsDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = null;
        public string? Description { get; set; } = null;
        public DateTime DateAdded { get; set; }
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