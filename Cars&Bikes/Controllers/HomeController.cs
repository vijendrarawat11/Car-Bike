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
            var TWNews = _context.TWLatestNews.OrderByDescending(m => m.TWLatestNewsId).Take(5).ToList();
            ViewBag.TWNews = TWNews;
            //var FWNews = _fourwheeler.FWLatestNews.OrderByDescending(m => m.FWLatestNewsId).Take(5).ToList();
            //ViewBag.FWNews = FWNews;
            var UpcomingBike = _context.UpcomingBikes.ToList();
            ViewBag.Upcomingbike = UpcomingBike;


            return View();
        }
        public IActionResult TWLatestNewsDetails(int id)
        {
            var newsItem = _context.TWLatestNews.FirstOrDefault(m => m.TWLatestNewsId == id);
            if (newsItem == null)
            {
                return NotFound();
            }
            ViewBag.TWNews = newsItem;
            var allNews = _context.TWLatestNews.OrderByDescending(m => m.TWLatestNewsId).Take(10).ToList();
            ViewBag.AllNews = allNews;
            return View();
        }
        [HttpGet]
        public JsonResult GetModelsByBrand(int Id)
        {
            var ListModel = _context.Twowheelers.Where(u => u.TwoWBrandId == Id).Select(u => new
            {
                u.TwoWheelerId,
                u.TwoWheelerName
            }).ToList();
            return Json(ListModel);
        }
        public IActionResult TWBrandDetails(int brandId)
        {
            var brand = _context.Twowheelers
                                .Where(b => b.TwoWheelerBrands.TWBrandId == brandId)
                                //.FirstOrDefault();
                                .ToList();
            return View("TWBrandDetails",brand);
        }
        [HttpGet]
        public JsonResult GetTWSpecByVarient(int varientId)
        {
            var twSpecs = _context.TWSpec
                .Where(t => t.TWVarientId == varientId)
                .Select(t => new
                {
                    t.TWName,
                    t.Varients,
                    t.Milage,
                    t.FrontBrake,
                    t.RearBrake,
                    t.FuelCapacity,
                    t.BodyType
                }).ToList();

            return Json(twSpecs);
        }
        public ActionResult TwoWheelerDetails(int brandId, int modelId,int varientId)
        {
            //Item1
            var twoWheelers = _context.Twowheelers
                                      .Where(t => t.TwoWheelerBrands.TWBrandId == brandId && t.TwoWheelerId == modelId)
                                      .ToList();
            var varient =_context.TWVarients.Where(t => t.TwoWheelerId == modelId).ToList();
            ViewBag.varient = new SelectList(varient, "TWVarientId", "Varients");
            //Item2
            //ViewBag.Specs = new List<TWSpec>();
            var spec = _context.TWSpec.Where(t =>t.TwoWheeler.TwoWheelerId==modelId && t.TWVarientId == varientId).ToList();
            //var spec = _context.TWSpec.Where(t => t.TWVarientId == varientId).ToList();
            //Item3
            var features = _context.TWFeatures.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item4
            var safety = _context.TWSafety.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item5
            var mileageAndPerformance = _context.TWMileageAndPerformances.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item6
            var engineAndTransmission = _context.TWEngineAndTransmissions.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item7
            var chassisAndSuspension = _context.TWChassisAndSuspensions.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item8
            var dimensionsAndCapacity = _context.TWDimensionsAndCapacities.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item9
            var electricals = _context.TWElectricals.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item10
            var tyresAndBrakes = _context.TWTyresAndBrakes.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item11
            var motorAndBatteries = _context.TWMotorAndBatteries.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item12
            var underpinnings = _context.TWUnderpinnings.Where(t => t.TwoWheelerId == modelId).ToList();
            //Item13
            var chargings = _context.TWChargings.Where(t => t.TwoWheelerId == modelId).ToList();
            ////var tuple = new Tuple<List<TwoWheeler>, List<TWSpec>, List<TWFeatures>, List<TWSafety>, List<TWMileageAndPerformance>, List<TWEngineAndTransmission>, List<TWChassisAndSuspension>, List<TWDimensionsAndCapacity>,List<TWTyresAndBrakes>>
            ////    (twoWheelers, spec, features, safety, mileageandperformance, engineandtransmission, chassisandsuspension, dimensionsandcapacity, tyresandbrakes);
            ////return View("TwoWheelerDetails", tuple);

            ViewBag.TwoWheelers = twoWheelers;
            ViewBag.Specs = spec;
            ViewBag.Features = features;
            ViewBag.Safety = safety;
            ViewBag.MileageAndPerformance = mileageAndPerformance;
            ViewBag.EngineAndTransmission = engineAndTransmission;
            ViewBag.ChassisAndSuspension = chassisAndSuspension;
            ViewBag.DimensionsAndCapacity = dimensionsAndCapacity;
            ViewBag.Electricals = electricals;
            ViewBag.TyresAndBrakes = tyresAndBrakes;
            ViewBag.MotorAndBatteries = motorAndBatteries;
            ViewBag.Underpinnings = underpinnings;
            ViewBag.Chargings = chargings;

            return View();
        }
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