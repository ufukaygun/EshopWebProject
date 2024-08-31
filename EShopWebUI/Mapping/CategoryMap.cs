using AutoMapper;
using EntityLayer.Entities;
using EShopWebUI.Models;

namespace EShopWebUI.Mapping
{
    public class CategoryMap :Profile
    {
        public CategoryMap()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
        }
    }
}
