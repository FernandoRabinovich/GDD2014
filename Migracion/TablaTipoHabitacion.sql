USE [GD2C2014]
GO

CREATE TABLE GRAFO_LOCO.TipoHabitacion
	(
	idTipo int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	Porcentaje decimal (3,2)  NOT NULL,
	)  ON [PRIMARY]