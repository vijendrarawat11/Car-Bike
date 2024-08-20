using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cars_Bikes.Controllers.TwoWheeler.LatestNews
{
    public class LatestNewsController : Controller
    {
        private readonly TwoWheelerDB _context;
        public LatestNewsController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[Route("latest-news/bajaj-pulsar-ns200")]
        public IActionResult TWLatestNewsDetails(int id)
        {
            var newsItem = _context.TWLatestNews.FirstOrDefault(m => m.TWLatestNewsId == id);
            if (newsItem == null)
            {
                return NotFound();
            }
            ViewBag.TWNews = newsItem;
            var allNews = _context.TWLatestNews.OrderByDescending(m => m.Date).Take(10).ToList();
            ViewBag.AllNews = allNews;
            var brand = _context.TwowheelerBrands.ToList();
            ViewBag.Brand = brand;
            return View("~/Views/TwoWheeler/LatestNews/TWLatestNewsDetails.cshtml");
        }
        public IActionResult TWLatestNewsByBrand(int id)
        {
            var newsbybrand = _context.TWLatestNews.Where(m => m.TwoWBrandId == id).ToList();
            ViewBag.newsbybrand = newsbybrand;
            return View("~/Views/TwoWheeler/LatestNews/TWLatestNewsByBrand.cshtml");
        }
    }
}
