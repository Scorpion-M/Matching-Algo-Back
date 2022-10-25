using MatchingAlgo.Data;
using MatchingAlgo.Models.AvaliableDateDTOs;
using MatchingAlgo.Models.ShiftDTOs;
using NetTopologySuite.Geometries;
using static MatchingAlgo.Helpers.Enums.Enums;

namespace MatchingAlgo.Models.HelperDTOs
{
    public class BaseHelperDTO
    {
        public Guid ShiftId { get; set; }
        public ShiftDTO Shift { get; set; }
        public IList<AvailableDateDTO> AvailableDates { get; set; }
        public Guid AvaliableDateId { get; set; }
        public double DistanceToPickUp { get; set; }
        public double HelperLongtitude { get; set; }
        public double HelperLatitude { get; set; }
    }
}
