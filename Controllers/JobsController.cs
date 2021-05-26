using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _jobsService;

    public JobsController(JobsService jobsService)
    {
      _jobsService = jobsService;
    }

    //TODO GETALL
    [HttpGet]
    public ActionResult<List<Job>> GetAll()
    {
      try
      {
        List<Job> jobs = _jobsService.GetAll();
        return Ok(jobs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //TODO GETBYID
    [HttpGet("{id}")]
    public ActionResult<Job> GetById(int id)
    {
      try
      {
        Job job = _jobsService.GetById(id);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //TODO POST
    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job newJob)
    {
      try
      {
        Job job = _jobsService.Create(newJob);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //TODO PUT
    [HttpPut("{id}")]
    public ActionResult<Job> Update([FromBody] Job update)
    {
      try
      {
        Job updated = _jobsService.Update(update);
        return Ok(updated);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    //TODO DELETE
    [HttpDelete("{id}")]
    public ActionResult<Job> Delete(int id)
    {
      try
      {
        _jobsService.Delete(id);
        return Ok("Deleted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}