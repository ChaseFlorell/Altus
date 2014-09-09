USE [SQLProgrammingTest]
GO

/****** Object:  StoredProcedure [dbo].[GetTopCommissionedEmployeeForTheMonthOfJanuary]    Script Date: 9/8/2014 7:35:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/7/2014
-- Description:	
--       Write a query that retrieves the employee that has earned the most commission for January 2014. 
--       Return the employee’s name and the amount of commission they earned. 
-- =============================================
CREATE PROCEDURE [dbo].[GetTopCommissionedEmployeeForTheMonthOfJanuary]
AS
BEGIN

	WITH EmployeeSales(Name, QuantitySold, Price, SalesDate, CommissionPercentage)
	AS(
		SELECT        Employees.name
					 ,Employee_Sales.qty_sold
					 ,Items.price
					 ,Employee_Sales.sales_date
					 ,Items.commission_percent
		FROM          Employees 
		INNER JOIN    Employee_Sales 
					  ON Employees.employee_id = Employee_Sales.employee_id 
		INNER JOIN    Items 
					  ON Employee_Sales.item_id = Items.item_id
	)

	SELECT TOP 1   Name 
				  ,SalesDate
				  ,CommissionEarned
	FROM          (SELECT DISTINCT NAME
								  ,SalesDate
								  ,SUM(((CommissionPercentage / 100) * Price) * QuantitySold) OVER (PARTITION BY Name) AS CommissionEarned
				   FROM EmployeeSales) T

	WHERE          SalesDate > '2014/01/01' 
	AND            SalesDate < '2014/02/01'
	ORDER BY       CommissionEarned DESC

END

GO

