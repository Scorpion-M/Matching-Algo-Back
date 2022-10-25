using MatchingAlgo.Data;

namespace MatchingAlgo.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<Driver> Drivers { get; }
        IGenericRepository<Helper> Helpers { get; }
        IGenericRepository<Shift> Shifts { get; }
        IGenericRepository<AvailableDate> AvailableDates { get; }

        Task Save();
    }
}
