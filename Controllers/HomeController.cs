using AppWeb.Data;
using AppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //create DbContext variable
        private readonly ProductsContext _context;

        public HomeController(ILogger<HomeController> logger, ProductsContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
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
