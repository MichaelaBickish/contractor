using System.Data;

namespace contractor.Repositories
{
  public class ContractorJobsRepository
  {
    private readonly IDbConnection _db;

    public ContractorJobsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}