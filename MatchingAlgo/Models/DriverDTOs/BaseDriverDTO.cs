using MatchingAlgo.Data;
using MatchingAlgo.Models.AvaliableDateDTOs;
using MatchingAlgo.Models.ShiftDTOs;
using NetTopologySuite.Geometries;
using static MatchingAlgo.Helpers.Enums.Enums;

namespace MatchingAlgo.Models.DriverDTOs
{
    public class BaseDriverDTO
    {
        public Guid ShiftId { get; set; }
        public  ShiftDTO Shift { get; set; }
        public  IList<AvailableDateDTO> AvailableDates { get; set; }
        public Guid AvaliableDateId { get; set; }
        public double DistanceToPickUp { get; set; }
        public Vehicle VehicleSize { get; set; }
        public double DriverLongtitude { get; set; }
        public double DriverLatitude { get; set; }
    }
}
