using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Product
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Açıklama")]
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		public string Description { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Fiyat")]
		public decimal Price { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Stok")]
		public int Stock { get; set; }

		[Display(Name = "Popüler")]
		public bool Popular { get; set; }

		[Display(Name = "Onay")]
		public bool IsApproved { get; set; }

		[Display(Name = "Görsel")]
		public string Image { get; set; }

		[Display(Name = "Kategori")]
		public int CategoryId { get; set; }
		//Bir ürünün bir kategorisi olabilir
		public virtual Category Category { get; set; }


	}
}
