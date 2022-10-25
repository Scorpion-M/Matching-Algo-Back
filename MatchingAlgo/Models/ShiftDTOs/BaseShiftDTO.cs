using MatchingAlgo.Data;
using MatchingAlgo.Models.DriverDTOs;
using MatchingAlgo.Models.HelperDTOs;

namespace MatchingAlgo.Models.ShiftDTOs
{
    public class BaseShiftDTO
    {
        public DateTime StartAvailableTime { get; set; }
        public DateTime EndAvailableTime { get; set; }
        public  IList<DriverDTO> Drivers { get; set; }
        public  IList<HelperDTO> Helpers { get; set; }


    }
}
