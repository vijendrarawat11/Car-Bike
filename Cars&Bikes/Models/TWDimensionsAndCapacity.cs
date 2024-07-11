using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWDimensionsAndCapacity
    {
        [Key]
        public int TWDimensionsAndCapacityId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? Width { get; set; }
        public string? Length { get; set; }
        public string? Height { get; set; }
        public string? FuelCapacity { get; set; }
        public string? GroundClearance { get; set; }
        public string? Wheelbase { get; set; }
        public string? KerbWeight { get; set; }
        public string? FuelReserve { get; set; }
        public string? SaddleHeight { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}

