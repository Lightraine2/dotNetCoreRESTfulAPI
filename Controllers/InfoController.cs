using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotNetCoreRESTfulAPI.Models;
using Microsoft.Extensions.Options;

namespace dotNetCoreRESTfulAPI.Controllers
{
  [Route("/[controller]")]
  [ApiController]
  public class InfoController : ControllerBase
  {
    private readonly HotelInfo _hotelInfo;
    public InfoController(IOptions<HotelInfo> HotelInfoWrapper)
    {
      _hotelInfo = HotelInfoWrapper.Value;
    }
    [HttpGet(Name = nameof(GetInfo))]
    [ProducesResponseType(200)]
    public ActionResult<HotelInfo>GetInfo()
    {
      _hotelInfo.Href = Url.Link(nameof(GetInfo), null);
      return _hotelInfo;
    }
  }
}