﻿namespace MatchingAlgo.Data
{
    public class Shift:BaseEntity
    {
        public TimeSpan StartAvailableTime { get; set; }
        public TimeSpan EndAvailableTime { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }
        public Guid? DriverId { get; set; }
        public virtual ICollection<Helper> Helpers { get; set; }
        public Guid? HelperId { get; set; }
    }
}
