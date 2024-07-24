using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWImageColorPrice
    {
        [Key]
        public int TWImageColorPriceId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public int? Price { get; set; }
        public string Color { get; set; }
        public string ImageURL { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
