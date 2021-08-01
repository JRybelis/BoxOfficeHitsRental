using BoxOfficeHitsRentalCore.Entities.Products;

namespace BoxOfficeHitsRentalCore.Entities.Relational
{
    public class CustomerProduct
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
