-- create a table
CREATE TABLE Customers
(
Customerid char(5) not null,
CompanyName varchar(40) not null,
contactName char(30),
Address varchar(60),
City char(15),
Phone char(24),
Fax char(24)
);

CREATE TABLE Orders
(
OrderId int not null,
customerId char(5) not null,
Orderdate datetime,
Shippeddate datetime,
Freight money float,
Shipname varchar(40),
Shipaddres varchar(60),
Quantity int
);

ALTER TABLE Orders
ADD Shipregion int;

ALTER TABLE Orders
ALTER COLUMN Shipregion char(8);

ALTER TABLE Orders
DROP COLUMN Shipregion;

INSERT INTO Orders
VALUES (10, 'ord01', DATE(), DATE(), 100.0, 'Windstar', 'Ocean' ,1);


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

select * from Works_on;

select emp_no from Works_on
where Job='Clerk';

select emp_no from Works_on
where project_no='p2' and emp_no<10000;


select emp_no from Works_on
where project_no='p1' and Job='Analyst' or 'Manager';

select enter_date from Works_on
where Job=NULL and project_no='p2';

select emp from Employee
INNER JOIN Department
ON Employee.dept = Department.Dept
where location='Seattle';

select emp_fna,emp_lna from Employee
INNER JOIN Works_on
ON Employee.emp=Works_on.emp_no
where enter_date='1998.1.4';

SELECT Dept
FROM Department
GROUP BY location;

SELECT max(emp_no)
FROM Works_on;

SELECT emp_no from Works_on
INNER JOIN Employee
ON Works_on.emp_no=Employee.emp
where dept='d3' or Job='Clerk';

