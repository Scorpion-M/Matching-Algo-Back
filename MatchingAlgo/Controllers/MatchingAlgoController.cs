using AutoMapper;
using MatchingAlgo.Data;
using MatchingAlgo.IRepository;
using MatchingAlgo.Models.DriverDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchingAlgo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchingAlgoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MatchingAlgoController> _logger;
        private readonly IMapper _mapper;

        public MatchingAlgoController(IUnitOfWork unitOfWork, ILogger<MatchingAlgoController> logger,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetDrivers([FromQuery] Customer c)
        {
            try
            {
                var drivers = await _unitOfWork.Drivers.GetAllAsync(expression:
                    driver => driver.VehicleSize == c.Vehicle &&
                    driver.AvailableDates.Any(date => date.AvaialbeDate == c.Date) &&
                    (c.StartTime.TotalMinutes + c.JobDuration) <= 
                    driver.Shift.StartAvailableTime.TotalMinutes &&
                    driver.Shift.EndAvailableTime.TotalMinutes >= 
                    (c.StartTime.TotalMinutes + c.JobDuration)
                    , includes: new List<string> { "AvailableDates", "Shift" }) ;
                var result = _mapper.Map<IList<DriverDTO>>(drivers);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Somthing went Wrong in the {nameof(GetDrivers)}");
                return StatusCode(500, "Internal Server Error. Please try again");
            }
        }
    }
}
