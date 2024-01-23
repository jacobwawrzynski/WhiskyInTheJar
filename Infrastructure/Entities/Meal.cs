using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public FoodCategory Category { get; set; } = FoodCategory.Others;
    }
}
