// ReSharper disable All

using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;

namespace NLayer.Service.Mapping;

public class MapProfile :Profile
{
    public MapProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
        CreateMap<ProductUpdateDto, Product>();// Tam tersi olsaydı reverse map kullanacaktım.
        CreateMap<Product, ProductWithCategoryDto>();
        CreateMap<Category, CategoryWithProductsDto>();
    }
}