using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using TransportSystem.DTOs;
using TransportSystem.Models;
using TransportSystem.Services.RideRegisterService;

namespace TransportSystem.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RideRegisterController : ControllerBase
    {
        private readonly IRideRegisterService _registerService;
        public RideRegisterController(IRideRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<RideRegisterDto>>> RegisterRide(int transportUnitId)
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _registerService.RegisterOnRide(transportUnitId, userId));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<bool>>> CheckRegisterValid(int transportUnitId)
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _registerService.CheckRegisterValid(transportUnitId, userId));
        }
    }
}
