using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cars_Bikes.Controllers
{
    public class ValueForMoneyController : Controller
    {
        private readonly TwoWheelerDB _context;
        public ValueForMoneyController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("value-for-money/skoda-kylaq-value-for-money-variant")]
        public IActionResult SkodaKylaq1()
        {
            var vfmDetails = GetVFMDetails("Skoda Kylaq");
            if (vfmDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View(vfmDetails);
        }
        [Route("skoda-kylaq-features-and-specifications")]
        public IActionResult SkodaKylaq2()
        {
            var vfmDetails = GetVFMDetails("Skoda Kylaq");
            if (vfmDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View(vfmDetails);
        }
        [Route("value-for-money/alto-k10-value-for-money-varient")]
        public IActionResult AltoK10_1()
        {
            var vfmDetails = GetVFMDetails("Alto K10: Value for Money Varient");
            if (vfmDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View(vfmDetails);
        }
        [Route("alto-k10-features-and-specifications")]
        public IActionResult AltoK10_2()
        {
            var vfmDetails = GetVFMDetails("Alto K10: Value for Money Varient");
            if (vfmDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View(vfmDetails);
        }
        private Cars_Bikes.Models.ValueForMoney GetVFMDetails(string vfmHeading)
        {
            var vfmItem = _context.ValueForMoney
                .FirstOrDefault(n => n.VFMHeading == vfmHeading);
            if (vfmItem == null)
            {
                // Handle the case where the bike is not found
                return null;
            }
            return vfmItem;
        }
    }
}
