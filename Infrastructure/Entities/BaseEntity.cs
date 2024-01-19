using Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Length(1, 25)]
        public string Name { get; set; }

        [Length(1, 250)]
        public string Description { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        // Add annotation
        public FoodCategory FoodCategory { get; set; } = FoodCategory.Others;

        //public Guid? PhotoId { get; set; } // Assign default photo with guid 00...
    }
}
