using BoxOfficeHitsRentalCore.Entities.Base;
using BoxOfficeHitsRentalCore.Entities.Products;
using BoxOfficeHitsRentalCore.Entities.Relational;
using System.Collections.Generic;

namespace BoxOfficeHitsRentalCore.Entities
{
    public class Customer : BaseEntity
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public decimal AccountBalance { get; set; }
        public List<CustomerProduct> Products { get; set; }
        public List<Film> Films {get; set; }
        public List<FilmBoxSet> FilmBoxSets { get; set; }
        public List<TVSeriesBoxSet> TVSeriesBoxSets { get; set; }

    }
}
