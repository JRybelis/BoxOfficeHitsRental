using BoxOfficeHitsRentalCore.Entities.Base;

namespace BoxOfficeHitsRentalCore.Entities.Products
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
    }
}
