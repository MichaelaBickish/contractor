using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Repositories;

namespace contractor.Services
{

  public class JobsService
  {
    private readonly JobsRepository _jobsRepository;

    public JobsService(JobsRepository jobsRepository)
    {
      _jobsRepository = jobsRepository;
    }

    public List<Job> GetAll()
    {
      return _jobsRepository.GetAll();
    }

    public Job GetById(int id)
    {
      Job job = _jobsRepository.GetById(id);
      if (job == null)
      {
        throw new Exception("Invalid Id");
      }
      return job;
    }

    public Job Create(Job newJob)
    {
      Job job = _jobsRepository.Create(newJob);
      return job;
    }

    public Job Update(Job update)
    {
      Job original = GetById(update.Id);
      original.Name = update.Name.Length > 0 ? update.Name : original.Name;
      original.Description = update.Description.Length > 0 ? update.Description : original.Description;
      original.JobBid = update.JobBid > 0 ? update.JobBid : original.JobBid;
      original.JobLocation = update.JobLocation.Length > 0 ? update.JobLocation : original.JobLocation;
      if (_jobsRepository.Update(original))
      {
        return original;
      }
      throw new Exception("Something went wrong");
    }

    public void Delete(int id)
    {
      GetById(id);
      _jobsRepository.Delete(id);
    }
  }
}