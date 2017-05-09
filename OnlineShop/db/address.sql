USE [OnlineShop]

CREATE TABLE [address](
	[Address_id] [int] Primary key IDENTITY(1,1) NOT NULL,
	[User_id] [int] Foreign key References users(User_id) NOT NULL,
	[Country] [nvarchar](30) NOT NULL,
	[Region] [nvarchar](30) NOT NULL,
	[City] [nvarchar](30) NOT NULL,
	[Number_of_house] [nvarchar](5) NOT NULL,
	[Number_of_flat] [int] NOT NULL,
	[Email_index] [int] NOT NULL,
)


