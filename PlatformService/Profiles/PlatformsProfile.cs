using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
 {
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Sorce -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }        
    }    
 }