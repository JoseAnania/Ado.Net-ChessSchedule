CREATE DATABASE ChessSchedule

USE ChessSchedule

CREATE TABLE Pais
(
idPais INT IDENTITY (1,1) NOT NULL,
nombre VARCHAR (50) NOT NULL,
CONSTRAINT PK_Pais PRIMARY KEY (idPais)
)

CREATE TABLE Avatar
(
idAvatar INT IDENTITY (1,1) NOT NULL,
nombre VARCHAR (50) NOT NULL,
CONSTRAINT PK_Avatar PRIMARY KEY (idAvatar)
)

CREATE TABLE Nivel
(
idNivel INT IDENTITY (1,1) NOT NULL,
nombre VARCHAR (50) NOT NULL,
CONSTRAINT PK_Nivel PRIMARY KEY (idNivel)
)

CREATE TABLE Color
(
idColor INT IDENTITY (1,1) NOT NULL,
nombre VARCHAR (50) NOT NULL,
CONSTRAINT PK_Color PRIMARY KEY (idColor)
)

CREATE TABLE Resultado
(
idResultado INT IDENTITY (1,1) NOT NULL,
nombre VARCHAR (50) NOT NULL,
CONSTRAINT PK_Resultado PRIMARY KEY (idResultado)
)

CREATE TABLE Partida
(
idPartida INT IDENTITY (1,1) NOT NULL,
fecha DATE NOT NULL,
idPais INT,
idAvatar INT,
idNivel INT,
idColor INT,
idResultado INT,
CONSTRAINT PK_Partida PRIMARY KEY (idPartida),
CONSTRAINT FK_Partida_Pais FOREIGN KEY (idPais) REFERENCES Pais (idPais),
CONSTRAINT FK_Partida_Avatar FOREIGN KEY (idAvatar) REFERENCES Avatar (idAvatar),
CONSTRAINT FK_Partida_Nivel FOREIGN KEY (idNivel) REFERENCES Nivel (idNivel),
CONSTRAINT FK_Partida_Color FOREIGN KEY (idColor) REFERENCES Color (idColor),
CONSTRAINT FK_Partida_Resultado FOREIGN KEY (idResultado) REFERENCES Resultado (idResultado)
)

----STORE PROCEDURE----

CREATE PROCEDURE SP_InsertarPais
@nombre VARCHAR (50)
AS	
	BEGIN
		IF (SELECT COUNT(*) FROM Pais WHERE nombre=@nombre)>0
		PRINT 'Ya existe ese nombre de País'
		ELSE
		INSERT INTO Pais(nombre)
		VALUES (@nombre)
	END

----VIEWS----

CREATE VIEW V_ConsultaPais
AS
	SELECT TOP 100 * FROM Pais 
	ORDER BY nombre ASC




	
