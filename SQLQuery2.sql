drop TABLE Customers_2021

CREATE TABLE [Customers_2021](
[id]  smallint IDENTITY (1,1) NOT NULL ,
	[fname] nvarchar (10) NOT NULL ,
	[lname] nvarchar (20) NOT NULL ,
	[email] nvarchar (40) NOT NULL ,
	[phoneN] nvarchar (30) NOT NULL ,
	[password] nvarchar (30) NOT NULL ,
	[photoName] nvarchar (30) NOT NULL ,

	primary key (id)
)

INSERT INTO Customers_2021([id], [fname], [lname], [email], [phoneN], [password], [photoName]) values ('12432', 'silva', 'haham', 'silva@gmail.com','054-60-67845', '1234AAFFffd', 'silv')

select * from Customers_2021
