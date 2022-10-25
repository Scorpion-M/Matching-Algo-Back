using MatchingAlgo.Data;
using MatchingAlgo.Models.DriverDTOs;
using MatchingAlgo.Models.HelperDTOs;

namespace MatchingAlgo.Models.AvaliableDateDTOs
{
    public class BaseAvailabeDateDTO
    {
        public DateTime AvaialbeDate { get; set; }
        public IList<DriverDTO> Drivers { get; set; }
        public IList<HelperDTO> Helpers { get; set; }

    }
}
