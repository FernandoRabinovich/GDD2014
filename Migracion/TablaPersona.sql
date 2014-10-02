CREATE TABLE GRAFO_LOCO.Persona
	(
	nroDocumento int NOT NULL PRIMARY KEY ,
	Nombre char (50) NOT NULL,
	Apellido char(50) NOT NULL,
	Direcci�n char(50) NOT NULL,
	N�mero int NOT NULL,
	Piso int NOT NULL,
	Departamento int,
	idLocalidad int FOREIGN KEY REFERENCES GRAFO_LOCO.Localidad (idLocalidad),
	Tel�fono int  NOT NULL,
	FechaNacimiento date NOT NULL,
	Estado char (20) NOT NULL,
	idPais int FOREIGN KEY REFERENCES GRAFO_LOCO.Pais (idPais),
	idTipoDocumento int NOT NULL FOREIGN KEY REFERENCES GRAFO_LOCO.TipoDocumento (idTipo)
	)
	ON [PRIMARY]	