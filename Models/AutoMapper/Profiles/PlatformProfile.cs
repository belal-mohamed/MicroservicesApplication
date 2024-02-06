using AutoMapper;
using PlatformService.Models.Dtos;
using PlatformService.Models.Entities;

namespace PlatformService.Models.AutoMapper.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            CreateMap<Platform, PlatformCreate>().ReverseMap();
            CreateMap<Platform, PlatformDetails>().ReverseMap();
        }
    }
}
