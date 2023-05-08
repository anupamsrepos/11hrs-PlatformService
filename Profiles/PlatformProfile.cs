using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //Source to Target
            CreateMap<Platform, PlatformReadDto>(); //Source is database model, target model for consumer
            CreateMap<PlatformCreateDto, Platform>(); //client is trying to create an object in databse, so, Source is dto and target is database model
        }
    } 
}
