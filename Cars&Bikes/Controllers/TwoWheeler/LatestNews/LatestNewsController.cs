using Cars_Bikes.Data;
using Cars_Bikes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult TWLatestNewsDetails(int id, string heading)
        {
            var newsItem = _context.TWLatestNews.FirstOrDefault(m => m.ImageURL == heading);
            if (newsItem == null)
            {
                return NotFound();
            }
            ViewBag.TWNews = newsItem;
            var allNews = _context.TWLatestNews.OrderByDescending(m => m.Date).Take(15).ToList();
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
        //Single page for News
        [Route("latestnews/bajaj-freedom-125-cng")]
        public IActionResult Aug122024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Bajaj Freedom 125 CNG");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug122024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/new-royal-enfield-classic-350:price-expectation")]
        public IActionResult Aug122024NewsDetails2()
        {
            var newsDetails = GetNewsDetails("New Royal Enfield Classic 350: Price Expectation");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug122024NewsDetails2.cshtml", newsDetails);
        }
        [Route("latestnews/tata-curvv:upcoming-suv-coupe-set-to-shake-up-indian-auto-market")]
        public IActionResult Aug252024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Tata Curvv: Upcoming SUV Coupe Set to Shake Up Indian Auto Market");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug252024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/thar-roXX:new-variant-joins-the-iconic-Off-roader-lineup")]
        public IActionResult Aug252024NewsDetails2()
        {
            var newsDetails = GetNewsDetails("Thar RoXX: New Variant Joins the Iconic Off-Roader Lineup");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug252024NewsDetails2.cshtml", newsDetails);
        }
        [Route("latestnews/ola-electric-unveils-roadster:a-new-era-of-high-performance-electric-motorcycles")]
        public IActionResult Aug262024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Ola Electric Unveils Roadster: A New Era of High-Performance Electric Motorcycles");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug262024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/ola-electric-introduces-roadsterX:affordable-electric-motorcycle-with-impressive-range")]
        public IActionResult Aug262024NewsDetails2()
        {
            var newsDetails = GetNewsDetails("Ola Electric Introduces Roadster X: Affordable Electric Motorcycle with Impressive Range");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug262024NewsDetails2.cshtml", newsDetails);
        }
        [Route("latestnews/mg-car-discounts")]
        public IActionResult Aug272024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("MG Car Discounts");
            //if (newsDetails == null)
            //{
            //    return NotFound(); // Return 404 if news item is not found
            //}
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug272024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/honda-unveils-affordable-shine:125-a-budget-friendly-commuter-under-₹1-lakh")]
        public IActionResult Aug282024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Honda Unveils Affordable Shine 125: A Budget-Friendly Commuter Under ₹1 Lakh");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found

            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug282024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/bajaj-introduces-two-affordable-bikes-under-₹1-lakh:platina-110-and-pulsar-125")]
        public IActionResult Aug292024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Bajaj Introduces Two Affordable Bikes Under ₹1 Lakh: Platina 110 and Pulsar 125");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found

            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug292024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/maserati-granTurismo-makes-its-debut-in-india-with-prices-starting-at-rs-2.72-crore")]
        public IActionResult Aug302024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Maserati GranTurismo Makes Its Debut in India with Prices Starting at Rs 2.72 Crore");
            if (newsDetails == null)
            {
                //return NotFound(); // Return 404 if news item is not found
                return RedirectToAction("Index", "Home");

            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Aug/Aug302024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/royal-enfield-classic-350-gets-a-fresh-update:new-model-launched-at-₹2-lakh")]
        public IActionResult Sep22024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Royal Enfield Classic 350 Gets a Fresh Update: New Model Launched at ₹2 Lakh");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep22024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/tata-motors-unveils-top-10-features-of-the-all-new-tata-curvv-2024")]
        public IActionResult Sep32024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Tata Motors Unveils Top 10 Features of the All-New Tata Curvv 2024");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep32024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/tvs-bajaj-and-hero-lead-august-sales-surpassing-ola-and-ather-in-august-month")]
        public IActionResult Sep32024NewsDetails2()
        {
            var newsDetails = GetNewsDetails("TVS, Bajaj, and Hero Lead August Sales, Surpassing Ola and Ather in August month");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep32024NewsDetails2.cshtml", newsDetails);
        }
        [Route("latestnews/jawa-42-fj-debuts-at-₹1.99-lakh:new-model-launched")]
        public IActionResult Sep52024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Jawa 42 FJ Debuts at ₹1.99 Lakh: New Model Launched");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep52024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/bajaj-freedom-125-achieves-5,000-sales-milestone-within-two-months-of-launch")]
        public IActionResult Sep62024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Bajaj Freedom 125 Achieves 5,000 Sales Milestone Within Two Months of Launch");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep62024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/hyundai-exter-s(o)-and-s-amt-introduced-in-india-with-new-sunroof-feature")]
        public IActionResult Sep92024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Hyundai Exter S(O)+ and S+ AMT Introduced in India with New Sunroof Feature");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep92024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/government-to-launch-fame-iii-scheme-to-further-boost-electric-mobility-initiatives")]
        public IActionResult Sep102024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Government to Launch FAME III Scheme to Further Boost Electric Mobility Initiatives");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep102024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/mg-windsor-ev-launches-in-india-today:key-features-and-expectations")]
        public IActionResult Sep112024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("MG Windsor EV Launches in India Today: Key Features and Expectations");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep112024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/demerits-of-the-hyundai-alcazar:a-closer-look-at-its-shortcomings")]
        public IActionResult Sep122024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Demerits of the Hyundai Alcazar: A Closer Look at Its Shortcomings");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep122024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/honda-set-to-launch-electric-scooter-in-india-by-march-2025")]
        public IActionResult Sep132024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Honda Set to Launch Electric Scooter in India by March 2025");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep132024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/jsw-mg-launches-mg-select-outlets-for-premium-vehicles-starting-2025")]
        public IActionResult Sep162024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("JSW MG Launches 'MG Select' Outlets for Premium Vehicles Starting 2025");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep162024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/kia-crnival-lunches-with-1,800-frst-day-bokings")]
        public IActionResult Sep182024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Kia Carnival Launches with 1,800+ First-Day Bookings");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep182024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/byd-emax-7-electric-mpv-set-to-launch-in-india-on-october-8")]
        public IActionResult Sep192024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("BYD eMAX 7 Electric MPV Set to Launch in India on October 8");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep192024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/tvs-unveils-new-variants-of-apache-rr-310:-a-fresh-take-on-performance-and-style")]
        public IActionResult Sep232024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("TVS Unveils New Variants of Apache RR 310: A Fresh Take on Performance and Style");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep232024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/best-indian-cars-under-₹8-lakh-on-road-price-(2024)")]
        public IActionResult Sep232024NewsDetails2()
        {
            var newsDetails = GetNewsDetails("Best Indian Cars Under ₹8 Lakh On-Road Price (2024)");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep232024NewsDetails2.cshtml", newsDetails);
        }
        [Route("latestnews/best-indian-cars-to-buy-under-₹8-lakh-on-road-price-(2024)")]
        public IActionResult Sep242024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Best Indian Cars to Buy Under ₹10 Lakh On-Road Price (2024)");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep242024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/tata-nexon-icng-debuts-in-india-at-₹8.99-lakh-promising-24-km/kg-mileage")]
        public IActionResult Sep252024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Tata Nexon iCNG Debuts in India at ₹8.99 Lakh, Promising 24 km/kg Mileage");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep252024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/top-5-indian-bikes-in-the-250cc-segment:-prices-specifications-&-features")]
        public IActionResult Sep262024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Top 5 Indian Bikes in the 250cc Segment: Prices, Specifications & Features");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep262024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/skoda-set-to-launch-elroq-electric-suv-on-october-1")]
        public IActionResult Sep272024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Skoda Set to Launch Elroq Electric SUV on October 1");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep272024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/2025-triumph-scrambler-400-x-set-to-debut-in-india-soon")]
        public IActionResult Sep302024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("2025 Triumph Scrambler 400 X Set to Debut in India Soon");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Sep/Sep302024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/bmw-m4-cs-set-to-launch-in-india-on-october-4")]
        public IActionResult Oct12024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("BMW M4 CS Set to Launch in India on October 4");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Oct/Oct12024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/bmw-set-to-unveil-all-new-x3-at-bharat-mobility-global-expo-2025")]
        public IActionResult Oct22024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("BMW Set to Unveil All-New X3 at Bharat Mobility Global Expo 2025");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Oct/Oct22024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/zelio-launches-eeva-zx-electric-scooter-in-india")]
        public IActionResult Oct32024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Zelio Launches Eeva ZX+ Electric Scooter in India");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Oct/Oct32024NewsDetails1.cshtml", newsDetails);
        }
        [Route("latestnews/suzuki-unveils-gsx-8r-in-india-priced-at-₹9.25-lakh")]
        public IActionResult Oct42024NewsDetails1()
        {
            var newsDetails = GetNewsDetails("Suzuki Unveils GSX-8R in India Priced at ₹9.25 Lakh");
            if (newsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/TwoWheeler/LatestNews/2024/Oct/Oct42024NewsDetails1.cshtml", newsDetails);
        }
        private Cars_Bikes.Models.TWLatestNews GetNewsDetails(string newsHeading)
        {
            var newsItem = _context.TWLatestNews
                .FirstOrDefault(n => n.NewsHeading == newsHeading);
            if (newsItem == null)
            {
                // Handle the case where the bike is not found
                return null;
            }
            //var newsItem = _context.TWLatestNews.Where(n => n.NewsHeading == newsHeading).ToList();
            var allNews = _context.TWLatestNews.OrderByDescending(m => m.Date).Take(15).ToList();
            ViewBag.AllNews = allNews;
            var brand = _context.TwowheelerBrands.ToList();
            ViewBag.Brand = brand;
            return newsItem;
        }
    }
}
