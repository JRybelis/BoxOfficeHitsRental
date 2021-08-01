using BoxOfficeHitsRentalCore.Entities.Base;
using BoxOfficeHitsRentalCore.Entities.Products;
using System.Collections.Generic;

namespace BoxOfficeHitsRentalCore.Entities
{
    public class Customer : BaseEntity
    {
        public int Forename { get; set; }
        public int Surname { get; set; }
        public decimal AccountBalance { get; set; }
        public List<Film> Films {get; set; }
        public List<FilmBoxSet> FilmBoxSets { get; set; }
        public List<TVSeriesBoxSet> TVSeriesBoxSets { get; set; }

    }
}
