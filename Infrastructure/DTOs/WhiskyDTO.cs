using Infrastructure.Enums;

namespace Infrastructure.DTOs
{
    public class WhiskyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime DateAdded { get; set; }
        public OverallRating Rating { get; set; }
        public int? AvgPriceUSD { get; set; }
        public string Country { get; set; }
        public string Taste { get; set; }
        public string Aroma { get; set; }
        public string Aftertaste { get; set; }
        public double AlcoholVol { get; set; }
        public int? Age { get; set; }
        public string? ImageUrl { get; set; }
    }
}
