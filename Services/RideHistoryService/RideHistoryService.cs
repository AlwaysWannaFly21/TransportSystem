using Microsoft.EntityFrameworkCore;
using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Services.RideHistoryService
{
    public class RideHistoryService : IRideHistoryService
    {
        private PublicTransportMonitoringContext _context;

        public RideHistoryService(PublicTransportMonitoringContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<RideHistoryDto>>> GetRideHistoryAsync(int userId)
        {
            var response = new ServiceResponse<List<RideHistoryDto>>();

            var result = await _context.RegistrationInfos
                .Include(x => x.TransportUnit)
                .Where(x => x.UserId == userId)
                .Select(dto => new RideHistoryDto()
                {
                    ReadingTime = dto.ReadingTime,
                    RouteName = dto.TransportUnit.Route.RouteName,
                    TransportUnitId = dto.TransportUnitId,
                })
                .ToListAsync();

            if (result.Count > 0)
            {
                response.Data = result;
                return response;
            }

            response.Success = false;
            response.Message = "No history";
            return response;
        }
    }
}
