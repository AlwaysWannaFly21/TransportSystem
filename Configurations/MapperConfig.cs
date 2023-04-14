using AutoMapper;
using TransportSystem.DTOs;
using TransportSystem.Models;

namespace TransportSystem.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<RegistrationInfo, RideRegisterDto>().ReverseMap();
        }
    }
}
