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

        [HttpGet("station-transport")]
        public async Task<ActionResult<ServiceResponse<List<Timetable>>>> GetStationTransportTimetable(int stationId, int transportId)
        {
            var response = await _stationService.GetStationTransportSchedule(stationId, transportId);
            return Ok(response);
        }

        [HttpGet("station")]
        public async Task<ActionResult<ServiceResponse<List<Timetable>>>> GetStationTimetable(int stationId)
        {
            var response = await _stationService.GetStationSchedule(stationId);
            return Ok(response);
        }
    }
}
