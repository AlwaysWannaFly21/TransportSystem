using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Services.RideRegisterService
{
    public interface IRideRegisterService
    {
        Task<ServiceResponse<RideRegisterDto>> RegisterOnRide(int transportUnitId, int userId);
    }
}
