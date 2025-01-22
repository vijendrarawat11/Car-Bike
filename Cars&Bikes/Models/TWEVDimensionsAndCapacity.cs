﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class TWEVDimensionsAndCapacity
    {
        [Key]
        public int TWEVDimensionsAndCapacityId { get; set; }
        public string? TWName { get; set; }
        public string? Varients { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Height { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? SaddleHeight { get; set; }
        public decimal? GroundClearance { get; set; }
        public decimal? Wheelbase { get; set; }
        public decimal? KerbWeight { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? AdditionalStorage { get; set; }
        public int? TwoWheelerId { get; set; }
        [ForeignKey("TwoWheelerId")]
        public virtual TwoWheeler TwoWheeler { get; set; }
        public int? TWVarientId { get; set; }
        [ForeignKey("TWVarientId")]
        public virtual TWVarient TWVarients { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
