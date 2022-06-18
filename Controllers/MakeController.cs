using Microsoft.AspNetCore.Mvc;
using OnlineBikeShop.AppDbContext;
using OnlineBikeShop.Models;

namespace OnlineBikeShop.Controllers
{
    public class MakeController : Controller
    {
        private readonly BikeDbContext _db;

        public MakeController(BikeDbContext db)
        {
                _db= db;
        }
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Ted" };
            return View(make);
        }

        public IActionResult Index()
        {
            IEnumerable<Make> makes = _db.Makes;
            return View(makes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(make);
        }

        [HttpPost]
        public IActionResult Delete (int? id)
        {
            var make = _db.Makes.Find(id);
            if(make== null)
            {
                return NotFound();
            }
            _db.Makes.Remove(make);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("make/bikes/{month:int:length(4)}/{years:int:range(1,10)}")]
        public IActionResult ByYearsMonths(int year, int month)
        {
            return Content(month + ";" + year);
        }
    }
}
