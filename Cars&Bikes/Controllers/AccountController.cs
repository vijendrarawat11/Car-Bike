using Microsoft.AspNetCore.Mvc;

namespace Cars_Bikes.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>
        {
            { "user1", "password123" }
        };

        // Login Action
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
