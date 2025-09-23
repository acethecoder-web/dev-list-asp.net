using asptraining.Data;
using asptraining.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
