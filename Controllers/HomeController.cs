using Microsoft.AspNetCore.Mvc;
//using WebApp.Data;
using guitars.Models;
using guitars.Data;

namespace guitars.Controllers
{

    public class HomeController : Controller
    {
        private AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        IQueryable<Product> Products { get; }

        public IActionResult Index()
        {
            var users = _db.Users;

            return View();
        }
        public IActionResult Fender()
        {
            var result = _db.Products;
            return View("Fender",result);
        }
        public IActionResult Gibson()
        {
            var result = _db.Products;
            return View(result);
        }
    }
}