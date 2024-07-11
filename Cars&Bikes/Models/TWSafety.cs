using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWSafety
    {
        [Key]
        public int TWSafetyId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? PassSwitch { get; set; }
        public string? EngineKillSwitch { get; set; }
        public string? Display { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public string? RidingModes { get; set; }
        public string? TractionControl { get; set; }
        public string? AdditionalFeatures { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
