using Microsoft.AspNetCore.Mvc;
using OnlineBikeShop.Models;

namespace OnlineBikeShop.Controllers
{
    public class MakeController : Controller
    {
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Ted" };
            return View(make);
        }

        [Route("make/bikes/{month:int:length(4)}/{years:int:range(1,10)}")]
        public IActionResult ByYearsMonths(int year, int month)
        {
            return Content(month + ";" + year);
        }
    }
}
