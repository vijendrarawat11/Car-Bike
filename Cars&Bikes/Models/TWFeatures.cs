using Google.Apis.Discovery;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWFeatures
    {
        [Key]
        public int TWFeaturesId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? ABS { get; set; }
        public string? Speedometer { get; set; }
        public string? Tripmeter { get; set; }
        public string? Tachometer { get; set; }
        public string? LEDTailLight { get; set; }
        public string? Odometer { get; set; }
        public string? FuelGauge { get; set; }
        public string? InstrumentConsole { get; set; }
        public string? SeatType { get; set; }
        public string? BodyGraphics { get; set; }
        public string? Clock { get; set; }
        public string? PassengerFootrest { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public string AdditionalFeaturesOfVariant { get; set; }
        public string DistanceToEmptyIndicator { get; set; }
        public string AdjustableWindshield { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
