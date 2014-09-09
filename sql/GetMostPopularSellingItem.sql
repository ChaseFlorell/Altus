USE [SQLProgrammingTest]
GO

/****** Object:  StoredProcedure [dbo].[GetMostPopularSellingItem]    Script Date: 9/8/2014 7:35:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/7/2014
-- Description:	
--      Write a query that retrieves the most popular selling item. 
--      Return the item’s name, the amount sold and the total profit. 
--      Bonus: Use Common Table Expressions (CTE).
-- =============================================
CREATE PROCEDURE [dbo].[GetMostPopularSellingItem]
AS
BEGIN

	WITH TempSales(Name, Price, QuantitySold)
	AS(
		SELECT        Items.name, Items.price, Employee_Sales.qty_sold
		FROM          Items 
		INNER JOIN    Employee_Sales 
					  ON dbo.Items.item_id = dbo.Employee_Sales.item_id
	)

	SELECT		TOP 1 Name
			   ,TotalProfit
			   ,QuantitySold
	FROM		(SELECT DISTINCT Name
								,SUM(Price * QuantitySold) OVER (PARTITION BY Name) AS TotalProfit
								,SUM(QuantitySold) OVER (PARTITION BY Name) AS QuantitySold
				 FROM TempSales) T
	ORDER BY    QuantitySold DESC

END

GO

