using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportSystem.Models;
using TransportSystem.Services.StationService;

namespace TransportSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Timetable>>>> GetTimetable(int stationId, int transportId)
        {
            var response = await _stationService.GetStationTransportSchedule(stationId, transportId);
            return Ok(response);
        }
    }
}
