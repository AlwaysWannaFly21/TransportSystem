using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Services.StationService
{
    public interface IStationService
    {
        Task<ServiceResponse<List<Timetable>>> GetStationTransportSchedule(int stationId, int transportId);
        Task<ServiceResponse<List<StationTimetableDto>>> GetStationSchedule(int stationId);
        Task<ServiceResponse<List<StationTimetableDto>>> GetNearestArrivals(int stationId);
    }
}
