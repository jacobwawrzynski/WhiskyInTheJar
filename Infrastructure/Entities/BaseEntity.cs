using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
