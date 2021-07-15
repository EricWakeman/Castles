using System.Collections.Generic;
using Castles.Data;
using Castles.Models;

namespace Castles.Services
{
    public class KnightsService
    {
        private readonly KnightsRepository _knightsRepo;

    public KnightsService(KnightsRepository knightsRepo)
    {
      _knightsRepo = knightsRepo;
    }
    public List<Knight> GetAllKnights()
    {
      return _knightsRepo.GetAllKnights();
    }
    public List<Knight> GetKnightsByCastleId(int id)
    {
      return _knightsRepo.GetKnightsByCastleId(id);
    }
    public Knight CreateKnight(Knight knightData)
    {
      return _knightsRepo.CreateKnight(knightData);
    }
  }
}