using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using static MatchingAlgo.Helpers.Enums.Enums;

namespace MatchingAlgo.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            var Drivers = new[]
            {
                new Driver
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 5,
                    DriverLocation = new Point(51.518, 7.45425){SRID= 4326},
                    VehicleSize = Vehicle.SUV,
                    

                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 2,
                    DriverLocation = new Point(52.516272,13.377722){SRID= 4326},
                    VehicleSize = Vehicle.Van,
                    
                    
                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 1,
                    DriverLocation = new Point(59.3275,18.0675){SRID= 4326},
                    VehicleSize = Vehicle.SUV,
                    

                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 4,
                    DriverLocation = new Point(51.503333, -0.119722){SRID= 4326},
                    VehicleSize = Vehicle.Truck,
                    

                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 3,
                    DriverLocation = new Point(52.506272,10.377722){SRID= 4326},
                    VehicleSize = Vehicle.SUV,
                    

                }
            };
            var Helpers = new[]
            {
                new Helper
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 5,
                    HelperLocation = new Point(51.518, 7.45425){SRID = 4326},
                    
                },   
                new Helper
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 3,
                    HelperLocation = new Point(51.503333, -0.119722 ){SRID = 4326},
                    
                },   
                new Helper
                {
                    Id = Guid.NewGuid(),
                    DistanceToPickUp = 3,
                    HelperLocation = new Point(59.3275, 18.0675){SRID = 4326},
                    
                },
            };
            var Dates = new[]
            {
                new AvailableDate
                {
                    Id = Guid.NewGuid(),
                    AvaialbeDate = new DateTime(2022,9,30,0,0,0,0),
                    DriverId = Drivers[0].Id,
                    HelperId = Helpers[0].Id


                },                 
                new AvailableDate
                {
                    Id = Guid.NewGuid(),
                    AvaialbeDate = new DateTime(2022,9,29,0,0,0,0),
                    DriverId = Drivers[1].Id
                },
                new AvailableDate
                {
                    Id = Guid.NewGuid(),
                    AvaialbeDate = new DateTime(2022,10,1,0,0,0,0),
                    DriverId = Drivers[2].Id
                    
                },
                new AvailableDate
                {
                    Id = Guid.NewGuid(),
                    AvaialbeDate = new DateTime(2022,9,30,0,0,0,0),
                    DriverId = Drivers[3].Id,
                    HelperId = Helpers[1].Id

                    
                },                 
                new AvailableDate
                {
                    Id = Guid.NewGuid(),
                    AvaialbeDate = new DateTime(2022,9,30,0,0,0,0),
                    DriverId = Drivers[4].Id,
                    HelperId = Helpers[2].Id

                    
                },                                
                
            };
            var Shifts = new[]
            {
                new Shift
                {
                    Id= Guid.NewGuid(),
                    StartAvailableTime = new TimeSpan(9,30,0),
                    EndAvailableTime = new TimeSpan(11,30,0),
                    DriverId = Drivers[0].Id,
                    HelperId = Helpers[0].Id,
                    
                    
                },
                new Shift
                {
                    Id= Guid.NewGuid(),
                    StartAvailableTime = new TimeSpan(8,30,0),
                    EndAvailableTime = new TimeSpan(10,30,0),
                    HelperId = Helpers[1].Id

                },
                new Shift
                {
                    Id= Guid.NewGuid(),
                    StartAvailableTime = new TimeSpan(9,30,0),
                    EndAvailableTime = new TimeSpan(11,30,0),
                    DriverId = Drivers[1].Id,                                        
                    HelperId = Helpers[2].Id,


                },                
                new Shift
                {
                    Id= Guid.NewGuid(),
                    StartAvailableTime = new TimeSpan(9,30,0),
                    EndAvailableTime = new TimeSpan(11,30,0),
                    DriverId = Drivers[2].Id
                    
                },                
                new Shift
                {
                    Id= Guid.NewGuid(),
                    StartAvailableTime = new TimeSpan(9,30,0),
                    EndAvailableTime = new TimeSpan(11,30,0),
                    DriverId = Drivers[3].Id
                    
                },                
                new Shift
                {
                    Id= Guid.NewGuid(),
                    StartAvailableTime = new TimeSpan(9,30,0),
                    EndAvailableTime = new TimeSpan(11,30,0),
                    DriverId = Drivers[4].Id
                    
                },                

            };

            Drivers[0].AvaliableDateId = Dates[0].Id;
            Drivers[1].AvaliableDateId = Dates[1].Id;
            Drivers[2].AvaliableDateId = Dates[2].Id;
            Drivers[3].AvaliableDateId = Dates[3].Id;
            Drivers[4].AvaliableDateId = Dates[4].Id;

            Drivers[0].ShiftId = Shifts[0].Id;
            Drivers[1].ShiftId = Shifts[2].Id;
            Drivers[2].ShiftId = Shifts[3].Id;
            Drivers[3].ShiftId = Shifts[4].Id;
            Drivers[4].ShiftId = Shifts[5].Id;

            Helpers[0].AvaliableDateId = Dates[0].Id;
            Helpers[1].AvaliableDateId = Dates[3].Id;
            Helpers[2].AvaliableDateId = Dates[4].Id;

            Helpers[0].ShiftId = Shifts[0].Id;
            Helpers[1].ShiftId = Shifts[1].Id;
            Helpers[2].ShiftId = Shifts[2].Id;


            builder.Entity<Driver>().HasData(Drivers[0], Drivers[1], Drivers[2], Drivers[3], Drivers[4]);
            builder.Entity<Helper>().HasData(Helpers[0], Helpers[1], Helpers[2]);
            builder.Entity<AvailableDate>().HasData(Dates[0], Dates[1], Dates[2], Dates[3], Dates[4]);
            builder.Entity<Shift>().HasData(Shifts[0], Shifts[1], Shifts[2], Shifts[3], Shifts[4], Shifts[5]);
            builder.Entity("AvailableDateDriver").HasData(
                new { AvailableDatesId = Dates[0].Id,DriversId = Drivers[0].Id },
                new { AvailableDatesId = Dates[1].Id,DriversId = Drivers[1].Id },
                new { AvailableDatesId = Dates[2].Id,DriversId = Drivers[2].Id },
                new { AvailableDatesId = Dates[3].Id,DriversId = Drivers[3].Id },
                new { AvailableDatesId = Dates[4].Id,DriversId = Drivers[4].Id }
             );
            builder.Entity("AvailableDateHelper").HasData(
                new { AvailableDatesId = Dates[0].Id, HelpersId = Helpers[0].Id },
                new { AvailableDatesId = Dates[3].Id, HelpersId = Helpers[1].Id },
                new { AvailableDatesId = Dates[4].Id, HelpersId = Helpers[2].Id }
                );
           
        }


        public DbSet<Helper> Helpers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Shift> Shift { get; set; }

    }
}
