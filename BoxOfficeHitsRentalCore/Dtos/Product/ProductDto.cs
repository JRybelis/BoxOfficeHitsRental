using System.ComponentModel.DataAnnotations;

namespace BoxOfficeHitsRentalCore.Dtos.Product
{
    public class ProductDto
    {
        [MaxLength(51)] public string Title { get; set; }
        [MaxLength(51)] public string Genre { get; set; }
        [MaxLength(51)] public string Type { get; set; }
        [MaxLength(26)] public string Rating { get; set; }
        public decimal? Price { get; set; }
        public int CustomerId { get; set; }
    }
}
