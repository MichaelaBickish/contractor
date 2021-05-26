using contractor.Repositories;

namespace contractor.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _contractorsRepository;

    public ContractorsService(ContractorsRepository contractorsRepository)
    {
      _contractorsRepository = contractorsRepository;
    }
  }
}