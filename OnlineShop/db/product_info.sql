USE [OnlineShop]

CREATE table product_info(
	[Info_id] [int] Primary key Identity(1,1) NOT NULL,
	[Product_id] [int] Foreign key References products(Product_id) NOT NULL,
	[Creator_company] [nvarchar](30) NOT NULL,
	[Release_date] [date] NOT NULL,
	[Annotation] [text] NOT NULL,
)