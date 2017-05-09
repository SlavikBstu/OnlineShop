USE [OnlineShop]
GO

/****** Object:  Table [dbo].[orders]    Script Date: 16.03.2017 18:38:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[basket](
	[Basket_id] [int] IDENTITY(1,1) NOT NULL,
	[Client_id] [int] NOT NULL,
	[Product_id] [int] NOT NULL,
	[Add_date] [datetime] NOT NULL,
 CONSTRAINT [PK_basket] PRIMARY KEY NONCLUSTERED 
(
	[Basket_id] ASC
)
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[basket] ADD  CONSTRAINT [DF_basket_AddDate]  DEFAULT (getdate()) FOR [Add_date]
GO


