using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using TransportSystem.Models;

namespace TransportSystem.Services.StationService
{
    public class StationService : IStationService
    {
        private PublicTransportMonitoringContext _context;

        public StationService(PublicTransportMonitoringContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Timetable>>> GetStationTransportSchedule(int stationId, int transportId)
        {
            var response = new ServiceResponse<List<Timetable>>();

            response.Data = await _context.Timetables.Where(t => t.TransportUnitId == transportId && t.StationId == stationId).ToListAsync();
            if (response.Data != null)
            {
                response.Success = true;
                return response;
            }

            response.Success = false;
            response.Message = "No content";
            return response;
        }
    }
}
