using Microsoft.AspNetCore.Mvc;
using guitars.Models;
using guitars.Data;
using Microsoft.AspNetCore.Authorization;

namespace guitars.Controllers
{

    public class LoginController : Controller
    {

        private AppDbContext _db;

        public LoginController(AppDbContext db)
        {
            _db = db;
        }
        public IQueryable<User> Users => _db.Users;

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
           
            if (user.Email=="hilal.ozhan@icloud.com" && user.Password =="123456")
            {
                return View("Views/Product/Create.cshtml");
            }
            else
                return View("Index");
        }
    }
}
