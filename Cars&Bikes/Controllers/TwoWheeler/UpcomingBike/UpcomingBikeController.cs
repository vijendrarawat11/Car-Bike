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
        [Route("upcoming-bike/bsa-goldstar-650")]
        public IActionResult Aug2024UpcomingBikeDetails1()
        {
            var upcomingDetails = GetUpcomingBikeDetails("BSA GoldStar 650");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Aug2024UpcomingBikeDetails1.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/triumph-daytona-660")]
        public IActionResult Aug2024UpcomingBikeDetails2()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Triumph Daytona 660");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Aug2024UpcomingBikeDetails2.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/yezdi-streetfighter")]
        public IActionResult Aug2024UpcomingBikeDetails3()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Yezdi Streetfighter");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Aug2024UpcomingBikeDetails3.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/yezdi-roadking")]
        public IActionResult Aug2024UpcomingBikeDetails4()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Yezdi Roadking");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Aug2024UpcomingBikeDetails4.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/husqvarna-vitpilen-401")]
        public IActionResult Sep2024UpcomingBikeDetails1()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Husqvarna Vitpilen 401");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Sep2024UpcomingBikeDetails1.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/suzuki-gsx-8r")]
        public IActionResult Sep2024UpcomingBikeDetails2()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Suzuki GSX-8R");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Sep2024UpcomingBikeDetails2.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/bmw-f900-gs")]
        public IActionResult Sep2024UpcomingBikeDetails3()
        {
            var upcomingDetails = GetUpcomingBikeDetails("BMW F900 GS");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Sep2024UpcomingBikeDetails3.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/kawasaki-versys-x-300")]
        public IActionResult Sep2024UpcomingBikeDetails4()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Kawasaki Versys-X 300");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Sep2024UpcomingBikeDetails4.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/suzuki-burgman-street-electric")]
        public IActionResult Sep2024UpcomingBikeDetails5()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Suzuki Burgman Street Electric");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Sep2024UpcomingBikeDetails5.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/yamaha-nmax-155")]
        public IActionResult Sep2024UpcomingBikeDetails6()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Yamaha Nmax 155");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Sep2024UpcomingBikeDetails6.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/hero-xoom-160")]
        public IActionResult Nov2024UpcomingBikeDetails1()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Hero Xoom 160");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Nov2024UpcomingBikeDetails1.cshtml", upcomingDetails);
        }
        [Route("upcoming-bike/oben-rorr-ez")]
        public IActionResult Nov2024UpcomingBikeDetails2()
        {
            var upcomingDetails = GetUpcomingBikeDetails("Oben Rorr EZ");
            if (upcomingDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/UpcomingBike/2024/Nov2024UpcomingBikeDetails2.cshtml", upcomingDetails);
        }
        private Cars_Bikes.Models.UpcomingBike GetUpcomingBikeDetails(string upcomingBikeName)
        {
            var upcomingItem = _context.UpcomingBikes
                .FirstOrDefault(n => n.UpcomingBikeName == upcomingBikeName);
            if (upcomingItem == null)
            {
                // Handle the case where the bike is not found
                return null;
            }
            var allupcomingbike = _context.UpcomingBikes.OrderByDescending(m => m.FilterLaunchDate).Take(8).ToList();
            ViewBag.allupcomingbike = allupcomingbike;
            return upcomingItem;
        }
    }
}
