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
    [Route("api/[controller]")]
    [Authorize]
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

        [HttpPost("RideNfc")]
        public async Task<ActionResult<ServiceResponse<RideRegisterDto>>> RegisterRideNFC(int transportUnitId, int userId)
        { ;
            return Ok(await _registerService.RegisterOnRide(transportUnitId, userId));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<bool>>> CheckRegisterValid(int transportUnitId)
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _registerService.CheckRegisterValid(transportUnitId, userId));
        }

        [HttpGet("GetTimeSeries")]
        public async Task<ActionResult<ServiceResponse<List<RegistrationInfo>>>> GetTimeSeries(int transportUnitId)
        {
            var timeSeries = await _registerService.GetTimeSeries(transportUnitId);
            return Ok(timeSeries);
        }

        [HttpGet("GetPassengersCount")]
        public async Task<ActionResult<ServiceResponse<int>>> GetPessangersCount(int transportUnitId)
        {
            var count = await _registerService.GetCurrentPassangersCount(transportUnitId);
            return Ok(count);
        }

        [HttpGet("GetHumanList")]
        public async Task<ActionResult<ServiceResponse<int>>> GetHumanList(int transportUnitId)
        {
            var humanList = await _registerService.GetHumansList(transportUnitId);
            return Ok(humanList);
        }
    }
}
