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
        //[Column(TypeName = "varchar(20)")]
        public string? Headlight { get; set; }
       // [Column(TypeName = "varchar(20)")]
        public string? TailLight { get; set; }
        //[Column(TypeName = "varchar(20)")]
        public string? TurnSignalLamp { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? LEDTailLights { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? LowFuelIndicato { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? PilotLamps { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? DistanceToEmptyIndicator { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? DRLs { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
