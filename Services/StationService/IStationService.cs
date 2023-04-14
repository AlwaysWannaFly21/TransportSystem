using TransportSystem.Models;

namespace TransportSystem.Services.StationService
{
    public interface IStationService
    {
        Task<ServiceResponse<List<Timetable>>> GetStationTransportSchedule(int stationId, int transportId);
    }
}
