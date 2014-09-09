USE [SQLProgrammingTest]
GO

/****** Object:  StoredProcedure [dbo].[RemoveDuplicatesFromSystemLogs]    Script Date: 9/8/2014 7:35:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/8/2014
-- Description:	
--      A new table is introduced to keep track of system logs called “System_Logs”. 
--      This table consists of 4 columns. 
--      Assuming the table has 100 rows and includes no NULL values and has no primary keys or unique constraints, 
--      write a single SQL statement that deletes all duplicate records (i.e. keep one copy) from the table “System_Logs”.
-- =============================================
CREATE PROCEDURE [dbo].[RemoveDuplicatesFromSystemLogs]
AS
BEGIN

	WITH System_Logs_CTE
	AS (
		SELECT	ROW_NUMBER() 
		OVER	(PARTITION BY BINARY_CHECKSUM(*) -- really don't care what the field names are as long as the checksum matches.
				 ORDER BY (SELECT 0)) RowNumber
		FROM System_Logs
	)

	DELETE FROM System_Logs_CTE 
	WHERE RowNumber > 1

END

GO

