using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cars_Bikes.Controllers
{
    public class TwoWheelerController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }
    }
}
