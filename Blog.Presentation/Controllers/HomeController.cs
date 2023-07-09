using Blog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Blog.Services.Services;

namespace Blog.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected readonly BlogService BlogServices;

        public HomeController(ILogger<HomeController> logger,BlogService blogService)
        {
            _logger = logger;
            BlogServices = blogService;
        }

        public IActionResult Index()
        {
            return View();
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