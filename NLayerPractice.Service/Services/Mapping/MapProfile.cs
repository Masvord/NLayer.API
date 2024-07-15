using AutoMapper;
using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Service.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDto>().ReverseMap();
            CreateMap<Category, ProductWithCategoryDto>().ReverseMap();
        }
    }
}
