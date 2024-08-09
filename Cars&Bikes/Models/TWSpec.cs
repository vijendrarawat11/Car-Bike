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
        public decimal? Milage { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? FrontBrake { get; set; }
        //[Column(TypeName = "varchar(10)")]
        public string? RearBrake { get; set; }
        public decimal? FuelCapacity { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public string? BodyType { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
