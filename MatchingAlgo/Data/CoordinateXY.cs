using System.ComponentModel.DataAnnotations;

namespace MatchingAlgo.Data
{
    public class CoordinateXY
    {
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
    }
}
