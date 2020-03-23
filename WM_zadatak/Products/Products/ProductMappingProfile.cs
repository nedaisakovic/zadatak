using AutoMapper;
using Products.Models;
using BLO = Products.BL.Models;

namespace Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<BLO.Product, ProductVM>();
            CreateMap<ProductVM, BLO.Product>();
        }
    }
}