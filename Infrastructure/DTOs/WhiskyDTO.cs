using Infrastructure.Enums;

namespace Infrastructure.DTOs
{
    public class WhiskyDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateAdded { get; set; }
        public OverallRating Rating { get; set; }
        public double AveragePrice { get; set; }
    }
}
