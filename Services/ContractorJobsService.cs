using contractor.Repositories;

namespace contractor.Services
{
  public class ContractorJobsService
  {
    private readonly ContractorJobsRepository _contractorJobsRepo;

    public ContractorJobsService(ContractorJobsRepository contractorJobsRepo)
    {
      _contractorJobsRepo = contractorJobsRepo;
    }
  }
}