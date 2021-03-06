USE [OnlineShop]

CREATE TABLE [orders](
	[Order_id] [int] Primary key IDENTITY(1,1) NOT NULL,
	[Client_id] [int] Foreign key References users(User_id) NOT NULL,
	[Product_id] [int] Foreign key References products(Product_id) NOT NULL,
	[Add_date] [date] default getdate() NOT NULL,
)
