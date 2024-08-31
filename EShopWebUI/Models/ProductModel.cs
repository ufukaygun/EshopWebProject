using EntityLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EShopWebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool Popular { get; set; }
        public bool IsApproved { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
		public int CategoryId { get; set; }
      
    }
}
