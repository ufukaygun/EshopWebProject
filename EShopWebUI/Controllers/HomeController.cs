using AutoMapper;
using BusinessLayer.Abstract;
using EShopWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShopWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public HomeController(IProductService productService, ICategoryService categoryService, IMapper mapper)
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
    }
}
