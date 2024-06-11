using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cars_Bikes.Models
{
    public class TwoWheeler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TwoWheelerId { get; set; }
        [Key]
        public string TwoWheelerName { get; set; } = null!;

        public string? BasePrice { get; set; }

        public string TopPrice { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string Colour { get; set; } = null!;
        public int TwoWBrandId { get; set; }
        [ForeignKey("TwoWBrandId")]
        public virtual TwoWheelerBrand TwoWheelerBrands { get; set; }
    }
}
