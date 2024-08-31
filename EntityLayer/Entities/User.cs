using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class User
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Ad")]
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Soyad")]
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Mail Adresi")]
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		[EmailAddress(ErrorMessage = "Mail formatı şeklinde giriniz.")]
		public string EMail { get; set; }


		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Kullanıcı Adı")]
		[StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Şifre")]
		[StringLength(10, ErrorMessage = "En fazla 10 karakter olmalıdır.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[StringLength(10, ErrorMessage = "En fazla 10 karakter olmalıdır.")]
		public string Role { get; set; }
	}
}
