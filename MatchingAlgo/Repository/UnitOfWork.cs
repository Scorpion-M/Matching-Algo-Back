using MatchingAlgo.Data;
using MatchingAlgo.IRepository;

namespace MatchingAlgo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Driver> _drivers;
        private IGenericRepository<Helper> _helpers;
        private IGenericRepository<Shift> _shifts;
        private IGenericRepository<AvailableDate> _availableDates;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Driver> 
            Drivers => _drivers ??= new GenericRepository<Driver>(_context);

        public IGenericRepository<Helper> 
            Helpers => _helpers ??= new GenericRepository<Helper>(_context);

        public IGenericRepository<Shift> 
            Shifts => _shifts ??= new GenericRepository<Shift>(_context);

        public IGenericRepository<AvailableDate> 
            AvailableDates => _availableDates ??= new GenericRepository<AvailableDate>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
