using Cars_Bikes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Google.Apis.Drive.v3;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cars_Bikes.Data;
using System.Xml.Linq;
using System.Linq;

namespace Cars_Bikes.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly BrandDB _context;
        private readonly FourWheelerBrandDB _fourwheeler;

        public HomeController(ILogger<HomeController> logger, BrandDB context, FourWheelerBrandDB fourWheeler)
        {
            _logger = logger;
            _context = context;
            _fourwheeler = fourWheeler;
        }
        //BrandDB _context;
        //public HomeController(BrandDB context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            var TWList = _context.TwowheelerBrands.ToList();
            ViewBag.TWLists = new SelectList(TWList, "TWBrandId", "BrandName");
            var MList = _context.Twowheelers.Select(t => t.Type)
                                            .Distinct().ToList();
            ViewBag.Mlists = new SelectList(MList);
            //var TWName = _twowheeler.TwoWheelers.ToList();
            //ViewBag.TWNames = new SelectList(TWName,"Id", "TwoWheelerName");
            //var Models = new List<TwoWheeler>();
            //ViewBag.ModelNames = new SelectList(Models, "Company", "TwoWheelerName");
            var FourWheelerBrand = _fourwheeler.FourWheelerBrands.ToList();
            ViewBag.FourwheelerName = new SelectList(FourWheelerBrand, "Id", "FourWheelerBrandName");
            
            return View();
        }
        [HttpGet]
        //public JsonResult GetModelsByBrand(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return Json(new { success = false, message = "Invalid brand ID" });
        //    }

        //    var models = _context.Twowheelers
        //        .Where(u => u.TwoWBrandId == id)
        //        .Select(u => new
        //        {
        //            u.TwoWheelerId,
        //            u.TwoWheelerName
        //        })
        //        .ToList();

        //    if (models == null || !models.Any())
        //    {
        //        return Json(new { success = false, message = "No models found for this brand" });
        //    }

        //    return Json(new { success = true, data = models });
        //}
        public JsonResult GetModelsByBrand(int Id)
        {
            var ListModel = _context.Twowheelers.Where(u => u.TwoWBrandId == Id).Select(u => new
            {
                u.TwoWheelerId,
                u.TwoWheelerName
            }).ToList();
            return Json(ListModel);
        }
        //public JsonResult GetModelsByBrand(int Id)
        //{
        //    return Json(_context.Twowheelers.Where(u => u.TwoWheelerBrand == Id).ToList());
        //}
        //public JsonResult GetModelsByBrand(string brandName)
        //{
        //    var models = _twowheeler.TwoWheelers.Where(u => u.Company == brandName).ToList();
        //    return Json(models);
        //}
        //[HttpGet]
        //public JsonResult GetModelsByBrand(string brandName)
        //{
        //    var models = _twowheeler.TwoWheelers
        //                            .Where(t => t.Company == brandName)
        //                            .Select(t => new { t.Id, t.TwoWheelerName })
        //                            .ToList();
        //    return Json(models);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}