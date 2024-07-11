using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWElectricals
    {
        [Key]
        public int TWElectricalsId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? Headlight { get; set; }
        public string? TailLight { get; set; }
        public string? TurnSignalLamp { get; set; }
        public string? LEDTailLights { get; set; }
        public string? LowFuelIndicato { get; set; }
        public string? PilotLamps { get; set; }
        public string? DistanceToEmptyIndicator { get; set; }
        public string? DRLs { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
