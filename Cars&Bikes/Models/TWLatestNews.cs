using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWLatestNews
    {
        [Key]
        public int TWLatestNewsId { get; set; }
        [MaxLength(100)]
        public string? NewsHeading { get; set; }
        [MaxLength(500)]
        public string? NewsSummary { get; set; }
        [MaxLength(2000)]
        public string? NewsDetail { get; set; }
        public string? ImageURL { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]

        public DateTime? Date { get; set; } = DateTime.Now;
        public int? TwoWBrandId { get; set; }
        [ForeignKey("TwoWBrandId")]
        public virtual TwoWheelerBrand TwoWheelerBrands { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? BrandName { get; set; }
    }
}
