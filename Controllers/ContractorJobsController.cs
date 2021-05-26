using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorJobsController : ControllerBase
  {
    private readonly ContractorJobsService _contractorJobsService;

    public ContractorJobsController(ContractorJobsService contractorJobsService)
    {
      _contractorJobsService = contractorJobsService;
    }

    //TODO GETALL
    //TODO GETBYID
    //TODO POST
    //TODO PUT
    //TODO DELETE
  }
}