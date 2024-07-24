using Microsoft.AspNetCore.Mvc;

namespace Cars_Bikes.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
