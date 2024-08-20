using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Controllers.TwoWheeler.UpcomingBike
{
    public class UpcomingBikeController : Controller
    {
        private readonly TwoWheelerDB _context;
        public UpcomingBikeController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TWUpcomingBikeDetails(int id)
        {
            var upcomingbike = _context.UpcomingBikes.Where(m => m.UpcomingBikeId == id).ToList();
            ViewBag.upcomingbike = upcomingbike;
            var allupcomingbike = _context.UpcomingBikes.OrderByDescending(m => m.FilterLaunchDate).Take(8).ToList();
            ViewBag.allupcomingbike = allupcomingbike;
            return View("~/Views/TwoWheeler/UpcomingBike/TWUpcomingBikeDetails.cshtml");
        }
    }
}
