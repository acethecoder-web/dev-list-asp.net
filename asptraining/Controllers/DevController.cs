using asptraining.Data;
using asptraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace asptraining.Controllers
{
    public class DevController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DevController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Developer> devs = _db.Developer.ToList();

            return View(devs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Developer devobject)
        {
            if (devobject != null && devobject.DevFirstName.Length < 3)
            {
                ModelState.AddModelError("DevFirstName", "Firstname too short");
            }

            if (devobject != null && devobject.DevMiddleName.Length < 3)
            {
                ModelState.AddModelError("DevMiddleName", "Middlename too short");
            }

            if (devobject != null && devobject.DevLastName.Length < 3)
            {
                ModelState.AddModelError("DevLastName", "Lastname too short");
            }

            if (ModelState.IsValid)
            {
                devobject.IsActive = true;
                _db.Developer.Add(devobject);
                _db.SaveChanges();

            }

            return RedirectToAction("Index");
        }
    }
}
