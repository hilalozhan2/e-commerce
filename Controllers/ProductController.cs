using Microsoft.AspNetCore.Mvc;
using guitars.Models;
using guitars.Data;

namespace guitars.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(AppDbContext _context)
        {
            _productRepository = new ProductRepository(_context);
        }
        

        public IActionResult Index()
        {
            var result = _productRepository.Products;
            return View(result);
        }

        public IActionResult ElectroGuitars()
        {
            var result = _productRepository.Products;
            return View(result);
        }
        public IActionResult BassGuitars()
        {
            var result = _productRepository.Products;
            return View(result);
        }
        public IActionResult ClassicallGuitars()
        {
            var result = _productRepository.Products;
            return View(result);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            _productRepository.CreateProduct(p);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Product p)
        {
            _productRepository.UpdateProduct(p);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Product p)
        {
            _productRepository.DeleteProduct(p);
            // Redirect the user to the product list page
            return RedirectToAction("Index");

        }
    }
}
