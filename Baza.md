# SQL naredbe za izradu baze podataka


Create DATABASE Filmovi

GO


USE Filmovi


Create TABLE Film

(

Film_ID INT PRIMARY KEY IDENTITY (1,1) ,

Ime_filma NVARCHAR(100),

Žanr NVARCHAR(30),

Godina_izdanja INT,

Zarada MONEY

)


Create TABLE Strani_film

(

Film_ID INT PRIMARY KEY,

Lokalizirano_hrvatsko_ime NVARCHAR(100),

Država_podrijetla NVARCHAR(100),


Constraint FK_Strani_film

FOREIGN KEY (Film_ID)

REFERENCES Film(Film_ID)

)


Create TABLE Hrvatski_film

(

Film_ID INT PRIMARY KEY,

Englesko_ime NVARCHAR(100),


Constraint FK_Hrvatski_film

FOREIGN KEY (Film_ID)

REFERENCES Film(Film_ID)

)


Create TABLE Nagrada

(

Nagrada_ID INT PRIMARY KEY IDENTITY (1,1),

Film_ID INT,

Organizacija NVARCHAR(100),

Kategorija NVARCHAR(100),

Godina_dodjele INT,


CONSTRAINT FK_Nagrada_Film

FOREIGN KEY (Film_ID)

REFERENCES Film (Film_ID)

)