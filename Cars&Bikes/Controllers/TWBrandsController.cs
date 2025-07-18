using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Cars_Bikes.Models;
using Cars_Bikes.Data;
using System.Diagnostics;
namespace Cars_Bikes.Controllers
{
    public class TWBrandsController : Controller
    {
        private readonly TwoWheelerDB _context;
        public TWBrandsController(TwoWheelerDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        // Show the form
        public IActionResult Create()
        {
            return View();
        }

        // Handle the form POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TwoWheelerBrand brand)
        {
            Debug.WriteLine("Saving data");
            foreach (var state in ModelState)
            {
                if (state.Value.Errors.Count > 0)
                {
                    Debug.WriteLine($"Field: {state.Key} — Error: {state.Value.Errors[0].ErrorMessage}");
                }
            }

            if (ModelState.IsValid)
            {
                Debug.WriteLine("Saving context and date");
                brand.CreatedDateTime = DateTime.Now; // Save creation time
                Debug.WriteLine("Saving date");
                _context.TwowheelerBrands.Add(brand);
                Debug.WriteLine("Saving brand");
                _context.SaveChanges();
                Debug.WriteLine("Saving to datbase");
                return RedirectToAction("Success"); // Redirect after success
            }
            Debug.WriteLine("Saving data failed ");
            return View(brand);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
