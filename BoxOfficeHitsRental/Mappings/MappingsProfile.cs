using AutoMapper;
using BoxOfficeHitsRentalCore.Dtos;
using BoxOfficeHitsRentalCore.Dtos.Product;
using BoxOfficeHitsRentalCore.Entities;
using BoxOfficeHitsRentalCore.Entities.Products;

namespace BoxOfficeHitsRental.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CustomerDto, Customer>().ReverseMap();
        }
    }
}
