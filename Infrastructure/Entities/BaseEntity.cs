using Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //public Guid? PhotoId { get; set; } // Assign default photo with guid 00...
    }
}
