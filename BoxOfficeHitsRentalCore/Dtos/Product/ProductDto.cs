using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfficeHitsRentalCore.Dtos.Product
{
    public class ProductDto
    {
        [Key] public int? Id { get; set; }
        [MaxLength(51)] public string Title { get; set; }
        [MaxLength(51)] public string Genre { get; set; }
        [MaxLength(51)] public string Type { get; set; }
        [MaxLength(26)] public string Rating { get; set; }
        public decimal? Price { get; set; }
        public int CustomerId { get; set; }
    }
}
