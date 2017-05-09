USE [OnlineShop]
GO

/****** Object:  Table [dbo].[managers]    Script Date: 16.03.2017 12:23:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[client_audit](
	[Client_audit_id][int] IDENTITY(1,1) NOT NULL,
	[Client_id] [int] NOT NULL,
	[Register_date] [date] NOT NULL,
	[Login_count] [int] NOT NULL,
	[Last_login][date] NOT NULL,
 CONSTRAINT [PK_clientAudit] PRIMARY KEY CLUSTERED 
(
	[Client_audit_id] ASC
)
) ON [PRIMARY]

GO


