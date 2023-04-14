using AutoMapper;
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
    }
}
