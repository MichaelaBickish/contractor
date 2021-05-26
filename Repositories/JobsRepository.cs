using System;
using System.Collections.Generic;
using System.Data;
using contractor.Models;
using Dapper;

namespace contractor.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Job> GetAll()
    {
      string sql = "SELECT * FROM jobs";
      return (List<Job>)_db.Query<Job>(sql);
    }

    internal Job GetById(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    internal Job Create(Job newJob)
    {
      string sql = @"
      INSERT INTO jobs
      (name, description, jobBid, jobLocation)
      VALUES
      (@Name, @Description, @JobBid, @JobLocation);
      SELECT LAST_INSERT_ID()";

      newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
      return newJob;
    }

    internal bool Update(Job original)
    {
      string sql = @"
      UPDATE jobs
      SET
       name = @Name,
       description = @Description,
       jobBid = @JobBid,
       joblocation = @JobLocation
       WHERE id = @id";
      int affectedRows = _db.Execute(sql, original);
      return affectedRows == 1;
    }

    internal bool Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @id LIMIT 1";
      int affectedRows = _db.Execute(sql, new { id });
      return affectedRows == 1;
    }
  }
}