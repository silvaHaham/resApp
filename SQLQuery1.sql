drop TABLE Restaurants_2021

CREATE TABLE [Restaurants_2021] (
	[id]  int NOT NULL ,
	[photo] nvarchar (225) ,
	[name] nvarchar (30) NOT NULL ,
	[aggregate_rating] float NOT NULL ,
	[cuisines] nvarchar (20) NOT NULL ,
	[price_range] smallint NOT NULL ,
	[address] nvarchar (200) NOT NULL ,
	[phon_numbers] nvarchar (40) NOT NULL ,
	Primary key (id)
)

--INSERT INTO [Restaurants_2021]
--           ([name],
--            [age]
--           )
--     VALUES
--           ('dani',
--           25	
--	   )
 
 
 
 
 
 select * from Restaurants_2021
