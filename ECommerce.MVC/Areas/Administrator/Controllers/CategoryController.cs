using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        //todo:Icategoryservice içerisinde bulunan GetActiveCategories isimli metot tarafından iletilen veriler index sayfasında gösterilecek.

        public CategoryController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories=_categoryService.GetActiveCategories().OrderByDescending(x=>x.CreatedDate).Select(x=>new CategoryListViewModel
            {
                Id=x.ID,
                CategoryName=x.CategoryName,
                Description=x.Description,
                IsActive=x.IsActive,
                Status=x.Status
            }).ToList();

            return View(categories);
        }

        //create

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {
            if(ModelState.IsValid)
            {
                Category category = new Category()
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };
              string result= await _categoryService.CreateCategory(category);
                TempData["Result"] = result;
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View(categoryViewModel);
            }
            
        }
        //update
        //Get: Update Category
        [HttpGet]
        public IActionResult Update(int id)
        {
            var updated = _categoryService.GetCategoryById(id);

            if (updated != null)
            {
                return View(updated);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        //Post: Update Category
        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            string result = await _categoryService.UpdateCategory(category);

            TempData["result"] = result;

            return RedirectToAction("Index", "Category");

        }


        //delete
        //deatails: bu işlemi en sona bıraktık
        //destroy
        //getpassiveCategories
    }
}
