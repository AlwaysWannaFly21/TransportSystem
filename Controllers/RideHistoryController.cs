using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using TransportSystem.DTOs;
using TransportSystem.Models;
using TransportSystem.Services.RideHistoryService;

namespace TransportSystem.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RideHistoryController : ControllerBase
    {
        private readonly IRideHistoryService _userRideHistoryService;
        public RideHistoryController(IRideHistoryService userRideHistoryService)
        {
            _userRideHistoryService = userRideHistoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<RideHistoryDto>>>> GetUserRideHistory()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _userRideHistoryService.GetRideHistoryAsync(userId));
        }
    }
}
