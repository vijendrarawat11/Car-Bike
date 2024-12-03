﻿using Cars_Bikes.Data;
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
            var allNews = _context.TWLatestNews.OrderByDescending(m => m.Date).Take(90).ToList();
            ViewBag.AllNews = allNews;
            var brand = _context.TwowheelerBrands.ToList();
            ViewBag.Brand = brand;
            return blogsItem;
        }
    }
}