using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Controllers
{
    public class BlogsController : Controller
    {
        private readonly TwoWheelerDB _context;
        public BlogsController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allBlogs = _context.Blogs.OrderByDescending(m => m.Date).Take(16).ToList();
            ViewBag.allBlogs = allBlogs;
            return View();
        }
        [Route("blogs/mg-car-discounts")]
        public IActionResult Aug272024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("MG Car Discounts");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Aug272024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/best-indian-cars-under-₹8-lakh-on-road-price-(2024)")]
        public IActionResult Sep232024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Best Indian Cars Under ₹8 Lakh On-Road Price (2024)");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Sep232024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/best-indian-cars-to-buy-under-₹10-lakh-on-road-price-(2024)")]
        public IActionResult Sep242024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Best Indian Cars to Buy Under ₹10 Lakh On-Road Price (2024)");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Sep242024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/here-are-the-best-indian-bikes-under-150cc-segments")]
        public IActionResult Oct222024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Here are the best Indian Bikes under 150cc segments.");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Oct222024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-longest-range-electric-scooters-in-india-for-2024")]
        public IActionResult Oct232024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Longest Range Electric Scooters in India for 2024");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Oct232024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/news-best-cars-under-₹11-lakh-in-india-specific-variants-Offering-great-value-in-2024")]
        public IActionResult Oct242024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("News: Best Cars Under ₹11 Lakh in India – Specific Variants Offering Great Value in 2024");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Oct242024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-best-selling-royal-enfield-bikes-in-india-(2024)")]
        public IActionResult Oct282024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Best-Selling Royal Enfield Bikes in India (2024)");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Oct282024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-adventure-bikes-for-indian-terrain:specifications-features-and-costs-in-india")]
        public IActionResult Nov12024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Adventure Bikes for Indian Terrain: Specifications, Features, and Costs in India");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov12024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-bikes-under-2-lakh-in-india-for-performance-style-and-value")]
        public IActionResult Nov82024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Bikes Under 2 Lakh in India for Performance, Style, and Value");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov82024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-five-selling-bikes-in-india-november-2024-overview")]
        public IActionResult Nov112024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top Five Selling Bikes in India: November 2024 Overview");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov112024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-affordable-car-variants-under-₹6-lakhs-in-india-value-for-money-choices")]
        public IActionResult Nov202024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top Affordable Car Variants Under ₹6 Lakhs in India: Value-for-Money Choices");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov202024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/discover-the-all-new-suzuki-alto-k10-small-car-big-possibilities")]
        public IActionResult Nov222024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Discover the All-New Suzuki Alto K10 – Small Car, Big Possibilities!");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov222024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/best-cars-under-₹7-lakhs-in-india-(2024)")]
        public IActionResult Nov252024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Best Cars Under ₹7 Lakhs in India (2024)");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov252024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-bikes-in-india-under-₹3-lakh-best-picks-for-2024")]
        public IActionResult Nov282024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top Bikes in India Under ₹3 Lakh: Best Picks for 2024");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Nov282024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-best-selling-bajaj-motorcycles-in-india")]
        public IActionResult Dec32024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Best-Selling Bajaj Motorcycles in India");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec32024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-sports-bikes-under-₹4-lakh-in-india-features-specs-and-prices")]
        public IActionResult Dec42024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Sports Bikes Under ₹4 Lakh in India: Features, Specs, and Prices");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec42024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/the-all-new-honda-amaze-a-perfect-blend-of-style-comfort-and-performance")]
        public IActionResult Dec42024BlogDetails2()
        {
            var blogsDetails = GetBlogDetails("The All-New Honda Amaze: A Perfect Blend of Style, Comfort, and Performance");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec42024BlogDetails2.cshtml", blogsDetails);
        }
        [Route("blogs/indias-top-5-most-expensive-motorcycles-a-luxury-on-two-wheels")]
        public IActionResult Dec62024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("India’s Top 5 Most Expensive Motorcycles: A Luxury on Two Wheels");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec62024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/electric-vs-petrol-two-wheelers-which-is-better-for-you")]
        public IActionResult Dec182024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Electric vs Petrol Two-Wheelers: Which is Better for You?");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec182024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-10-affordable-two-wheelers-under-₹1-lakh-in-india")]
        public IActionResult Dec202024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 10 Affordable Two-Wheelers Under ₹1 Lakh in India");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec202024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-five-cruiser-bikes-in-india-for-long-distance-riders")]
        public IActionResult Dec232024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top Five Cruiser Bikes in India for Long-Distance Riders");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec232024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-five-two-wheeler-electric-vehicles-under-2-lakh-in-india")]
        public IActionResult Dec252024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top Five Two Wheeler Electric Vehicles under 2 Lakh in India.");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec252024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/the-all-new-kia-syros-a-comprehensive-review")]
        public IActionResult Dec262024BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("The All-New Kia Syros: A Comprehensive Review");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2024/Dec262024BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/honda-qC1-electric-scooter-the-future-of-green-mobility")]
        public IActionResult Jan72025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Honda QC1 Electric Scooter: The Future of Green Mobility");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Jan72025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-10-two-wheeler-brands-for-commuters-in-2025")]
        public IActionResult Jan162025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 10 Two-Wheeler Brands for Commuters in 2025");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Jan162025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/toyota-taisor-vs-maruti-fronx-a-detailed-comparison")]
        public IActionResult Jan172025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Toyota Taisor vs Maruti Fronx: A Detailed Comparison");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Jan172025BlogDetails1.cshtml", blogsDetails);
        }


        [Route("blogs/hyundai-creta-ev-vs-maruti-suzuki-e-vitara-a-comprehensive-comparison")]
        public IActionResult Jan222025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Hyundai Creta EV vs. Maruti Suzuki e-Vitara: A Comprehensive Comparison");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Jan222025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/how-to-choose-the-best-two-wheeler-for-your-daily-commute")]
        public IActionResult Jan242025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("How to Choose the Best Two-Wheeler for Your Daily Commute");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Jan242025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-safety-tips-for-two-wheeler-riders")]
        public IActionResult Feb62025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top Safety Tips for Two-Wheeler Riders");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Feb62025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-two-wheeler-electric-vehicles-under-₹1-5-lakh-in-india")]
        public IActionResult Mar192025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Two-Wheeler Electric Vehicles Under ₹1.5 Lakh in India");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Mar192025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/top-5-electric-scooters-in-india-based-on-battery-capacity-&-highest-range-per-charge")]
        public IActionResult Mar202025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Top 5 Electric Scooters in India Based on Battery Capacity & Highest Range Per Charge");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Mar202025BlogDetails1.cshtml", blogsDetails);
        }

        [Route("blogs/best-5-electric-scooters-in-india-with-200-km-range")]
        public IActionResult Mar212025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Best 5 Electric Scooters in India With 200+ km Range");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Mar212025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/komaki-hi-speed-electric-scooters-best-models-&-prices")]
        public IActionResult Mar222025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("Komaki Hi-Speed Electric Scooters: Best Models & Prices");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Mar222025BlogDetails1.cshtml", blogsDetails);
        }
        [Route("blogs/the-10L-boosterjet-turbo-engine-the-heart-of-maruti-suzukis-sporty-side")]
        public IActionResult Apr142025BlogDetails1()
        {
            var blogsDetails = GetBlogDetails("The 1.0L Boosterjet Turbo Engine: The Heart of Maruti Suzuki’s Sporty Side");
            if (blogsDetails == null)
            {
                return NotFound(); // Return 404 if news item is not found
            }
            return View("~/Views/Blogs/2025/Apr142025BlogDetails1.cshtml", blogsDetails);
        }


        private Cars_Bikes.Models.Blogs GetBlogDetails(string blogsHeading)
        {
            var blogsItem = _context.Blogs
                .FirstOrDefault(n => n.BlogHeading == blogsHeading);
            if (blogsItem == null)
            {
                // Handle the case where the bike is not found
                return null;
            }
            //var newsItem = _context.TWLatestNews.Where(n => n.NewsHeading == newsHeading).ToList();
            //var allNews = _context.TWLatestNews.OrderByDescending(m => m.Date).Take(90).ToList();
            //ViewBag.AllNews = allNews;
            //var brand = _context.TwowheelerBrands.ToList();
            //ViewBag.Brand = brand;
            return blogsItem;
        }
    }
}
