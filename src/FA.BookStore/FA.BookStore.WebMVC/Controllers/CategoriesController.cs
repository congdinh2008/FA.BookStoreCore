using FA.BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FA.BookStore.WebMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryServices _categoryServices;

        public CategoriesController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var category = await _categoryServices.GetByIdAsync(id);
            return View(category);
        }
    }
}
