﻿USE [SQLProgrammingTest]
GO
/****** Object:  StoredProcedure [dbo].[OrdersTablePerformanceImprovement]    Script Date: 9/8/2014 8:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chase Florell
-- Create date: 9/8/2014
-- Description:	
--      Your website provides customers with the functionality to display all their past orders. 
--      The traffic on the website is high and the below query is executed frequently and is extremely slow: 
--            SELECT order_id, item_id, date, price FROM orders WHERE customer_id = @this_customer
--      As the main developer of the system (backend and frontend), what can you do to improve the performance of this interface?
-- =============================================

ALTER TABLE [dbo].[orders]
DROP CONSTRAINT PK_orders;

ALTER TABLE [dbo].[orders] ALTER COLUMN [item_id] int NOT NULL
GO

ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_items] FOREIGN KEY([item_id])
REFERENCES [dbo].[Items] ([item_id])
GO

ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_customers] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
GO

ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [PK_order_item_customer_COMPOSITE] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[item_id] ASC,
	[customer_id] ASC

)
GO

ALTER TABLE [dbo].[orders] ADD [order_date] datetime NOT NULL
GO
