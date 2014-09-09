
USE [SQLProgrammingTest]
GO

-- =============================================
-- Author:		Chase Florell
-- Create date: 9/7/2014
-- Description:	
--      The business is booming and as a new business requirement customers are required to be tracked. 
--      How would you modify the existing database to keep track of customers and the items that they buy?
-- =============================================

-- *********************************************
-- NOTE: This script encompasses both the customer order tracking and the Orders table improvement challenges.
-- The original challenge script is inserted and then altered.
-- *********************************************

CREATE TABLE [dbo].[Cities]
(
	 [Id] int IDENTITY(1,1) NOT NULL
	,[Name] nvarchar(30) NOT NULL

	CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
    (
		[Id] ASC
	)
)
GO

CREATE TABLE [dbo].[Provinces]
(
	 [Id] int IDENTITY(1,1) NOT NULL
	,[Name] nvarchar(30) NOT NULL

	CONSTRAINT [PK_Provinces] PRIMARY KEY CLUSTERED 
    (
		[Id] ASC
	)
)
GO

CREATE TABLE [dbo].[Customers]
(
	 [customer_id] [bigint] IDENTITY(1,1) NOT NULL
	,[Name] [nvarchar](50) NOT NULL
	,[Address1] nvarchar(50) NOT NULL
	,[Address2] nvarchar(50) NULL
	,[CityId] int NOT NULL
	,[ProvinceId] int NOT NULL
	,[PostalCode] nvarchar(7)
	,[PhoneNumber] nvarchar(15)

	CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
    (
		[customer_id] ASC
	)

	CONSTRAINT [FK_Customers_Cities] FOREIGN KEY([ProvinceId])
	REFERENCES [dbo].[Provinces]([Id])
)
GO
-- =============================================
-- As the main developer of the system (backend and frontend), 
-- what can you do to improve the performance of this interface?
-- =============================================

-- original orders script submitted for test
CREATE TABLE orders ( [order_id] [bigint] NOT NULL, [item_id] [bigint] NOT NULL, [customer_id] [bigint] NOT NULL, [date] [datetime] NOT NULL, [price] [money] NOT NULL, CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ( [order_id] ASC ) )

EXEC sp_rename orders, Orders
GO 

ALTER TABLE [dbo].[Orders]
DROP CONSTRAINT PK_Orders;

ALTER TABLE [dbo].[Orders] ALTER COLUMN [item_id] int NOT NULL
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Items] FOREIGN KEY([item_id])
REFERENCES [dbo].[Items] ([item_id])
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
GO

ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Order_item_customer_COMPOSITE] PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC,
	[item_id] ASC,
	[customer_id] ASC

)
GO

ALTER TABLE [dbo].[Orders] ADD [Order_date] datetime NOT NULL
GO
