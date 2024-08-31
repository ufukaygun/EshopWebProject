using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Entities;
using EShopWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShopWebUI.Controllers
{
    public class AdminCategoryController : Controller
	{
		private readonly ICategoryService _categoryService ;
        private readonly IMapper _mapper;

        public AdminCategoryController(ICategoryService categoryService, IMapper mapper )
		{
            _categoryService = categoryService;
			_mapper = mapper;
        }
		public IActionResult Index()
		{
			return View(_mapper.Map<List<CategoryModel>>(_categoryService.GetAll()));
		}

		public IActionResult Create()
		{
			return View();
		}

		//ValidateAntiForgeryToken kullanıcı sisteme girdiği zaman URL den ekleme isteiğini kapatmış oluyoruz.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(CategoryModel categoryModel)
		{
			_categoryService.Create(_mapper.Map<Category>(categoryModel));
			return RedirectToAction("Index");

		}

		public IActionResult Delete(int id)
		{
			_categoryService.Delete(id);
			return RedirectToAction("Index");
		}


		public IActionResult Update(int id)
		{
			return View(_mapper.Map<CategoryModel>(_categoryService.Get(id)));
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(CategoryModel categoryModel)
		{
			if (ModelState.IsValid)
			{
				_categoryService.Update(_mapper.Map<Category>(categoryModel));
				return RedirectToAction("Index");
			}
			return RedirectToAction("Index");
		}
		
	}
}
