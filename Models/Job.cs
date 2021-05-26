using System;

namespace contractor.Models
{
  public class Job
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int JobBid { get; set; }
    public string JobLocation { get; set; }

  }
}
// CREATE TABLE IF NOT EXISTS jobs(
//   id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
//   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
//   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
//   name varchar(255) COMMENT 'Job Name',
//   description varchar(255) COMMENT 'Job Description',
//   jobBid int NOT NULL COMMENT 'Job Bid Price',
//   jobLocation varchar(255) COMMENT 'Job Site Location'
// )