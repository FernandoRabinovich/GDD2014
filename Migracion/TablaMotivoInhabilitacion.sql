USE [GD2C2014]
GO

CREATE TABLE GRAFO_LOCO.MotivoInhabilitacion
	(
	idMotivo int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	)  ON [PRIMARY]