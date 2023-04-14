using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Services.RideHistoryService
{
    public interface IRideHistoryService
    {
        Task<ServiceResponse<List<RideHistoryDto>>> GetRideHistoryAsync(int userId);
    }
}
