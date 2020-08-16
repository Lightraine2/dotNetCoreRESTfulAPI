using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace dotNetCoreRESTfulAPI.Controllers
{
  [Route("/[controller]")]
  [ApiController]
  public class RoomsController : ControllerBase
  {
    [HttpGet(Name = nameof(GetRooms))]
    public IActionResult GetRooms()
    {
      throw new NotImplementedException();
    }
  }
}