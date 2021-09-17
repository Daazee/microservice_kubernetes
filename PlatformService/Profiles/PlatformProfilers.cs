using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Profiles
{
    public class PlatformProfilers : Profile
    {
        public PlatformProfilers()
        {
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
