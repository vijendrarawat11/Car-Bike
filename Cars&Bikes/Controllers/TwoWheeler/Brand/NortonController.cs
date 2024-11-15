﻿using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Controllers.TwoWheeler.Brand
{
    public class NortonController : Controller
    {
        private readonly TwoWheelerDB _context;
        public NortonController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("norton/norton-commando-961")]
        public IActionResult NortonCommando961()
        {
            var bikeDetails = GetBikeDetails("Norton Commando 961");
            return View("~/Views/TwoWheeler/Brand/Norton/NortonCommando961.cshtml", bikeDetails);
        }
        [Route("norton/norton-v4sv")]
        public IActionResult NortonV4SV()
        {
            var bikeDetails = GetBikeDetails("Norton V4SV");
            return View("~/Views/TwoWheeler/Brand/Norton/NortonV4SV.cshtml", bikeDetails);
        }
        [Route("norton/norton-v4cr")]
        public IActionResult NortonV4CR()
        {
            var bikeDetails = GetBikeDetails("Norton V4CR");
            return View("~/Views/TwoWheeler/Brand/Norton/NortonV4CR.cshtml", bikeDetails);
        }
        [Route("norton/norton-commando-961-limited-edition")]
        public IActionResult NortonCommando961LimitedEdition()
        {
            var bikeDetails = GetBikeDetails("Norton Commando 961 Limited Edition");
            return View("~/Views/TwoWheeler/Brand/Norton/NortonCommando961LimitedEdition.cshtml", bikeDetails);
        }
        [Route("norton/norton-v4sv-limited-edition")]
        public IActionResult NortonV4SVLimitedEdition()
        {
            var bikeDetails = GetBikeDetails("Norton V4SV Limited Edition");
            return View("~/Views/TwoWheeler/Brand/Norton/NortonV4SVLimitedEdition.cshtml", bikeDetails);
        }
        [Route("norton/norton-v4cr-limited-edition")]
        public IActionResult NortonV4CRLimitedEdition()
        {
            var bikeDetails = GetBikeDetails("Norton V4CR Limited Edition");
            return View("~/Views/TwoWheeler/Brand/Norton/NortonV4CRLimitedEdition.cshtml", bikeDetails);
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