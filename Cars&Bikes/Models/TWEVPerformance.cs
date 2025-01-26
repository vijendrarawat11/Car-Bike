﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWEVPerformance
    {
        [Key]
        public int TWEVPerformanceId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? ScooterSpeed { get; set; }
        public decimal? ZeroTo40Kmphsec { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? ZeroTo100Kmphsec { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
