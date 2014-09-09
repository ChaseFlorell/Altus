USE [SQLProgrammingTest]
GO

/****** Object:  StoredProcedure [dbo].[FindEmployeesThatWorkInMoreThanOneDepartment]    Script Date: 9/8/2014 7:35:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/7/2014
-- Description:	
--      Write a query that retrieves all employees that work in more than one department. 
--      Return the employee’s name and the name of each department. 
-- =============================================
CREATE PROCEDURE [dbo].[FindEmployeesThatWorkInMoreThanOneDepartment]
AS
BEGIN

	WITH TempEmployees(Name, Department, EmployeeId)
	AS(
		SELECT        Employees.name
					 ,Departments.name AS Department
					 ,Employees.employee_id

		FROM          Employees 
		INNER JOIN    Employee_Departments 
					  ON Employees.employee_id = Employee_Departments.employee_id
		INNER JOIN    Departments 
					  ON Employee_Departments.department_id = Departments.department_id
	)

	SELECT   Name
			,Department
		
	FROM     (SELECT Name, Department, COUNT(EmployeeId)
			  OVER (PARTITION BY EmployeeId) AS NumberOfDepartments
			  FROM TempEmployees) T
	WHERE    NumberOfDepartments > 1
	ORDER BY Name

END

GO

