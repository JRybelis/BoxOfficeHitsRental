using BoxOfficeHitsRentalCore.Entities.Base;
using BoxOfficeHitsRentalCore.Entities.Relational;
using BoxOfficeHitsRentalCore.Enums;
using System.Collections.Generic;

namespace BoxOfficeHitsRentalCore.Entities.Products
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        //public ProductTypeEnum Type {get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
        public int CatalogueId { get; set; }
        public Catalogue Catalogue { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<CustomerProduct> Customers { get; set; }
    }
}
