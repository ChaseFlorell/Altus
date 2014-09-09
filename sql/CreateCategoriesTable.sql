USE [SQLProgrammingTest]
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/7/2014
-- Description:	
--      Design a database structure that represents a tree of categories. 
--      Each category has a name and exactly one parent category. 
--      Describe using T-SQL syntax how you would retrieve all categories directly under a particular category (all children).
-- =============================================

CREATE TABLE [dbo].[Categories]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ParentId] [bigint] NULL,
	[Name] [nvarchar](20) NOT NULL,
	CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)
) 
GO

ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Categories] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Categories] ([Id])
GO

ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Categories]
GO


