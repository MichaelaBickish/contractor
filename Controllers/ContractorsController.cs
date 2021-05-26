using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _contractorsService;

    public ContractorsController(ContractorsService contractorsService)
    {
      _contractorsService = contractorsService;
    }
  }

  //TODO GETALL
  //TODO GETBYID - Contractor: get all jobs by contractor id, send to contractorJobs service.
  //TODO POST
  //TODO PUT
  //TODO DELETE
}