using MatchingAlgo.Data;

namespace MatchingAlgo.Helpers
{
    public  class HelperMethods
    {
        public static bool MatchingTime(Shift shift, Customer customer) {

            var jobDurationAndStartTime = customer.StartTime.AddMinutes(customer.JobDuration);
            var customerTime = new TimeSpan(jobDurationAndStartTime.Hour, jobDurationAndStartTime.Minute, 0);
            var driverStartTime = new TimeSpan(shift.StartAvailableTime.Hour, shift.StartAvailableTime.Minute, 0);
            var driverEndTime = new TimeSpan(shift.EndAvailableTime.Hour, shift.EndAvailableTime.Minute, 0);

            return driverStartTime <= customerTime && driverEndTime >= customerTime;

        }
    }
}
