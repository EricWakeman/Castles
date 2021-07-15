using System.Collections.Generic;
using Castles.Models;
using Castles.Services;
using Microsoft.AspNetCore.Mvc;

namespace Castles.Controllers 
{
    [ApiController]
    [Route("api/[Controller]")]
    public class KnightsController : ControllerBase
    {
      private readonly KnightsService _knightsS;
      public KnightsController(KnightsService knightsS)
    {
      _knightsS = knightsS;
    }
    [HttpGet]
      public ActionResult<List<Knight>> GetAllKnights()
      {
        try
        {
            var knights = _knightsS.GetAllKnights();
            return Ok(knights);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
      }
      [HttpGet("{id}")]
      public ActionResult<List<Knight>> GetKnightsByCastleId(int id)
      {
        try
        {
            var knights = _knightsS.GetKnightsByCastleId(id);
            if (knights == null)
            {
              return BadRequest("Invalid Id");
            }
            return Ok(knights);
        }
        catch (System.Exception e)
        {
            return Forbid(e.Message);
        }
      }
      [HttpPost]
      public ActionResult<Knight> CreateKnight([FromBody] Knight knightData)
      {
        try
        {
            var knight = _knightsS.CreateKnight(knightData);
            return Created("/api/knights/"+knight.Id ,knight);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
      }


  }
}