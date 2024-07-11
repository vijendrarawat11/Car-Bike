using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWSpec
    {
        [Key]
        public int TWSpecId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? Milage { get; set; }
        public string? FrontBrake { get; set; }
        public string? RearBrake { get; set; }
        public string? FuelCapacity { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public string? BodyType { get; set; }
    }
}
