USE [OnlineShop]
GO

/****** Object:  Table [dbo].[managers]    Script Date: 16.03.2017 12:23:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[administration](
	[Working_id] [int] IDENTITY(1,1) NOT NULL,
	[Working_login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Access_level] [int] check(Access_level between 1 and 2) NOT NULL,
 CONSTRAINT [PK_managers] PRIMARY KEY CLUSTERED 
(
	[Working_id] ASC
)
) ON [PRIMARY]

GO


