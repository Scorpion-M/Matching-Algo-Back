namespace MatchingAlgo.Data
{
    public class BaseDriverHelper:BaseEntity
    {
        public virtual ICollection<AvailableDate> AvailableDates { get; set; }
        public Guid AvaliableDateId { get; set; }
        public Guid? ShiftId { get; set; }
        public virtual Shift Shift { get; set; }
        public double DistanceToPickUp { get; set; }
    }
}
