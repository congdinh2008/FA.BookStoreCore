using FA.BookStore.Services;
using FA.BookStore.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FA.BookStore.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryServices _categoryServices;

        public HomeController(
            ILogger<HomeController> logger,
            ICategoryServices categoryServices
            )
        {
            _logger = logger;
            _categoryServices = categoryServices;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryServices.GetAllAsync();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
