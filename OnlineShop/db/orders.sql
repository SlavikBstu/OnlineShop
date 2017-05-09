USE [OnlineShop]

CREATE TABLE [orders](
	[Order_id] [int] Primary key IDENTITY(1,1) NOT NULL,
	[Client_id] [int] Foreign key References clients(Client_id) NOT NULL,
	[Product_id] [int] Foreign key References products(Product_id) NOT NULL,
	[Amount_of_products] [int] NOT NULL,
	[Products_price] [money] NOT NULL,
	[Add_date] [date] default getdate() NOT NULL,
)
