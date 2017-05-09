USE [OnlineShop]

CREATE TABLE [users](
	[User_id] [int] Primary key IDENTITY(1, 1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Surname] [nvarchar](25) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Sex] [nchar](1) check(Sex in ('ì','æ')) NOT NULL,
	[Email] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15),
	[Avatar] [nvarchar](100) ,
	[Register_date] [date] default getdate() NOT NULL,
)

select * from clients

delete from clients

insert into clients(Name, Surname, Birthday, Sex, Email, Password, Phone, Avatar)
values ('Name1', 'Surname1', '12-12-2012', 'æ', 'Email1', 'Password1', 'Phone1', 'Avatar1')