using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWMileageAndPerformance
    {
        [Key]
        public int TWMileageAndPerformanceId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public decimal? OverallMileage { get; set; }
        public decimal? CityMileage { get; set; }
        public decimal? HighwayMileage { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
