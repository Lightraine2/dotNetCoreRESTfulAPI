using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotNetCoreRESTfulAPI.Models;

namespace dotNetCoreRESTfulAPI.Services
{
  public interface IRoomService

  {
    Task<Room> GetRoomAsync(Guid Id);   
  }
}