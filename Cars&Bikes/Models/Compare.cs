using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Bikes.Models
{
    public class Compare
    {
        [Key]
        public int CompareId { get; set; }
        public string? CompareTopic { get; set; }
        public string? CompareURL { get; set; }
    }
}
