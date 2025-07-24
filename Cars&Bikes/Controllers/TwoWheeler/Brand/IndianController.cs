﻿using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Controllers.TwoWheeler.Brand
{
    public class IndianController : Controller
    {
        private readonly TwoWheelerDB _context;
        public IndianController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("indian/indian-new-scout-1250cc")]
        public IActionResult IndianNewScout1250cc()
        {
            var bikeDetails = GetBikeDetails("Indian New Scout 1250cc");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianNewScout1250cc.cshtml", bikeDetails);
        }
        [Route("indian/indian-scout-1133cc")]
        public IActionResult IndianScout1133cc()
        {
            var bikeDetails = GetBikeDetails("Indian Scout 1133cc");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianScout1133cc.cshtml", bikeDetails);
        }
        [Route("indian/indian-ftr")]
        public IActionResult IndianFTR()
        {
            var bikeDetails = GetBikeDetails("Indian FTR");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianFTR.cshtml", bikeDetails);
        }
        [Route("indian/indian-cruiser")]
        public IActionResult IndianCruiser()
        {
            var bikeDetails = GetBikeDetails("Indian Cruiser");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianCruiser.cshtml", bikeDetails);
        }
        [Route("indian/indian-bagger")]
        public IActionResult IndianBagger()
        {
            var bikeDetails = GetBikeDetails("Indian Bagger");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianBagger.cshtml", bikeDetails);
        }
        [Route("indian/indian-touring")]
        public IActionResult IndianTouring()
        {
            var bikeDetails = GetBikeDetails("Indian Touring");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianTouring.cshtml", bikeDetails);
        }
        [Route("indian/indian-dark-horse")]
        public IActionResult IndianDarkHorse()
        {
            var bikeDetails = GetBikeDetails("Indian Dark Horse");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianDarkHorse.cshtml", bikeDetails);
        }
        [Route("indian/indian-elite")]
        public IActionResult IndianElite()
        {
            var bikeDetails = GetBikeDetails("Indian Elite");
            return View("~/Views/TwoWheeler/Brand/Indian/IndianElite.cshtml", bikeDetails);
        }
        private Cars_Bikes.Models.TwoWheeler GetBikeDetails(string bikeName)
        {
            var bike = _context.Twowheelers.Include(b => b.TWVarients)
                //.Include(b => b.TWSpecs)
                .FirstOrDefault(b => b.TwoWheelerName == bikeName);

            if (bike == null)
            {
                // Handle the case where the bike is not found
                return null;
            }
            var Allbrand = _context.TwowheelerBrands.ToList();
            ViewBag.AllBrand = Allbrand;
            return bike;
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
    }
}
