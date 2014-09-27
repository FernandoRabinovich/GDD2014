USE [GD2C2014]
GO

CREATE TABLE GRAFO_LOCO.RegimenHotel
	(
	CodigoRegimen int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	Precio decimal (19,2) NOT NULL,
	Estado char (10) NOT NULL) 
	 ON [PRIMARY]