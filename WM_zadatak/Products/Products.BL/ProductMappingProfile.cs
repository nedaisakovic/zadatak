using AutoMapper;
using Products.BL.Models;
using DAO = Products.DAL.Models;

namespace Products.BL
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<DAO.Product, Product>();
            CreateMap<Product, DAO.Product>();
        }
    }
}
