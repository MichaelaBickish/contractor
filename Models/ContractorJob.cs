using System.ComponentModel.DataAnnotations;

namespace contractor.Models
{
  public class ContractorJob
  {
    public int Id { get; set; }
    [Required]
    public int JobId { get; set; }
    [Required]
    public int ContractorId { get; set; }
  }

  public class ContractorJobViewModel : Job
  {
    public int ContractorId { get; set; }
    public int JobId { get; set; }
    public int ContractorJobId { get; set; }
    public string ContractorName { get; set; }
    public string ContractorDescription { get; set; }

  }
}
//

// CREATE TABLE IF NOT EXISTS contractor_jobs(
//   id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
//   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
//   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
//   contractorId int NOT NULL COMMENT 'FK: Contractor Relationship',
//   jobId int NOT NULL COMMENT 'FK: Contractor Relationship',
//   FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE,
//   FOREIGN KEY (jobId) REFERENCES jobs(id) ON DELETE CASCADE
// SELECT
//   c.name as contractorName,
//   c.description as contractorDescription,
//   j.*,
//   cj.id as contractorJobId,
//   cj.jobId as jobId,
//   cj.contractorId as contractorId
// FROM
//   contractor_jobs cj
//   JOIN jobs j on j.id = cj.jobId
//   JOIN contractors c on c.id = cj.contractorId
// WHERE
//   cj.contractorId = 1;