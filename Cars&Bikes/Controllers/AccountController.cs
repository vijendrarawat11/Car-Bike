using Cars_Bikes.Data;
using Google.Apis.Drive.v3.Data;
using Microsoft.AspNetCore.Mvc;
using Cars_Bikes.Models;

namespace Cars_Bikes.Controllers
{
    public class AccountController : Controller
    {
        private readonly TwoWheelerDB _context;

        public AccountController(TwoWheelerDB context)
        {
            _context = context;
        }
            [HttpPost]
            public IActionResult Login(string username)
            {
                if (!string.IsNullOrEmpty(username)) // Just checking if username is provided
                {
                    HttpContext.Session.SetString("Username", username);
                    return RedirectToAction("Dashboard", "Home"); // Redirect to a different page
                }

                ViewBag.Error = "Please enter a username!";
                return View();
            }

            public IActionResult Logout()
            {
                HttpContext.Session.Clear(); // Clear session when user logs out
                return RedirectToAction("Login");
            }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        //[HttpPost]
        //public ActionResult Login(string username, string password)
        //{
        //    if (Users.ContainsKey(username) && Users[username] == password)
        //    {
        //        Session["Username"] = username;
        //        return Json(new { success = true });
        //    }
        //    return Json(new { success = false, message = "Invalid username or password" });
        //}
        //public ActionResult Logout()
        //{
        //    Session.Clear();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
