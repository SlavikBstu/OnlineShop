USE [OnlineShop]

CREATE TABLE [products](
	[Product_id] [int] Primary key IDENTITY(1, 1)  NOT NULL,
	[Title] [nvarchar](25) NOT NULL,
	[Category_id] [int] Foreign key References category(Category_id) NOT NULL,	
	[Amount] [int] default 0 NOT NULL, 
	[Price] [money] NOT NULL,
	[Stock] [int] NOT NULL,
	[Picture] [nvarchar](100) NOT NULL,
	[Add_date] [date] default getdate() NOT NULL
)


