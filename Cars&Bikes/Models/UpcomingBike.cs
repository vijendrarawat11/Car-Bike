using System.ComponentModel.DataAnnotations;

namespace Cars_Bikes.Models
{
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
    }
}
