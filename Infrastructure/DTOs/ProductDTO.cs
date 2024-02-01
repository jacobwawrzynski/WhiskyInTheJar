using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public HealthRating HealthRating { get; set; }
    }
}
