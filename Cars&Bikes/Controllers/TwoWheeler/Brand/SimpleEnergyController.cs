﻿using Cars_Bikes.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars_Bikes.Controllers.TwoWheeler.Brand
{
    public class SimpleEnergyController : Controller
    {
        private readonly TwoWheelerDB _context;
        public SimpleEnergyController(TwoWheelerDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("simple-energy/simple-one")]
        public IActionResult SimpleOne()
        {
            var bikeDetails = GetBikeDetails("Simple One");
            return View("~/Views/TwoWheeler/Brand/SimpleEnergy/SimpleOne.cshtml", bikeDetails);
        }
        [Route("simple-energy/simple-dot-one")]
        public IActionResult SimpleDotOne()
        {
            var bikeDetails = GetBikeDetails("Simple Dot One");
            return View("~/Views/TwoWheeler/Brand/SimpleEnergy/SimpleDotOne.cshtml", bikeDetails);
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
            var engineAndTransmission = _context.TWEVEngineAndTransmissions
                .Where(e => e.TWVarientId == variantId)
                .Select(e => new
                {
                    e.NumOfBattries,
                    e.CoolingSystem,
                    e.MotorPower,
                    e.RangeEcoMode,
                    e.RangeNormalMode,
                    e.RangeSportsMode,
                    e.Starting,
                    e.MotorIPRating
                })
                .FirstOrDefault();

            var features = _context.TWEVFeatures
                .Where(f => f.TWVarientId == variantId)
                .Select(f => new
                {
                    f.InstrumentConsole,
                    f.BluetoothConnectivity,
                    f.Navigation,
                    f.CallSMSAlerts,
                    f.RoadsideAssistance,
                    f.AntiTheftAlarm,
                    f.USBChargingPort,
                    f.MusicControl,
                    f.OTA,
                    f.Speedometer,
                    f.Tripmeter,
                    f.Odometer,
                    f.AdditionalFeaturesOfVariant,
                    f.SeatType,
                    f.Clock,
                    f.PassengerFootrest,
                    f.CarryHook,
                    f.UnderseatStorage,
                    f.ChargerOutput,
                    f.RegenerativeBraking,
                    f.HillHold,
                    f.KeylessIgnition
                })
                .FirstOrDefault();

            var safety = _context.TWEVSafety
                .Where(s => s.TWVarientId == variantId)
                .Select(s => new
                {
                    s.BrakingType,
                    s.ChargingPoint,
                    s.FastCharging,
                    s.MobileApplication,
                    s.InternetConnectivity,
                    s.OperatingSystem,
                    s.Processor,
                    s.Gradeability,
                    s.ServiceDueIndicator,
                    s.RidingModes,
                    s.Display,
                    s.SwitchableABS,
                    s.EBS,
                    s.SeatOpeningSwitch
                })
                .FirstOrDefault();

            var chassisAndSuspension = _context.TWEVChassisAndSuspensions
                .Where(s => s.TWVarientId == variantId)
                .Select(s => new
                {
                    s.BodyType
                })
                .FirstOrDefault();

            var dimensionsAndCapacity = _context.TWEVDimensionsAndCapacities
                .Where(dc => dc.TWVarientId == variantId)
                .Select(dc => new
                {
                    dc.Width,
                    dc.Length,
                    dc.Height,
                    dc.SaddleHeight,
                    dc.GroundClearance,
                    dc.Wheelbase,
                    dc.KerbWeight,
                    dc.AdditionalStorage
                })
                .FirstOrDefault();

            var electricals = _context.TWEVElectricals
                .Where(e => e.TWVarientId == variantId)
                .Select(e => new
                {
                    e.Headlight,
                    e.TailLight,
                    e.TurnSignalLamp,
                    e.LEDTailLights,
                    e.LowBatteryIndicator
                })
                .FirstOrDefault();

            var tyresAndBrakes = _context.TWEVTyresAndBrakes
                .Where(tb => tb.TWVarientId == variantId)
                .Select(tb => new
                {
                    tb.FrontBrakeDiameter,
                    tb.RearBrakeDiameter,
                    tb.FrontTyrePressureRider,
                    tb.FrontTyrePressureRiderAndPillion,
                    tb.RearTyrePressureRider,
                    tb.RearTyrePressureRiderAndPillion
                })
                .FirstOrDefault();

            var performances = _context.TWEVPerformances
                .Where(p => p.TWVarientId == variantId)
                .Select(p => new
                {
                    p.ScooterSpeed,
                    p.ZeroTo40Kmphsec,
                    p.TopSpeed,
                    p.ZeroTo100Kmphsec
                })
                .FirstOrDefault();

            var motorAndBattery = _context.TWEVMotorAndBatteries
                .Where(mb => mb.TWVarientId == variantId)
                .Select(mb => new
                {
                    mb.MotorType,
                    mb.TorqueMotor,
                    mb.PeakPower,
                    mb.BatteryType,
                    mb.BatteryCapacity,
                    mb.BatteryWarranty,
                    mb.WaterProofRating,
                    mb.ReverseAssist,
                    mb.Transmission
                })
                .FirstOrDefault();

            var ranges = _context.TWEVRanges
                .Where(r => r.TWVarientId == variantId)
                .Select(r => new
                {
                    r.ClaimedRange
                })
                .FirstOrDefault();

            var underpinning = _context.TWEVUnderpinnings
                .Where(u => u.TWVarientId == variantId)
                .Select(u => new
                {
                    u.SuspensionFront,
                    u.SuspensionRear,
                    u.BrakesFront,
                    u.BrakesRear,
                    u.ABS,
                    u.TyreSize,
                    u.WheelSize,
                    u.WheelType,
                    u.Frame,
                    u.TubelessTyre
                })
                .FirstOrDefault();

            var charging = _context.TWEVChargings
                .Where(c => c.TWVarientId == variantId)
                .Select(c => new
                {
                    c.ChargingAtHome,
                    c.ChargingAtChargingStation,
                    c.ChargingTimeZeroTo80Percent,
                    c.ChargingTimeZeroTo100Percent,
                    c.ChargingNetworkBatterySwappingNetwork
                })
                .FirstOrDefault();

            var appfeatures = _context.TWEVAppFeatures
                .Where(af => af.TWVarientId == variantId)
                .Select(af => new
                {
                    af.ChargingStationLocate,
                    af.Geofencing,
                    af.AntiTheftAlarm,
                    af.CallsAndMessaging,
                    af.NavigationAssis,
                    af.LowBatteryAlert
                })
                .FirstOrDefault();

            return Json(new
            {
                engineAndTransmission,
                features,
                safety,
                chassisAndSuspension,
                dimensionsAndCapacity,
                electricals,
                tyresAndBrakes,
                performances,
                motorAndBattery,
                ranges,
                underpinning,
                charging,
                appfeatures
            });
        }
    }
}
