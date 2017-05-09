USE [OnlineShop]
GO

/****** Object:  Table [dbo].[managers]    Script Date: 16.03.2017 12:23:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[review](
	[Review_id] [int] IDENTITY(1,1) NOT NULL,
	[Client_id] [int] NOT NULL,
	[Product_id] [int] NOT NULL,
	[Date_of_review] [datetime] NOT NULL,	
	[Rating] [int] check (Rating between 0 and 6) default (0) NOT NULL,
	[Message] [text] NOT NULL,
 CONSTRAINT [PK_review] PRIMARY KEY CLUSTERED 
(
	[Review_id] ASC
)
) ON [PRIMARY]

GO

