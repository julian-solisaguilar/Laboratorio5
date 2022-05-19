CREATE TABLE Pais(
	Id INTEGER PRIMARY KEY IDENTITY,
	Nombre VARCHAR(200) NOT NULL,
	Idioma VARCHAR(200) NOT NULL,
	Continente NVARCHAR(100) NOT NULL
)

INSERT INTO [dbo].[Pais] ([Nombre],[Idioma] ,[Continente])
VALUES('Costa Rica', 'Español', 'América'),
('Alemania', 'Alemán', 'Europa'),
('Canadá', 'Inglés/Frances', 'América'),
('Japón', 'Japonés', 'Asia'),
('España', 'Español', 'Europa')

SELECT * 
FROM Pais
