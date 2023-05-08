using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Services.RideRegisterService
{
    public class RideRegisterService : IRideRegisterService
    {
        private readonly PublicTransportMonitoringContext _context;
        private readonly IMapper _mapper;

        public RideRegisterService(PublicTransportMonitoringContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<RideRegisterDto>> RegisterOnRide(int transportUnitId, int userId)
        {
            var response = new ServiceResponse<RideRegisterDto>();
            try
            {
                var registration = new RideRegisterDto()
                {
                    ExpiryDate = DateTime.Now.AddHours(1),
                    ReadingTime = DateTime.Now,
                    TransportUnitId = transportUnitId,
                    UserId = userId
                };

                await _context.RegistrationInfos.AddAsync(_mapper.Map<RegistrationInfo>(registration));
                await _context.SaveChangesAsync();

                response.Data = registration;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
            }

            return response;
        }

        public async Task<ServiceResponse<bool>> CheckRegisterValid(int transportUnitId, int userId)
        {
            var response = new ServiceResponse<bool>();

            var isValid = _context.RegistrationInfos.Any(x =>
                x.UserId == userId && x.TransportUnitId == transportUnitId && x.ExpiryDate > DateTime.Now);

            response.Data = isValid;
            return response;
        }

        public async Task<ServiceResponse<List<HourlyRegistrationCount>>> GetTimeSeries(int transportUnitId)
        {
            var response = new ServiceResponse<List<HourlyRegistrationCount>>();

            var timeSeries = await _context.RegistrationInfos.Where(x =>
                x.TransportUnitId == transportUnitId && x.ReadingTime.Date == DateTime.Today)
                .GroupBy(x=>x.ReadingTime.Hour)
                .Select(g => new HourlyRegistrationCount
                {
                    Hour = g.Key,
                    Count = g.Count()
                })
                .ToListAsync();

            response.Data = timeSeries;

            return response;
        }

        public async Task<ServiceResponse<int>> GetCurrentPassangersCount(int transportUnitId)
        {
            var response = new ServiceResponse<int>();

            var count = await _context.RegistrationInfos.Where(x =>
                x.TransportUnitId == transportUnitId && x.ExpiryDate > DateTime.Now).CountAsync();

            response.Data = count;

            return response;
        }

        public async Task<ServiceResponse<List<HumanStatisticsDto>>> GetHumansList(int transportUnitId)
        {
            var response = new ServiceResponse<List<HumanStatisticsDto>>();

            var humanList = await _context.RegistrationInfos.Where(x =>
                x.TransportUnitId == transportUnitId).Select(x=> new HumanStatisticsDto()
            {
                HumanGuid = Guid.NewGuid(),
                ExpiredAt = x.ExpiryDate,
                RegistredAt = x.ReadingTime,
                PersonName = x.User.Username,
                PersonSurname = x.User.Username
            }).ToListAsync();

            response.Data = humanList;

            return response;
        }
    }

    public class HourlyRegistrationCount
    {
        public int Hour { get; set; }
        public int Count { get; set; }
    }
}
