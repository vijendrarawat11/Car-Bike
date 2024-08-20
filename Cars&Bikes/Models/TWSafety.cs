﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWSafety
    {
        [Key]
        public int TWSafetyId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string? PassSwitch { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string? EngineKillSwitch { get; set; }
        public string? Display { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public string? RidingModes { get; set; }
        public string? TractionControl { get; set; }
        public string? AdditionalFeatures { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
