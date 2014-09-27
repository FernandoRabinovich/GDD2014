USE [GD2C2014]
GO

CREATE TABLE GRAFO_LOCO.UbicacionHabitacion
	(
	idTipo int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	)  ON [PRIMARY]
	
CREATE TABLE GRAFO_LOCO.TipoHabitacion
	(
	idTipo int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	Porcentaje decimal (3,2)  NOT NULL,
	)  ON [PRIMARY]
	
CREATE TABLE GRAFO_LOCO.TipoDocumento
	(
	idTipo int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	)  ON [PRIMARY]
	
CREATE TABLE GRAFO_LOCO.Rol
	(
	idRol int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	Estado int  NOT NULL,
	)  ON [PRIMARY]		
	
CREATE TABLE GRAFO_LOCO.RegimenHotel
	(
	CodigoRegimen int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	Precio decimal (19,2) NOT NULL,
	Estado char (10) NOT NULL) 
	 ON [PRIMARY]
	 
CREATE TABLE GRAFO_LOCO.Pais
	(
	idPais int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	)  ON [PRIMARY]
	
CREATE TABLE GRAFO_LOCO.MotivoInhabilitacion
	(
	idMotivo int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	)  ON [PRIMARY]
	
CREATE TABLE GRAFO_LOCO.Funcionalidad
	(
	idFuncionalidad int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
	)  ON [PRIMARY]
	
CREATE TABLE GRAFO_LOCO.EstadoReserva
	(
	idEstado int NOT NULL PRIMARY KEY,
	Descripcion char(50) NOT NULL,
		)  ON [PRIMARY]
		
CREATE TABLE GRAFO_LOCO.Consumible
	(
	idConsumible int NOT NULL PRIMARY KEY ,
	Descripcion char(50) NOT NULL,
	Precio decimal(19, 2) NOT NULL
	)  ON [PRIMARY]						 		