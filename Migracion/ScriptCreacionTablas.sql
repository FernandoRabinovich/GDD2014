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
	
CREATE TABLE GRAFO_LOCO.Ciudad
	(
	idCiudad int NOT NULL PRIMARY KEY ,
	Nombre char(50) NOT NULL,
	idPais int FOREIGN KEY REFERENCES GRAFO_LOCO.Pais (idPais)
	)  ON [PRIMARY]	
	
CREATE TABLE GRAFO_LOCO.Localidad
	(
	idLocalidad int NOT NULL PRIMARY KEY ,
	Nombre char(50) NOT NULL,
	idCiudad int FOREIGN KEY REFERENCES GRAFO_LOCO.Ciudad (idCiudad)
	)  ON [PRIMARY]		

CREATE TABLE GRAFO_LOCO.Persona
	(
	nroDocumento int NOT NULL PRIMARY KEY ,
	Nombre char (50) NOT NULL,
	Apellido char(50) NOT NULL,
	Direcciòn char(50) NOT NULL,
	Nùmero int NOT NULL,
	Piso int NOT NULL,
	Departamento int,
	idLocalidad int FOREIGN KEY REFERENCES GRAFO_LOCO.Localidad (idLocalidad),
	Teléfono int  NOT NULL,
	FechaNacimiento date NOT NULL,
	Estado char (20) NOT NULL,
	idPais int FOREIGN KEY REFERENCES GRAFO_LOCO.Pais (idPais),
	idTipoDocumento int NOT NULL FOREIGN KEY REFERENCES GRAFO_LOCO.TipoDocumento (idTipo)
	)
	ON [PRIMARY]	
					 		