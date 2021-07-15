using System.Collections.Generic;
using System.Data;
using System.Linq;
using Castles.Models;
using Dapper;

namespace Castles.Data
{
    public class KnightsRepository
    {
      private readonly IDbConnection _db;

    public KnightsRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Knight> GetAllKnights()
    {
      var sql = "SELECT * FROM knights";
      return _db.Query<Knight>(sql).ToList();
    }
    public List<Knight> GetKnightsByCastleId(int id)
    {
      var sql = $"SELECT * FROM knights k WHERE k.Id = {id}";
      return _db.Query<Knight>(sql).ToList();
    }
    public Knight CreateKnight(Knight knightData)
    {
      var sql = @"
      INSERT INTO artists(name, castleId)
      VALUES (@Name, @CastleId);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, knightData);
      knightData.Id = id;
      return knightData;
    }
  }
}