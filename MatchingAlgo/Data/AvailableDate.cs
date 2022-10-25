namespace MatchingAlgo.Data
{
    public class AvailableDate:BaseEntity
    {
        public DateTime AvaialbeDate { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public Guid? DriverId { get; set; }
        public virtual ICollection<Helper> Helpers { get; set; }
        public Guid? HelperId { get; set; }
    }
}
