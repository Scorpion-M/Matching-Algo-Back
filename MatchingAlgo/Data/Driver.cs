using NetTopologySuite.Geometries;
using static MatchingAlgo.Helpers.Enums.Enums;

namespace MatchingAlgo.Data
{
    public class Driver: BaseDriverHelper
    {
  
        public Vehicle VehicleSize { get; set; }
        public Point DriverLocation { get; set; }

    }
}
