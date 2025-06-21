using System.Collections.Generic;
using Cars_Bikes.Data;
using Cars_Bikes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Controllers
{
    public class CompareController : Controller
    {
        private readonly TwoWheelerDB _context;
        public CompareController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TWCompare()
        {
            var TWList = _context.Twowheelers.ToList();
            ViewBag.TWList = new SelectList(TWList, "TwoWheelerId", "TwoWheelerName");
            var BrandList = _context.TwowheelerBrands.ToList();
            ViewBag.BrandList = new SelectList(BrandList, "TWBrandId", "BrandName");

            ViewBag.image = TWList;
            return View();
        }

        // AJAX action to get variants by TwoWheelerId
        public JsonResult GetTwoWheelersByBrandId(int brandId)
        {
            var twoWheelers = _context.Twowheelers
                .Where(t => t.TwoWBrandId == brandId)
                .Select(t => new { t.TwoWheelerName, t.TwoWheelerId }) // Adjust the field names based on your model
                .ToList();

            return Json(twoWheelers);
        }
        // AJAX action to get variants by TwoWheelerId
        public IActionResult GetVariantsByTwoWheelerId(int twoWheelerId)
        {
            var variants = _context.TWVarients
                .Where(v => v.TwoWheelerId == twoWheelerId)
                .Select(v => new { v.TWVarientId, v.Varients })
                .ToList();

            return Json(variants);
        }

        [HttpGet]
        public JsonResult GetTWSpecData(int variantId)
        {
            var specs = _context.TWSpec
            .Where(s => s.TWVarientId == variantId)
            .Select(s => new
            {
                s.Varients,
                s.Milage,
                s.FrontBrake,
                s.RearBrake,
                s.FuelCapacity,
                s.TwoWheeler,
                s.BodyType
            })
            .FirstOrDefault();

            var engineAndTransmission = _context.TWEngineAndTransmissions
                .Where(e => e.TWVarientId == variantId)
                .Select(e => new
                {
                    e.EngineType,
                    e.Displacement,
                    e.MaxTorque,
                    e.NumOfCylinders,
                    e.CoolingSystem,
                    e.ValvePerCylinder,
                    e.Starting,
                    e.FuelSupply,
                    e.Clutch,
                    e.GearBox,
                    e.EmissionType,
                    e.CompressionRatio,
                    e.Ignition
                })
                .FirstOrDefault();

            var features = _context.TWFeatures
                .Where(f => f.TWVarientId == variantId)
                .Select(f => new
                {
                    f.ABS,
                    f.Speedometer,
                    f.Tripmeter,
                    f.Tachometer,
                    f.LEDTailLight,
                    f.Odometer,
                    f.FuelGauge,
                    f.InstrumentConsole,
                    f.SeatType,
                    f.BodyGraphics,
                    f.Clock,
                    f.PassengerFootrest,
                    f.AdditionalFeaturesOfVariant,
                    f.DistanceToEmptyIndicator,
                    f.AdjustableWindshield
                })
                .FirstOrDefault();

            var safety = _context.TWSafety
                .Where(s => s.TWVarientId == variantId)
                .Select(s => new
                {
                    s.PassSwitch,
                    s.EngineKillSwitch,
                    s.Display,
                    s.RidingModes,
                    s.TractionControl,
                    s.AdditionalFeatures
                })
                .FirstOrDefault();
            var mileageAndPerformance = _context.TWMileageAndPerformances
            .Where(mp => mp.TWVarientId == variantId)
            .Select(mp => new
            {
                mp.OverallMileage,
                mp.CityMileage,
                mp.HighwayMileage
            })
            .FirstOrDefault();

            var dimensionsAndCapacity = _context.TWDimensionsAndCapacities
                .Where(dc => dc.TWVarientId == variantId)
                .Select(dc => new
                {
                    dc.Width,
                    dc.Length,
                    dc.Height,
                    dc.FuelCapacity,
                    dc.GroundClearance,
                    dc.Wheelbase,
                    dc.KerbWeight,
                    dc.FuelReserve,
                    dc.SaddleHeight
                })
                .FirstOrDefault();

            var electricals = _context.TWElectricals
                .Where(e => e.TWVarientId == variantId)
                .Select(e => new
                {
                    e.Headlight,
                    e.TailLight,
                    e.TurnSignalLamp,
                    e.LEDTailLights,
                    e.LowFuelIndicato,
                    e.PilotLamps,
                    e.DistanceToEmptyIndicator,
                    e.DRLs
                })
                .FirstOrDefault();

            var tyresAndBrakes = _context.TWTyresAndBrakes
                .Where(tb => tb.TWVarientId == variantId)
                .Select(tb => new
                {
                    tb.FrontBrakeDiameter,
                    tb.RearBrakeDiameter,
                    tb.RadialTyre,
                    tb.FrontSuspension,
                    tb.RearSuspension
                })
                .FirstOrDefault();

            var motorAndBattery = _context.TWMotorAndBatteries
                .Where(mb => mb.TWVarientId == variantId)
                .Select(mb => new
                {
                    mb.PeakPower,
                    mb.DriveType,
                    mb.Transmission,
                    mb.BatteryCapacity
                })
                .FirstOrDefault();

            var underpinning = _context.TWUnderpinnings
                .Where(u => u.TWVarientId == variantId)
                .Select(u => new
                {
                    u.SuspensionFront,
                    u.SuspensionRear,
                    u.BrakesFront,
                    u.BrakesRear,
                    u.TyreSize,
                    u.WheelSize,
                    u.WheelType,
                    u.TubelessTyre
                })
                .FirstOrDefault();

            var charging = _context.TWChargings
                .Where(c => c.TWVarientId == variantId)
                .Select(c => new
                {
                    c.ChargingAtHome,
                    c.ChargingAtChargingStation
                })
                .FirstOrDefault();
            return Json(new
            {
                specs,
                engineAndTransmission,
                features,
                safety,
                mileageAndPerformance,
                dimensionsAndCapacity,
                electricals,
                tyresAndBrakes,
                motorAndBattery,
                underpinning,
                charging
            });
        }
        public JsonResult SearchTwoWheelers(string searchTerm)
        {
            var results = _context.Twowheelers
                                  .Where(t => t.TwoWheelerName.Contains(searchTerm))
                                  .Select(t => new {
                                      twoWheelerId = t.TwoWheelerId,
                                      twoWheelerName = t.TwoWheelerName
                                  })
                                  .ToList();

            return Json(results);
        }

        [Route("compare-bikes")]
        public IActionResult CompareBikes()
        {

            return View();

        }
        //public IActionResult TWCompareTwoBikes(int? variant1, int? variant2)
        //{
        //    var TWList = _context.Twowheelers.ToList();
        //    var BrandList = _context.TwowheelerBrands.ToList();

        //    ViewBag.TWList = new SelectList(TWList, "TwoWheelerId", "TwoWheelerName");
        //    ViewBag.BrandList = new SelectList(BrandList, "TWBrandId", "BrandName");

        //    ViewBag.Variant1 = variant1;
        //    ViewBag.Variant2 = variant2;

        //    return View();
        //}
        public IActionResult TWCompareTwoBikes(int variant1, int variant2)
        {
            var v1 = _context.TWVarients
                             .Include(v => v.TwoWheeler)
                             .ThenInclude(w => w.TwoWheelerBrands)
                             .FirstOrDefault(v => v.TWVarientId == variant1);

            var v2 = _context.TWVarients
                             .Include(v => v.TwoWheeler)
                             .ThenInclude(w => w.TwoWheelerBrands)
                             .FirstOrDefault(v => v.TWVarientId == variant2);

            if (v1 == null || v2 == null)
            {
                return NotFound("One or both bikes not found");
            }
           

            var firstBikeVariants = _context.TWVarients
                .Where(v => v.TwoWheelerId == v1.TwoWheelerId)
                .ToList();

            var secondBikeVariants = _context.TWVarients
                .Where(v => v.TwoWheelerId == v2.TwoWheelerId)
                .ToList();

            //var model = new TwoWheeler
            //{
            //    Variant1 = v1,
            //    Variant2 = v2
            //};
            var viewModel = new CompareViewModel
            {
                Variant1 = v1,
                Variant2 = v2,
                FirstBikeVariants = firstBikeVariants,
                SecondBikeVariants = secondBikeVariants
            };

            //return View(model);
            return View(viewModel);
        }

        [HttpGet]
        public JsonResult GetVariantDetails(int variantId)
        {
            var variant = _context.TWVarients.Include(v => v.TwoWheeler).ThenInclude(t => t.Brand)
                            .FirstOrDefault(v => v.TWVarientId == variantId);

            var spec = _context.TWSpec.FirstOrDefault(s => s.TWVarientId == variantId);

            if (variant == null || spec == null)
                return Json(null);

            return Json(new
            {
                brandId = variant.TwoWheeler.TwoWBrandId,
                modelId = variant.TwoWheelerId,
                modelName = variant.Varients,
                //imageUrl = variant.ImagePath, // Adjust if different
                milage = spec.Milage,
                fuelCapacity = spec.FuelCapacity,
                bodyType = spec.BodyType
            });
        }
      

        [HttpGet]
        public IActionResult GetVariantIdsByNames(string name1, string name2)
        {
            if (string.IsNullOrWhiteSpace(name1) || string.IsNullOrWhiteSpace(name2))
            {
                return Json(new { success = false, message = "Invalid bike name(s)" });
            }

            var v1 = _context.TWVarients
                .Include(v => v.TwoWheeler)
                //.Where(v => EF.Functions.Like(v.TwoWheeler.TwoWheelerName, name1));
                //.FirstOrDefault(v => v.TwoWheeler.TwoWheelerName == name1);
                .FirstOrDefault(v => v.TwoWheeler.TwoWheelerName.Trim().ToLower()== name1.Trim().ToLower());


            var v2 = _context.TWVarients
                .Include(v => v.TwoWheeler)
                // .Where(v => EF.Functions.Like(v.TwoWheeler.TwoWheelerName, name2));
                //.FirstOrDefault(v => v.TwoWheeler.TwoWheelerName == name2);
                .FirstOrDefault(v => v.TwoWheeler.TwoWheelerName.Trim().ToLower() == name2.Trim().ToLower());
            if (v1 == null || v2 == null)
            {
                return Json(new
                {
                    success = false,
                    message = $"Could not find variants for: {(v1 == null ? name1 : "")} {(v2 == null ? name2 : "")}"
                });
            }
            return Json(new
            {
                success = true,
                v1=v1.TWVarientId,
                v2=v2.TWVarientId
            });
        }
        




    }
}
