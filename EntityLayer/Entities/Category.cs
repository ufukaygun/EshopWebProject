using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Category
	{
		//Validationlar oluşturuldu
		public int Id { get; set; }

		//Required zorunlu olsun.Boş geçilemez demek yani
		[Required(ErrorMessage = "Boş Geçilemez")]
		//Display kullanıcıya Prop isminin isteidğimiz şekilde gözükmesi için
		[Display(Name = "Ad")]
		//StringLength alan sınırlandrmak için
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Açıklama")]
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		public string Description { get; set; }

		//bir kategoride birden fazla ürün olabilir
		public virtual List<Product> Products { get; set; }
	}
}
