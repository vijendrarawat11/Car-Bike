﻿using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWEVEngineAndTransmission
    {
        [Key]
        public int TWEVEngineAndTransmissionId { get; set; }
        public string? EVName { get; set; }
        public string? Varients { get; set; }
        public int? NumOfBattries { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? CoolingSystem { get; set; }
        public decimal? MotorPower { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? RangeEcoMode { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? RangeNormalMode { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? RangeSportsMode { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Starting { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? MotorIPRating { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
