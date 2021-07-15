using System.Collections.Generic;
using Castles.Models;
using Castles.Services;
using Microsoft.AspNetCore.Mvc;

namespace Castles.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CastlesController : ControllerBase
    {
      private readonly CastlesService _castlesS;

    public CastlesController(CastlesService castlesS)
    {
      _castlesS = castlesS;
    }

      [HttpGet]
      public ActionResult<List<Castle>> GetAllCastles()
      {
        try
        {
            var castles = _castlesS.GetAllCastles();
            return Ok(castles);
        }
        catch (System.Exception e)
        {
            
            return BadRequest(e.Message);
        }
      }
      [HttpPost]
      public ActionResult<Castle> CreateArtist([FromBody] Castle castleData)
      {
        try
        {
            var castle = _castlesS.CreateCastle(castleData);
            return Created($"api/castles/{castle.Id}", castle);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
      }
  }
}