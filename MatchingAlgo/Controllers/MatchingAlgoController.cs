using AutoMapper;
using MatchingAlgo.Data;
using MatchingAlgo.Helpers;
using MatchingAlgo.IRepository;
using MatchingAlgo.Models.DriverDTOs;
using MatchingAlgo.Models.DriverHelperDTOs;
using MatchingAlgo.Models.HelperDTOs;
using MatchingAlgo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;

namespace MatchingAlgo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchingAlgoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MatchingAlgoController> _logger;
        private readonly IMapper _mapper;

        public MatchingAlgoController(IUnitOfWork unitOfWork, ILogger<MatchingAlgoController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetNearestDriverAndHelpers([FromQuery] Customer customer)
        {
            try
            {
                // get list of all nearest driver
                var drivers = await GetDrivers(customer);
                // get list of all nearest helper depends on helpers count in customer object
                var helpers = await GetHelpers(customer);

                var result = new DriverHelpersDTO
                {   
                    //get the first near driver
                    nearestDriver = drivers.FirstOrDefault(),
             
                    nearestRequiredHelpers = helpers
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Somthing went Wrong in the {nameof(GetDrivers)}");
                return StatusCode(500, "Internal Server Error. Please try again");
            }
        }

        // get nearst Drivers
        private async Task<List<DriverDTO>> GetDrivers(Customer customer)
        {
            try
            {
                var drivers = await _unitOfWork.Drivers.GetAllAsync(expression:
                     driver => driver.VehicleSize == customer.Vehicle &&
                     driver.AvailableDates.Any(date => date.AvaialbeDate == customer.Date)
                     , includes: new List<string> { "AvailableDates", "Shift" });
                var availbeDriverFotTime = drivers.Where(driver => HelperMethods.MatchingTime(driver.Shift, customer)).ToList();
                var nearestDrivers = availbeDriverFotTime.OrderBy(driver =>
                    driver.DriverLocation.Coordinate.Distance(new Coordinate(customer.StartLocation.Latitude, customer.StartLocation.Longitude))).ToList();
                var mappedDriver = _mapper.Map<List<DriverDTO>>(nearestDrivers);

                return mappedDriver;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Somthing went Wrong in the {nameof(GetDrivers)}");
                return new List<DriverDTO>();
            }
        }

        // get Nearst Helper depends on helper count in customer Object
        private async Task<List<HelperDTO>> GetHelpers(Customer customer)
        {
            try
            {
                var helpers = await _unitOfWork.Helpers.GetAllAsync(expression:
                    helper => helper.AvailableDates.Any(date => date.AvaialbeDate == customer.Date)
                    , includes: new List<string> { "AvailableDates", "Shift" });
                var availbeHelperFotTime = helpers.Where(helper => HelperMethods.MatchingTime(helper.Shift, customer)).ToList();
                var nearestHelper = availbeHelperFotTime.OrderBy(helper =>
                    helper.HelperLocation.Coordinate.Distance(new Coordinate(customer.StartLocation.Latitude, customer.StartLocation.Longitude))).Skip(0).Take(customer.Helpers).ToList();
                var mappedHelper = _mapper.Map<List<HelperDTO>>(nearestHelper);

                return mappedHelper;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Somthing went Wrong in the {nameof(GetDrivers)}");
                return new List<HelperDTO>();
            }
        }

    }


}
