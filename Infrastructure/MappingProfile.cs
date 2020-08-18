using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using dotNetCoreRESTfulAPI.Models;

namespace dotNetCoreRESTfulAPI.Infrastructure
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
      {
        CreateMap<RoomEntity, Room>()
          .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => src.Rate/100.0m));
          // todo Url.Link.
      }
  }

}