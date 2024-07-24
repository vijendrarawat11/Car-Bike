using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cars_Bikes.Models
{
    [Table("TwoWheelers")]
    public class TwoWheeler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TwoWheelerId { get; set; }

        [Required]
        public string TwoWheelerName { get; set; } = null!;
        public string? Price { get; set; }
        public int? BasePrice { get; set; }

        public int? TopPrice { get; set; }

        public string Brand { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string Colour { get; set; } = null!;
        public int TwoWBrandId { get; set; }
        [ForeignKey("TwoWBrandId")]
        public virtual TwoWheelerBrand TwoWheelerBrands { get; set; }
        public string TWImage { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]

        public string LaunchDate { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        //public DateOnly Date { get; set; }
        public bool IsEV {get; set;}
    }
}
