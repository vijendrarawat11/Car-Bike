using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace Cars_Bikes.Models
{
    public class TWEngineAndTransmission
    {
        [Key]
        public int TWEngineAndTransmissionId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? EngineType { get; set; }
        public decimal? Displacement { get; set; }
        public string? MaxTorque { get; set; }
        public int? NumOfCylinders { get; set; }
        public string? CoolingSystem { get; set; }
        public int? ValvePerCylinder { get; set; }
        public string? Starting { get; set; }
        public string? FuelSupply { get; set; }
        public string? Clutch { get; set; }
        public string? GearBox { get; set; }
        public string? EmissionType { get; set; }
        public string? CompressionRatio { get; set; }
        public string? Ignition { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
