using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    [Table("TWUpcomingBikes")]
    public class UpcomingBike
    {
        [Key]
        public int UpcomingBikeId { get; set; }
        public string? UpcomingBikeName { get; set; }
        public string? UpcomingBikeDetails { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]

        public DateTime? ExpectedLaunchDate { get; set; }
        public string ImageURL { get; set; }
        public int TwoWBrandId { get; set; }
        [ForeignKey("TwoWBrandId")]
        public virtual TwoWheelerBrand TwoWheelerBrands { get; set; }
        public String? BrandName { get; set; }
    }
}
