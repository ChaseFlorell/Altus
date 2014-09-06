CREATE DATABASE SQLProgrammingTest;
GO
 
 
USE SQLProgrammingTest
GO

CREATE TABLE Employees(
	employee_id int identity(1,1) not null,
	name nvarchar(255),
	job_description nvarchar(255),
	active bit, 
	salary money,
	CONSTRAINT pk_Employees PRIMARY KEY(employee_id)
)
GO



CREATE TABLE Departments(
	department_id int identity(1,1) not null,
	name nvarchar(255), 	
	CONSTRAINT pk_Departments PRIMARY KEY(department_id)
	
)
GO

CREATE TABLE Employee_Departments(
	department_id int not null,
	employee_id int not null,
	foreign key (department_id) references Departments(department_id),
	foreign key (employee_id) references Employees(employee_id)
)



CREATE TABLE Items(
	item_id int identity(1,1) not null,
	name nvarchar(255),
	price money,
	commission_percent decimal(5,2)
	CONSTRAINT pk_Items PRIMARY KEY(item_id)
)
GO



CREATE TABLE Employee_Sales(
	employee_sales_id int identity(1,1) not null,
	sales_date datetime not null,
	item_id int,
	qty_sold int not null,
	employee_id int,
	CONSTRAINT pk_Employee_Sales PRIMARY KEY(employee_sales_id),
	foreign key (item_id) references Items(item_id),
	foreign key (employee_id) references Employees(employee_id)
)
GO



INSERT INTO Employees(name, active, salary, job_description)
VALUES('Bob Smith',1,45000, 'Sales Representative')

INSERT INTO Employees(name, active, salary, job_description)
VALUES('John Doe',1,50000, 'Sales Representative')

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Katherine Brown',1,40000, 'Sales Representative')

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Andrew Thompson',1,65000, 'Administrative Assistant' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Anita Patel',1,70000, 'Branch Manager' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Alex Wong',1,35000, 'Sales Representative' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Brad Hunter',1,60000, 'Branch Manager' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Arun Shah',1,43000, 'Sales Representative' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Chris Kim',1,50000, 'Administrative Assistant' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Jason Stride',1,42000, 'Branch Manager' )

INSERT INTO Employees(name, active, salary, job_description)
VALUES('Bobby Smith',1,44000, 'Branch Manager' )

INSERT INTO Departments(name)
VALUES('Sales Department')

INSERT INTO Departments(name)
VALUES('Management Department')

INSERT INTO Departments(name)
VALUES('Administrative Department')

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(1,1)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(2,1)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(3,1)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(6,1)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(8,1)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(4,3)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(9,3)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(5,2)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(7,2)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(10,2)

INSERT INTO Employee_Departments(employee_id,department_id)
VALUES(11,2)

INSERT INTO Employee_Departments(department_id, employee_id)
VALUES (2,3)


INSERT INTO Items(name, price, commission_percent) VALUES ('iPhone 5', '500.00', 5)
INSERT INTO Items(name, price, commission_percent) VALUES ('Kleenex Box', '3.50', 3)
INSERT INTO Items(name, price, commission_percent) VALUES ('Frisbee', '2.00',5)
INSERT INTO Items(name, price, commission_percent) VALUES ('Fan', '15.00', 7)
INSERT INTO Items(name, price, commission_percent) VALUES ('Blackberry Bold', '250.00',12)
INSERT INTO Items(name, price, commission_percent) VALUES ('22" HD Monitor', '450.00', 15)
INSERT INTO Items(name, price, commission_percent) VALUES ('Gym Bag', '55.00', 11)



INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2013-01-01 00:00:00.000', 1, 2, 3)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2011-10-21 00:00:00.000', 1, 4, 1)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2012-07-24 00:00:00.000', 1, 2, 2)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2013-06-04 00:00:00.000', 1, 2, 3)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-02-10 00:00:00.000', 3, 50, 3)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-02-08 00:00:00.000', 7, 1, 2)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-14 00:00:00.000', 4, 1, 1)

INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-03 00:00:00.000', 2, 20, 3)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-07 00:00:00.000', 6, 2, 2)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-12 00:00:00.000', 4, 10, 1)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-12 00:00:00.000', 7, 2, 1)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-21 00:00:00.000', 7, 3, 3)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-26 00:00:00.000', 3, 55, 3)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-29 00:00:00.000', 3, 33, 1)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-31 00:00:00.000', 2, 25, 2)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-01 00:00:00.000', 2, 5, 2)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-18 00:00:00.000', 2, 10, 2)
INSERT INTO Employee_Sales(sales_date, item_id, qty_sold, employee_id)
VALUES('2014-01-20 00:00:00.000', 5, 2, 3)



select * from Employees
select * from Departments
select * from Employee_Departments
select * from Employee_Sales
select * from Items