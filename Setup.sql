CREATE TABLE IF NOT EXISTS contractors(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'Contractor Name',
  description varchar(255) COMMENT 'Contractor Description'
);
CREATE TABLE IF NOT EXISTS jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'Job Name',
  description varchar(255) COMMENT 'Job Description',
  jobBid int NOT NULL COMMENT 'Job Bid Price',
  jobLocation varchar(255) COMMENT 'Job Site Location'
);
CREATE TABLE IF NOT EXISTS contractor_jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  contractorId int NOT NULL COMMENT 'FK: Contractor Relationship',
  jobId int NOT NULL COMMENT 'FK: Contractor Relationship',
  FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE,
  FOREIGN KEY (jobId) REFERENCES jobs(id) ON DELETE CASCADE
);
INSERT INTO
  contractors (name, description)
VALUES
  (
    "Mick Bick",
    "Woodworking fish fileting philanthropist"
  );
INSERT INTO
  jobs (name, description, jobLocation, jobBid)
VALUES
  (
    "fish filet",
    "filet this fish please",
    "Alaska",
    100
  );
INSERT INTO
  contractor_jobs (contractorId, jobId)
VALUES
  (1, 1);
SELECT
  c.name as contractorName,
  c.description as contractorDescription,
  j.*,
  cj.id as contractorJobId,
  cj.jobId as jobId,
  cj.contractorId as contractorId
FROM
  contractor_jobs cj
  JOIN jobs j on j.id = cj.jobId
  JOIN contractors c on c.id = cj.contractorId
WHERE
  cj.contractorId = 1;