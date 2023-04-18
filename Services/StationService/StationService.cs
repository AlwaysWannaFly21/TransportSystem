using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using TransportSystem.DTOs;
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

        public async Task<ServiceResponse<List<StationTimetableDto>>> GetStationSchedule(int stationId)
        {
            var response = new ServiceResponse<List<StationTimetableDto>>();

            response.Data = await _context.Timetables
                .Where(t => t.StationId == stationId)
                .OrderBy(x=>x.ArrivalTime)
                .Select(dto => new StationTimetableDto()
            {
                ArrivalTime = dto.ArrivalTime,
                TransportUnitId = dto.TransportUnitId
            }).ToListAsync();

            if (response.Data != null)
            {
                response.Success = true;
                return response;
            }

            response.Success = false;
            response.Message = "No timetable for this station";
            return response;
        }

        public async Task<ServiceResponse<List<StationTimetableDto>>> GetNearestArrivals(int stationId)
        {
            var response = new ServiceResponse<List<StationTimetableDto>>();
            var timeNow = DateTime.Now.TimeOfDay;

            response.Data = await _context.Timetables 
                .Where(t => 
                        t.StationId == stationId 
                            && t.ArrivalTime > timeNow
                                //Here is the comparison of current time and arrival time. 60 stands for minutes (1 hour) 
                                && EF.Functions.DateDiffMinute(timeNow, t.ArrivalTime) < 60)  
                .OrderBy(x => x.ArrivalTime)
                .Select(dto => new StationTimetableDto()
                {
                    ArrivalTime = dto.ArrivalTime - timeNow,
                    TransportUnitId = dto.TransportUnitId
                }).ToListAsync();

            if (response.Data.Count > 0)
            {
                response.Success = true;
                return response;
            }

            response.Success = false;
            response.Message = "Oops, no arrivals in one hour...";
            return response;
        }
    }
}
