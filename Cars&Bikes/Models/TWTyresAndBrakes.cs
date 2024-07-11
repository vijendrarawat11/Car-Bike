using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Cars_Bikes.Models
{
    public class TWTyresAndBrakes
    {
        [Key]
        public int TWTyresAndBrakesId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? FrontBrakeDiameter { get; set; }
        public string? RearBrakeDiameter { get; set; }
        public string? RadialTyre { get; set; }
        public string? FrontSuspension { get; set; }
        public string? RearSuspension { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
