using System.Collections.Generic;
using Castles.Data;
using Castles.Models;

namespace Castles.Services
{
    public class CastlesService
    {
      private readonly CastlesRepository _castlesRepo;

    public CastlesService(CastlesRepository castlesRepo)
    {
      _castlesRepo = castlesRepo;
    }
    public List<Castle> GetAllCastles()
    {
      return _castlesRepo.GetAllCastles();
    }
    public Castle CreateCastle(Castle castleData)
    {
      return _castlesRepo.CreateCastle(castleData);
    }
  }
}