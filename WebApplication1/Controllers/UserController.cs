using Microsoft.AspNetCore.Mvc;
using NuGet.Frameworks;
using WebApplication1.data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly applicationDbContext _db;
        public UserController(applicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User>allUser = _db.Users;
            return View(allUser);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {

            }
            _db.Users.Add(obj);
            _db.SaveChanges();  
            return RedirectToAction("Index");
        }
    }
}
