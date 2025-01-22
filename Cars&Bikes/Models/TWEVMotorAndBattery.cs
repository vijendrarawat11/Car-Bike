﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWEVMotorAndBattery
    {
        [Key]
        public int TWEVMotorAndBatteryId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? MotorType { get; set; }
        public decimal? TorqueMotor { get; set; }
        public decimal? PeakPower { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? BatteryType { get; set; }
        public decimal? BatteryCapacity { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? BatteryWarranty { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? WaterProofRating { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? ReverseAssist { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? Transmission { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
