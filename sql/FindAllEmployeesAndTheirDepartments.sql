USE [SQLProgrammingTest]
GO

/****** Object:  StoredProcedure [dbo].[FindAllEmployeesAndTheirDepartments]    Script Date: 9/8/2014 7:34:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/7/2014
-- Description:	
--      Write a query that retrieves all employees and departments they work in. 
--      Return their name, job description and their respective departments ordering by the employee’s name. 
-- =============================================
CREATE PROCEDURE [dbo].[FindAllEmployeesAndTheirDepartments]
AS
BEGIN

	SELECT        dbo.Employees.name AS Name, 
				  dbo.Employees.job_description AS JobDescription, 
				  dbo.Departments.name AS Department
	FROM          dbo.Departments 
	INNER JOIN    dbo.Employee_Departments 
	              ON dbo.Departments.department_id = dbo.Employee_Departments.department_id 
	INNER JOIN    dbo.Employees 
	              ON dbo.Employee_Departments.employee_id = dbo.Employees.employee_id
	ORDER BY      Name

END

GO

