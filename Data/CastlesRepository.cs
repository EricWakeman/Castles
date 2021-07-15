using System.Collections.Generic;
using System.Data;
using System.Linq;
using Castles.Models;
using Dapper;

namespace Castles.Data
{
    public class CastlesRepository
    {
      private readonly IDbConnection _db;

    public CastlesRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Castle> GetAllCastles()
    {
      var sql = "SELECT * FROM castles";
      return _db.Query<Castle>(sql).ToList();
    }
    public Castle CreateCastle(Castle castleData)
    {
      var sql = @"
      INSERT INTO castles(name)
      VALUES(@Name);
      SELECT LAST_INSERT_ID();
      ";

      int id = _db.ExecuteScalar<int>(sql, castleData);
      castleData.Id = id;
      return castleData;
    }
  }
}