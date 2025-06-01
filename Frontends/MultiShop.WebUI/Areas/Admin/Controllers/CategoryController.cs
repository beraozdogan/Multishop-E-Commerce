using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/Category")]
	public class CategoryController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly ICategoryService _categoryService;

		public CategoryController(IHttpClientFactory httpClientFactory, ICategoryService categoryService)
		{
			_httpClientFactory = httpClientFactory;
			_categoryService = categoryService;
		}

		[Route("Index")]
		public async Task<IActionResult> Index()
		{
			CategoryViewbagList();

			var values = await _categoryService.GetAllCategoryAsync();
			return View(values);

		}

		[HttpGet]
		[Route("CreateCategory")]
		public IActionResult CreateCategory()
		{
			CategoryViewbagList();

			return View();
		}
		[HttpPost]
		[Route("CreateCategory")]
		public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
		{
			await _categoryService.CreateCategoryAsync(createCategoryDto);
			return RedirectToAction("Index", "Category", new { area = "Admin" });
		}

		[Route("DeleteCategory/{id}")]
		public async Task<IActionResult> DeleteCategory(string id)
		{
			await _categoryService.DeleteCategoryAsync(id);
			return RedirectToAction("Index", "Category", new { area = "Admin" });

		}

		[Route("UpdateCategory/{id}")]
		[HttpGet]
		public async Task<IActionResult> UpdateCategory(string id)
		{
			CategoryViewbagList();
			var values = await _categoryService.GetByIdCategoryAsync(id);
			return View(values);
		}
		[Route("UpdateCategory/{id}")]
		[HttpPost]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateCategoryDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json"); ;
			var responseMessage = await client.PutAsync("https://localhost:7070/api/Categories/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Category", new { area = "Admin" });
			}
			return View();
		}

		void CategoryViewbagList()
		{
			ViewBag.v1 = "Ana Sayfa";
			ViewBag.v2 = "Kategoriler";
			ViewBag.v3 = "Kategori Listesi";
			ViewBag.v0 = "Kategori İşlemleri";
		}
	}
}
