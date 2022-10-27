CREATE TABLE Department (
  Dept varchar(20),
  Depta char(30),
  location char(30)
);

INSERT INTO Department
VALUES ('d1', 'Rese', 'Dallas');

INSERT INTO Department
VALUES ('d2', 'Accounting', 'Seattle');

INSERT INTO Department
VALUES ('d3', 'Marketing', 'Dallas');

CREATE TABLE Employee(
emp int,
emp_fna char(30),
emp_lna char(30),
dept varchar(2)
);

INSERT INTO Employee
VALUES (25348, 'Matthew','Smith', 'd3');

INSERT INTO Employee
VALUES (10102, 'Ann', 'Jones', 'd3');

INSERT INTO Employee
VALUES (18316, 'John', 'Barrimore', 'd1');

INSERT INTO Employee
VALUES (29346, 'James', 'James', 'd2');

CREATE TABLE Project(
project_no varchar(3),
project_name char(30),
Budjet int
);

INSERT INTO Project
VALUES ('p1', 'Apollo', 120000);

INSERT INTO Project
VALUES ('p2', 'Gemini', 95000);

INSERT INTO Project
VALUES ('p3', 'Mercury', 185600);

CREATE TABLE Works_on(
emp_no int,
project_no varchar(3),
Job char(30),
enter_date date
);

INSERT INTO Works_on
VALUES (10102, 'p1', 'Analyst', '1997.10.1');

INSERT INTO Works_on
VALUES (10102, 'p3', 'manager', '1999.1.1');

INSERT INTO Works_on
VALUES (25348, 'p2', 'Clerk', '1998.2.15');

INSERT INTO Works_on
VALUES (18316, 'p2', NULL, '1998.6.1');

INSERT INTO Works_on
VALUES (29346, 'p2', NULL, '1997.12.15');

INSERT INTO Works_on
VALUES (2581, 'p3', 'Analyst', '1998.10.15');

INSERT INTO Works_on
VALUES (9031, 'p1', 'Manager', '198.4.15');

INSERT INTO Works_on
VALUES (28559, 'p1', NULL, '198.8.1');

INSERT INTO Works_on
VALUES (28559, 'p2', 'Clerk',	'1992.2.1');

INSERT INTO Works_on
VALUES (9031, 'p3', 'Clerk', '1997.11.15');


select * from Project
where Project.project_no=Works_on.project_no;

SELECT *
FROM Project
NATURAL JOIN Works_on;

SELECT *
FROM Project
CROSS JOIN Works_on;

SELECT emp_no,Job from Works_on
INNER JOIN Project 
ON Works_on.project_no=Project.project_no
where project_name='Gemini';

SELECT enter_date from Works_on
INNER JOIN Employee
ON Works_on.emp_no=Employee.emp
where Job='clerk';

