USE [GameStore]
GO

/****** Object:  Table [dbo].[managers]    Script Date: 16.03.2017 12:23:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[administration_audit](
	[Administration_audit_id][int] IDENTITY(1,1) NOT NULL,
	[Working_id] [int] NOT NULL,
	[Last_login][datetime] NOT NULL,
 CONSTRAINT [PK_administration_audit] PRIMARY KEY CLUSTERED 
(
	[Administration_audit_id] ASC
)
) ON [PRIMARY]

GO


