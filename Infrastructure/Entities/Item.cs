using Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Item : BaseEntity
    {
        [Length(1, 25)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        [MaxLength(250)]
        public string? Comment { get; set; }

        public Stars Stars { get; set; } = Stars.Undefinied;

        public Guid? PhotoId { get; set; } // Assign default photo with guid 00...
    }
}
