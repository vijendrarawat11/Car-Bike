using System.ComponentModel.DataAnnotations;

namespace Cars_Bikes.Models
{
    public class TwoWheelerBrand
    {
        [Key]
        public int TWBrandId { get; set; }
        public String? BrandName { get; set; }
        //public TwoWheeler twoWheelers { get; set; }
        public ICollection<TwoWheeler> TwoWheelers { get; set; }
    }
}
