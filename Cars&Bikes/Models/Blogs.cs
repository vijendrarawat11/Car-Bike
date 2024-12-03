﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cars_Bikes.Models
{
    public class Blogs
    {
        [Key]
        public int BlogId { get; set; }
        [MaxLength(500)]
        public string? BlogHeading { get; set; }
        [MaxLength(2000)]
        public string? BlogSummary { get; set; }
        public string? BlogDetail { get; set; }
        public string? URL { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]

        public DateTime? Date { get; set; } = DateTime.Now;
        public string? ImageURL { get; set; }
        public bool? IsTwoWheeler { get; set; }
    }
}
