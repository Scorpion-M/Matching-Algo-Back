using MatchingAlgo.Models.DriverDTOs;
using MatchingAlgo.Models.HelperDTOs;

namespace MatchingAlgo.Models.DriverHelperDTOs
{
    public class DriverHelpersDTO
    {
        public DriverDTO? nearestDriver { get; set; }
        public List<HelperDTO>? nearestRequiredHelpers { get; set; }
    }
}
