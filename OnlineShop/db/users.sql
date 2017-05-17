USE [OnlineShop]

CREATE TABLE [users](
	[User_id] [int] Primary key IDENTITY(1, 1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Surname] [nvarchar](25) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Sex] [nchar](1) check(Sex in ('ì','æ')) NOT NULL,
	[Email] [nvarchar](80) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15),
	[Address] [nvarchar](150) NOT NULL,
	[Avatar] [nvarchar](100) default ('~/ImgAvatars/default.png'),
	[Register_date] [date] default getdate() NOT NULL,
)


select * from users

delete from users

insert into users(Name, Surname, Birthday, Sex, Email, Password, Phone, Address)
values ('Name1', 'Surname1', '12-12-2012', 'æ', 'Email1', 'Password1', 'Phone1', 'Address1')