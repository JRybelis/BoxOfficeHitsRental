using System.ComponentModel.DataAnnotations;

namespace BoxOfficeHitsRentalCore.Dtos
{
    public class CustomerDto
    {
        [Key] public int? Id { get; set; }
        [MaxLength(51)] public string Forename { get; set; }
        [MaxLength(51)] public string Surname { get; set; }
        public decimal? AccountBalance { get; set; }
    }
}
