using EntityLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EShopWebUI.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
