using Microsoft.AspNetCore.Mvc;
using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Services.RideRegisterService
{
    public interface IRideRegisterService
    {
        Task<ServiceResponse<RideRegisterDto>> RegisterOnRide(int transportUnitId, int userId);
        Task<ServiceResponse<bool>> CheckRegisterValid(int transportUnitId, int userId);
        Task<ServiceResponse<List<HourlyRegistrationCount>>> GetTimeSeries(int transportUnitId);
        Task<ServiceResponse<int>> GetCurrentPassangersCount(int transportUnitId);
        Task<ServiceResponse<List<HumanStatisticsDto>>> GetHumansList(int transportUnitId);
    }
}
