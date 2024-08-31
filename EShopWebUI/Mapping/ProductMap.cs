using AutoMapper;
using EntityLayer.Entities;
using EShopWebUI.Models;

namespace EShopWebUI.Mapping
{
	public class ProductMap : Profile
	{
		public ProductMap()
		{
			//Ignore yapıldı. Product ve product model arasında mapping yaparken görmezden gelinmesini istediğimiz propertyleri ignore diyerek belirtiyoruz.
			CreateMap<Product, ProductModel>().ForMember(p => p.ImageFile, opt => opt.Ignore()).ReverseMap();

		}
	}
}
