using System;

namespace contractor.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
  }
}
// CREATE TABLE IF NOT EXISTS contractors(
//   id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
//   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
//   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
//   name varchar(255) COMMENT 'Contractor Name',
//   description varchar(255) COMMENT 'Contractor Description'
// )