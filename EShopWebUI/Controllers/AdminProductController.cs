using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using EShopWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShopWebUI.Controllers
{
	public class AdminProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public AdminProductController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //return View(_productRepository.GetAll().ToPagedList(sayfa,4));
            //return View(_dataContext.Products.Include(x => x.Category).ToList());
            var product = _mapper.Map<List<ProductModel>>(_productService.GetAll());

			return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
			IEnumerable<SelectListItem> selectListItems = _categoryService.GetAll().Select(category => new SelectListItem
			{
				Value = category.Id.ToString(), // Dropdown'da seçildiğinde geri dönecek değer
				Text = category.Name // Dropdown'da görünecek metin
			}).ToList();

			// Kategori listesini ViewBag veya ViewData ile View'a gönder
			ViewBag.CategoryId = selectListItems;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel productModel)
        {
            if (productModel != null && productModel.Id == 0)
            {

                // Resim dosyası yükleme işlemi
                if (productModel.ImageFile != null && productModel.ImageFile.Length > 0)
                {
                    var fileName = Path.GetFileName(productModel.ImageFile.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\NiceAdmin\\ProductImage", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await productModel.ImageFile.CopyToAsync(stream);
                    }

                    var product = _mapper.Map<Product>(productModel);
                    product.Image = fileName;
                    _productService.Create(product);
                }

            }

            // Başarılıysa Index sayfasına yönlendir
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
			IEnumerable<SelectListItem> selectListItems = _categoryService.GetAll().Select(category => new SelectListItem
			{
				Value = category.Id.ToString(), // Dropdown'da seçildiğinde geri dönecek değer
				Text = category.Name // Dropdown'da görünecek metin
			}).ToList();

			// Kategori listesini ViewBag veya ViewData ile View'a gönder
			ViewBag.CategoryId = selectListItems;
            var product = _mapper.Map<ProductModel>(_productService.Get(id));

			return View(product);
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ProductModel productModel)
        {

            // Eğer update null ise hata mesajı ile geri dönün
            if (productModel == null)
            {
                ModelState.AddModelError("", "Ürün bulunamadı.");
                return View(productModel);
            }
            else
            {
                _productService.Update(_mapper.Map<Product>(productModel));
                
                return RedirectToAction("Index");
            }

        }
    }
}
