using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace dotNetCoreRESTfulAPI.Controllers
{
[Route("/")]
[ApiController]
[ApiVersion("1.0")]
public class RootController : ControllerBase

{
  [HttpGet(Name = nameof(GetRoot))]
  [ProducesResponseType(200)]
  public IActionResult GetRoot()
  {
    var response = new
    {
      href = Url.Link(nameof(GetRoot), null),
      rooms = new {
        href = Url.Link(
          nameof(RoomsController.GetRooms), null)
      },
      info = new 
      {
        href = Url.Link (
            nameof(InfoController.GetInfo), null)
        
      }
    };

    return Ok(response);
  }

}
}