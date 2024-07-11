using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWCharging
    {
        [Key]
        public int TWChargingId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public string? ChargingAtHome { get; set; }
        public string? ChargingAtChargingStation { get; set; }
        public int TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
    }
}
