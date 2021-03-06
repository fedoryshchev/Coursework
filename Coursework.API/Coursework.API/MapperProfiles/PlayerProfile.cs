﻿using AutoMapper;
using Core.Entities.Origin;
using Coursework.API.DTOs;

namespace Coursework.API.MapperProfiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<PlayerDTO, Player>()
                .ForMember(dest => dest.Id,
                    src => src.Ignore())
                .ReverseMap();
        }
    }
}
