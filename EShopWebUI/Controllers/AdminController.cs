using Microsoft.AspNetCore.Mvc;

namespace EShopWebUI.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
